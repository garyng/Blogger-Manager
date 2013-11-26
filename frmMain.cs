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
		public frmMain()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			BloggerManager bm = new BloggerManager();
			bm.Authorize();
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
				i++;
			}
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


		public void Authorize()
		{
			_ucUser = GoogleWebAuthorizationBroker.AuthorizeAsync(
				_csAppSec,
				new[] { BloggerService.Scope.Blogger },
				"user",
				CancellationToken.None,
				new FileDataStore("BloggerManager")
				).Result;
			_bsBlog = new BloggerService(new BaseClientService.Initializer()
				{
					HttpClientInitializer = _ucUser,
					ApplicationName = "Blogger Manager"
				});
		}

		public IList<Blog> listAllBlogs()
		{
			BlogsResource.ListByUserRequest req = _bsBlog.Blogs.ListByUser("self");
			BlogList bl = req.Execute();
			_blBlogs = bl.Items;
			return bl.Items;			
		}


		public IList<Pageviews.CountsData> getPageViews(string blogId, PageViewsResource.GetRequest.RangeEnum range)
		{
			PageViewsResource.GetRequest req = _bsBlog.PageViews.Get(blogId);
			req.Range = range;
			Pageviews pg = req.Execute();
			//ALL time 30 days 7 days
			IList<Pageviews.CountsData> cd = pg.Counts;
			return cd;
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
