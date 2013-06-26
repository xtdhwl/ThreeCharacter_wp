using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ThreeCharaset.Resources;
using System.Windows.Media.Animation;

namespace ThreeCharaset
{
    public partial class MainPage : PhoneApplicationPage
    {

     

        public MainPage()
        {
            InitializeComponent(); 
            
         
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            //播放动画
            //playView.
            //Point fromPoint = new Point(300, 300);
            //Point toPoint = new Point(0, 0);
            //PointAnimation animation = new PointAnimation();
            //animation.From = fromPoint;
            //animation.To = toPoint;


            //animation.Duration = new Duration(TimeSpan.FromSeconds(5));

            //Storyboard myStoryboard = new Storyboard();
            //myStoryboard.Children.Add(animation);

            //Storyboard.SetTargetName(myStoryboard, playView.Name);
            //myStoryboard.Begin();
            //staticAnimation.Begin();
        }

        private void open_Clicker(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri uri = new Uri("/PlayPage.xaml", UriKind.Relative);
            NavigationService.Navigate(uri);
        }
      
    }
}