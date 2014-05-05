using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace WinStoreApp42SampleApp
{
    public class UpdateListener : com.shephertz.app42.gaming.multiplayer.client.listener.UpdateRequestListener
    {
        TextBlock tblmessage;
        public UpdateListener(TextBlock result)
        {
            tblmessage = result;
        }
        public void onSendUpdateDone(byte result)
        {
            UIDispatcher.Execute(delegate() { tblmessage.Text = "on Send Update Done: " + result; });
        }

        public void onSendPrivateUpdateDone(byte result)
        {
            UIDispatcher.Execute(delegate() { tblmessage.Text = "on Send Private Update Done: " + result; });
        }
    }
}
