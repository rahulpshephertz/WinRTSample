using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace WinStoreApp42SampleApp
{
    public class NotifyListener:com.shephertz.app42.gaming.multiplayer.client.listener.NotifyListener
    {
        TextBlock tblmessage;
        public NotifyListener(TextBlock result)
        {
            tblmessage = result;
        }
        public void onRoomCreated(com.shephertz.app42.gaming.multiplayer.client.events.RoomData eventObj)
        {
         
        }

        public void onRoomDestroyed(com.shephertz.app42.gaming.multiplayer.client.events.RoomData eventObj)
        {
           
        }

        public void onUserLeftRoom(com.shephertz.app42.gaming.multiplayer.client.events.RoomData eventObj, string username)
        {
         
        }

        public void onUserJoinedRoom(com.shephertz.app42.gaming.multiplayer.client.events.RoomData eventObj, string username)
        {
          
        }

        public void onUserLeftLobby(com.shephertz.app42.gaming.multiplayer.client.events.LobbyData eventObj, string username)
        {
         
        }

        public void onUserJoinedLobby(com.shephertz.app42.gaming.multiplayer.client.events.LobbyData eventObj, string username)
        {
           
        }

        public void onChatReceived(com.shephertz.app42.gaming.multiplayer.client.events.ChatEvent eventObj)
        {
         
        }

        public void onUpdatePeersReceived(com.shephertz.app42.gaming.multiplayer.client.events.UpdateEvent eventObj)
        {

        }

        public void onUserChangeRoomProperty(com.shephertz.app42.gaming.multiplayer.client.events.RoomData roomData, string sender, Dictionary<string, object> properties, Dictionary<string, string> lockedPropertiesTable)
        {
         
        }

        public void onPrivateChatReceived(string sender, string message)
        {
          
        }

        public void onMoveCompleted(com.shephertz.app42.gaming.multiplayer.client.events.MoveEvent moveEvent)
        {
          
        }

        public void onUserPaused(string locid, bool isLobby, string username)
        {
           
        }

        public void onUserResumed(string locid, bool isLobby, string username)
        {
          
        }

        public void onGameStarted(string sender, string roomId, string nextTurn)
        {
           
        }

        public void onGameStopped(string sender, string roomId)
        {
            
        }

        public void onPrivateUpdateReceived(string sender, byte[] update, bool fromUdp)
        {
            UIDispatcher.Execute(delegate() { tblmessage.Text = Encoding.UTF8.GetString(update, 0, update.Length);});
        }
    }
}
