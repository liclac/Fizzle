using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using TweetinviCore.Interfaces.oAuth;

namespace Fizzle
{
	public class Account
	{
		public IOAuthCredentials credentials { get; set; }

		public Account(String accessToken, String accessSecret)
		{
			credentials = TwitterCredentials.CreateCredentials(accessToken, accessSecret, ConfigurationManager.AppSettings["consumerKey"], ConfigurationManager.AppSettings["consumerSecret"]);
		}

		public void Do(Action action)
		{
			TwitterCredentials.ExecuteOperationWithCredentials(credentials, action);
		}

		public void DoAsync(Action action)
		{
			Task.Factory.StartNew(() => Do(action));
		}
	}
}
