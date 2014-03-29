using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fizzle
{
	public static class Commands
	{
		public static readonly RoutedUICommand PostTweet = new RoutedUICommand("Post Tweet", "PostTweet", typeof(MainWindow));
	}
}
