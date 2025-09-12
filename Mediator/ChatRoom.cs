
namespace designPattern.Behavioural.Mediator
{
    public class ChatRoom: IChatRoom
    {
        
        private List<ChatUser> _roomParticipants = new List<ChatUser>();

        public void AddChatUsers(ChatUser user) {
            _roomParticipants.Add(user);
        }
   
        public void SendMessage(string message, ChatUser user)
        {
            foreach (var participant in _roomParticipants)
            {
                if (!participant.Equals(user))
                {
                    participant.ReceiveMessage(message, user);
                
                }   
            }
        }
    }
}