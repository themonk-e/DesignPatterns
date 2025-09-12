    namespace designPattern.Behavioural.Mediator
    {
        public interface IChatRoom
        {
          public void AddChatUsers(ChatUser user);


        public void SendMessage(string message,ChatUser user);
        }
    }