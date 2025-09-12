namespace designPattern.Behavioural.Mediator
{
    public class ChatUser
    {
        private string _name;

        private List<IChatRoom> _usersChatRooms = new List<IChatRoom>();

        public ChatUser(string name)
        {
            _name = name;
        }

        public void JoinChatRoom(IChatRoom chatRoom)
        {
            chatRoom.AddChatUsers(this);
            _usersChatRooms.Add(chatRoom);
        }


        public void SendMessage(string message, IChatRoom room)
        {
            if (_usersChatRooms.Contains(room))
            {
                Console.WriteLine("Sending Message in ChatRoom....");
                Console.WriteLine("Message sent....");
                Console.WriteLine();
                room.SendMessage(message, this);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("user is not a participant of the mentioned chat room");
            }
        }

        public void ReceiveMessage(string message, ChatUser sender)
        {
            Console.WriteLine($"{_name}, {sender.GetUserName()} has sent a message in the chatRoom.\n Message:{message}");
            Console.WriteLine();
        }

        public string GetUserName()
        {
            return _name;
        }
    }
}