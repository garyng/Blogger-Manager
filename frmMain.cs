using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Blogger.v3;
using Google.Apis.Blogger.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;


namespace Blogger_Manager
{
	public partial class frmMain : Form
	{
		BloggerManager bm = new BloggerManager();
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			bm.Login();
			lbInfo.HorizontalScrollbar = true;
			lbInfo.Items.Add("Access Token : " + bm.Credential.Token.AccessToken.ToString());
			lbInfo.Items.Add("Expires in : " + bm.Credential.Token.ExpiresInSeconds.ToString() + " s");

			int i = 1;
			foreach (Blog b in bm.listAllBlogs())
			{
				lbInfo.Items.Add("Blogs #" + i .ToString() + " " + b.Name);

				foreach (Pageviews.CountsData cd in bm.getPageViews(b.Id,PageViewsResource.GetRequest.RangeEnum.All))
				{
					lbInfo.Items.Add("Blogs #" + i.ToString() + " Pageviews in " + cd.TimeRange + " : " + cd.Count);
				}

				BlogPerUserInfo bpui =  bm.getBlogUserInfo(b.Id);
				lbInfo.Items.Add("Blogs #" + i.ToString() + " Blog Id :  "  + bpui.BlogId + " User Id : " + bpui.UserId + " Admin : " + bpui.HasAdminAccess);

				i++;
			}

			bm.getBlogUserInfo(bm.BlogsList[0].Id);
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			bm.Logout();
		}
	}

	class BloggerManager
	{

		ClientSecrets _csAppSec = new ClientSecrets
		{
			ClientId = "178155491025-hbrlr7unavrqoe3km159gjhj72bd7jrd.apps.googleusercontent.com",
			ClientSecret = "YcEEotezPs1G3n89nqucwF9M"
		};

		UserCredential _ucUser = null;
		BloggerService _bsBlog = null;
		IList<Blog> _blBlogs = null;
		FileDataStore _fdsToken = new FileDataStore("BloggerManager");

		public void Login()
		{
			//Timeout
			new Thread(delegate()
			{
				Thread.Sleep(30000);
				if (_ucUser == null)
				{
					throw new Exception("Authorization timeout 30s");
				}
			}) { IsBackground = true }.Start();

			_ucUser = GoogleWebAuthorizationBroker.AuthorizeAsync(
				_csAppSec,
				new[] { BloggerService.Scope.Blogger },
				"user",
				CancellationToken.None,
				_fdsToken
				).Result;

			_bsBlog = new BloggerService(new BaseClientService.Initializer()
				{
					HttpClientInitializer = _ucUser,
					ApplicationName = "Blogger Manager"
				});
		}

		public void Logout()
		{
			_ucUser = null;
			_bsBlog = null;
			_blBlogs = null;
			_fdsToken.ClearAsync();
		}

		public IList<Blog> listAllBlogs()
		{
			if (_bsBlog == null)
			{
				return null;
			}
			BlogsResource.ListByUserRequest req = _bsBlog.Blogs.ListByUser("self");
			BlogList bl = req.Execute();
			_blBlogs = bl.Items;
			return bl.Items;			
		}


		public IList<Pageviews.CountsData> getPageViews(string blogId, PageViewsResource.GetRequest.RangeEnum range)
		{
			if (_bsBlog == null)
			{
				return null;
			}
			PageViewsResource.GetRequest req = _bsBlog.PageViews.Get(blogId);
			req.Range = range;
			Pageviews pg = req.Execute();
			//ALL time 30 days 7 days
			return pg.Counts;
		}

		public BlogPerUserInfo getBlogUserInfo(string blogId)
		{
			if (_bsBlog == null)
			{
				return null;
			}
			BlogUserInfosResource.GetRequest req = _bsBlog.BlogUserInfos.Get("self", blogId);
			BlogUserInfo bui = req.Execute();
			return bui.BlogUserInfoValue;
		}

		public UserCredential Credential
		{
			get
			{
				return _ucUser;
			}
		}

		public BloggerService Service
		{
			get
			{
				return _bsBlog;
			}
		}

		public IList<Blog> BlogsList
		{
			get
			{
				return _blBlogs;
			}
		}
	}
}
