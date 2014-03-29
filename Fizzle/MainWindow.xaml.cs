using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Tweetinvi;
using TweetinviCore.Interfaces;
using TweetinviCore.Interfaces.oAuth;
using TweetinviCore.Interfaces.Credentials;

namespace Fizzle
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public Account account;
		
		public MainWindow()
		{
			InitializeComponent();

			account = new Account("1586652572-ZsDFzQbbeHVKDEtS82Y6gAg8QZ9XYnk198yg6Xx", "6lVkISwXMAi2BOSpos3klwMt1qTlCmuaZnkkGibOi2I2v");
		}

		private void PostTweet_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = TweetText.Text.Length > 0 && TweetText.Text.Length <= 140;
		}

		private void PostTweet_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			String text = TweetText.Text;
			account.DoAsync(() => { Tweet.PublishTweet(text); });
		}
	}
}
