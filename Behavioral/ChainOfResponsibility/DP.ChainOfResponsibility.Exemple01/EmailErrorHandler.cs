namespace DP.ChainOfResponsibility.Exemple01;

public class EmailErrorHandler : IReceiver
{
    private IReceiver _nextReceiver;

    public EmailErrorHandler(IReceiver nextReceiver)
    {
        _nextReceiver = nextReceiver;
    }
    public bool HandleMessage(Message message)
    {
        if (message.Text.Contains("Email"))
        {
            Console.WriteLine($"EmailErrorHandler processed {message.Priority} priority issue {message.Text}");
            return true;
        }

        if(_nextReceiver != null)
            _nextReceiver.HandleMessage(message);

        return false;
    }
}