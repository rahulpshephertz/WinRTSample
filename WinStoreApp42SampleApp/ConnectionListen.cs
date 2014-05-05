using com.shephertz.app42.gaming.multiplayer.client.command;
using com.shephertz.app42.gaming.multiplayer.client.events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace WinStoreApp42SampleApp
{
    public class ConnectionListen : com.shephertz.app42.gaming.multiplayer.client.listener.ConnectionRequestListener
    {
        private MainPage _page;
        TextBlock tblmessage;
        private int _recoverCounts;
        public ConnectionListen(TextBlock result)
        {
            tblmessage = result;
        }

        public void onConnectDone(ConnectEvent eventObj)
        {
            UIDispatcher.Execute(delegate() { tblmessage.Text = "Connect Done: " + eventObj.getResult(); });
            switch (eventObj.getResult())
            {
                case WarpResponseResultCode.SUCCESS:
                    // _page.showResult("connection success");
                    break;
                case WarpResponseResultCode.CONNECTION_ERROR_RECOVERABLE:
                    // _page.showResult("connection recoverable " + eventObj.getResult());
                    // Deployment.Current.Dispatcher.BeginInvoke(delegate() {   RecoverConnection(); });
                    break;
                case WarpResponseResultCode.SUCCESS_RECOVERED:
                    //_page.showResult("connection success recovered " + eventObj.getResult());
                    // Deployment.Current.Dispatcher.BeginInvoke(delegate() { ConnectionRecovered(); });
                    break;
                default:

                    break;
            }
        }
        /*
        public void RecoverConnection()
        {
            if (_recoverCounts == 0)
            {
                timer = new DispatcherTimer();
                timer.Tick += timer_Tick;
                timer.Interval = new TimeSpan(0, 0, 0, 10);
                timer.Start();
            }

        }
        public void ConnectionRecovered()
        {
            timer.Stop();
            _recoverCounts = 0;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            _recoverCounts++;
            if (_recoverCounts <= 6)
            {
                WarpClient.GetInstance().RecoverConnection();
            }
            else
            {
                (sender as DispatcherTimer).Stop();
                _page.showResult("connection failed");
            }
        }*/
        public void onDisconnectDone(ConnectEvent eventObj)
        {
            UIDispatcher.Execute(delegate()
            {
                tblmessage.Text = "Disconnect Done: " + eventObj.getResult();
                if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
                {

                }
                else
                {

                }

            });

        }


        public void onInitUDPDone(byte resultCode)
        {
            if (resultCode == WarpResponseResultCode.SUCCESS)
            {

            }
            else
            {

            }
        }
    }
}
