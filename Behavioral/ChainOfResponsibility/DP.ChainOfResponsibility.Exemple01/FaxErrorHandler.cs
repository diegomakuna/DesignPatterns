namespace DP.ChainOfResponsibility.Exemple01;

public class FaxErrorHandler : IReceiver
{
    private IReceiver _nextReceiver;

    public FaxErrorHandler(IReceiver nextReceiver)
    {
        _nextReceiver = nextReceiver;
    }

    public bool HandleMessage(Message message)
    {
        if (message.Text.Contains("Fax"))
        {
            Console.WriteLine($"FaxErrorHandler processed {message.Priority}, priority issue {message.Text}");
            return true;
        }
        else
        {
            if (_nextReceiver != null)
                _nextReceiver.HandleMessage(message);
     
        }
        return false;
    }
}