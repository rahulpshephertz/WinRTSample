using com.shephertz.app42.gaming.multiplayer.client;
using Platformer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WinStoreApp42SampleApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
      //  ServiceAPI sp;
        public MainPage()
        {
            UIDispatcher.Initialize();
            this.InitializeComponent();
            WarpClient.initialize(GlobalContext.API_KEY, GlobalContext.SECRET_KEY);
            WarpClient.GetInstance().AddConnectionRequestListener(new ConnectionListen(tblMessage));
            WarpClient.GetInstance().AddNotificationListener(new NotifyListener(tblMessage));
            WarpClient.GetInstance().AddZoneRequestListener(new ZoneListener(tblMessage));
            WarpClient.GetInstance().AddRoomRequestListener(new RoomListener(tblMessage));
            WarpClient.GetInstance().AddUpdateRequestListener(new UpdateListener(tblMessage));
        }

        private void App42Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int tag = Convert.ToInt32((sender as Button).Tag.ToString());
                switch (tag)
                {
                    case 0:
                        tblMessage.Text = "Connecting..";
                        WarpClient.GetInstance().Connect("rahul");
                        //user.CreateUser("app42test", "app42test", "app42test@gmail.com", new callback(tblMessage));
                        break;
                    case 1: tblMessage.Text = "Creating..";
                        WarpClient.GetInstance().CreateRoom("rahul", "rahul", 2, null);
                        //user.UpdateUser("app42test", "app42test123@gmail.com", new callback(tblMessage));
                        break;
                    case 2: tblMessage.Text = "Joining..";
                        WarpClient.GetInstance().JoinRoomInRange(0, 1, true);
                        // user.DeleteUser("app42test", new callback(tblMessage));
                        break;
                    case 3: tblMessage.Text = "Sending..";
                        WarpClient.GetInstance().sendPrivateUpdate("rahul", Encoding.UTF8.GetBytes("Private update"));
                        break;
                    case 4: tblMessage.Text = "Disconnecting..";
                        WarpClient.GetInstance().Disconnect();
                        break;
                }
            }
            catch (Exception exc)
            {
                Debug.WriteLine("Exception "+exc.Message);
            }
            
        }
    }
  
}
