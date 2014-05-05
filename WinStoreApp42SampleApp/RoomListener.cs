using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace WinStoreApp42SampleApp
{
   public class RoomListener:com.shephertz.app42.gaming.multiplayer.client.listener.RoomRequestListener
    {
       TextBlock tblmessage;
       public RoomListener(TextBlock result)
        {
            tblmessage = result;
        }
        public void onSubscribeRoomDone(com.shephertz.app42.gaming.multiplayer.client.events.RoomEvent eventObj)
        {
           
        }

        public void onUnSubscribeRoomDone(com.shephertz.app42.gaming.multiplayer.client.events.RoomEvent eventObj)
        {
          
        }

        public void onJoinRoomDone(com.shephertz.app42.gaming.multiplayer.client.events.RoomEvent eventObj)
        {
               UIDispatcher.Execute(delegate() {  tblmessage.Text = "Join Room Result :"+eventObj.getResult();});
        }

        public void onLeaveRoomDone(com.shephertz.app42.gaming.multiplayer.client.events.RoomEvent eventObj)
        {
          
        }

        public void onGetLiveRoomInfoDone(com.shephertz.app42.gaming.multiplayer.client.events.LiveRoomInfoEvent eventObj)
        {
            
        }

        public void onSetCustomRoomDataDone(com.shephertz.app42.gaming.multiplayer.client.events.LiveRoomInfoEvent eventObj)
        {

        }

        public void onUpdatePropertyDone(com.shephertz.app42.gaming.multiplayer.client.events.LiveRoomInfoEvent lifeLiveRoomInfoEvent)
        {
          
        }

        public void onLockPropertiesDone(byte result)
        {
           
        }

        public void onUnlockPropertiesDone(byte result)
        {
          
        }

        /*
         public void onInvokeRoomRPCDone(com.shephertz.app42.gaming.multiplayer.client.events.RPCEvent rpcEvent)
         {
             throw new NotImplementedException();
         }


         public void onInvokeRoomRPCDone(com.shephertz.app42.gaming.multiplayer.client.events.RPCEvent rpcEvent)
         {
             //throw new NotImplementedException();
         }*/
    }
}
