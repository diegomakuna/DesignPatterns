namespace DP.ChainOfResponsibility.Exemple01;

public class Message
{
    public string Text;
    public MessagePriority Priority;

    public Message(string msg, MessagePriority priority)
    {
        Text = msg;
        Priority = priority;
    }
}