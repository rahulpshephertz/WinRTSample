using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace WinStoreApp42SampleApp
{
   public class ZoneListener:com.shephertz.app42.gaming.multiplayer.client.listener.ZoneRequestListener
    {
        TextBlock tblmessage;
        public ZoneListener(TextBlock result)
        {
            tblmessage = result;
        }
        public void onDeleteRoomDone(com.shephertz.app42.gaming.multiplayer.client.events.RoomEvent eventObj)
        {
          
        }

        public void onGetAllRoomsDone(com.shephertz.app42.gaming.multiplayer.client.events.AllRoomsEvent eventObj)
        {
          
        }

        public void onCreateRoomDone(com.shephertz.app42.gaming.multiplayer.client.events.RoomEvent eventObj)
        {
            UIDispatcher.Execute(delegate() { tblmessage.Text = "Create Room Result :" + eventObj.getResult(); });
        }

        public void onGetOnlineUsersDone(com.shephertz.app42.gaming.multiplayer.client.events.AllUsersEvent eventObj)
        {
          
        }

        public void onGetLiveUserInfoDone(com.shephertz.app42.gaming.multiplayer.client.events.LiveUserInfoEvent eventObj)
        {
        }

        public void onSetCustomUserDataDone(com.shephertz.app42.gaming.multiplayer.client.events.LiveUserInfoEvent eventObj)
        {
           
        }

        public void onGetMatchedRoomsDone(com.shephertz.app42.gaming.multiplayer.client.events.MatchedRoomsEvent matchedRoomsEvent)
        {
           
        }

        /*
         public void onInvokeZoneRPCDone(com.shephertz.app42.gaming.multiplayer.client.events.RPCEvent rpcEvent)
         {
             throw new NotImplementedException();
         }


         public void onInvokeZoneRPCDone(com.shephertz.app42.gaming.multiplayer.client.events.RPCEvent rpcEvent)
         {
            // throw new NotImplementedException();
         }*/
    }
}
