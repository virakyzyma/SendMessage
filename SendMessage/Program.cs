namespace SendMessage
{
    internal class Program
    {
        static void Main()
        {

            Message message = new Message(SendMessage);
            message.SendMessage("Message for you", "Hello world");
        }
        public static void SendMessage(string title, string message)
        {
            Console.WriteLine($"Message:\nTitle: {title}\nText: {message}");
        }
        public class Message
        {
            public delegate void MessageHandler(string title, string message);
            public MessageHandler messageHandler;
            public Message(MessageHandler messageHandler)
            {
                this.messageHandler = messageHandler;
            }
            public void SendMessage(string title, string message)
            {
                messageHandler?.Invoke(title, message);
            }
        }
    }
}
