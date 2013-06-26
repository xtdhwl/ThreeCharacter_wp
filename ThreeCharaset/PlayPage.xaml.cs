using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ThreeCharaset
{
    public partial class PlayPage : PhoneApplicationPage
    {
       private string mCurrentState;

       public PlayPage()
        {
            InitializeComponent(); 
            
            mediaElement.CurrentStateChanged += new RoutedEventHandler(mediaElement_CurrentStateChanged);
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        void mediaElement_CurrentStateChanged(object sender, RoutedEventArgs e)
        {
            // 显示 MediaElement 的当前状态
            mCurrentState = mediaElement.CurrentState.ToString();
            Log.i("mCurrentState :{0}", mCurrentState);
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
            
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            // 暂停
            mediaElement.Pause();
        }

      
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Log.i("OnNavigatedTo:{0}", e.NavigationMode);
            Uri u = new Uri("Assets/Demo.mp4", UriKind.Relative);
            mediaElement.Source = u;
            playView.Visibility = Visibility.Visible;
        }

        private void play_Clicker(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (playView.Visibility == Visibility.Collapsed)
            {
                if (mediaElement.CanPause)
                {
                    mediaElement.Pause();
                    playView.Visibility = Visibility.Visible;
                 }
            }else{
                mediaElement.Play();
                playView.Visibility = Visibility.Collapsed;
            }
        }
    }
}