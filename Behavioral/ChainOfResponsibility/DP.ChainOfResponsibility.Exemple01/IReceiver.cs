namespace DP.ChainOfResponsibility.Exemple01;

public interface IReceiver
{
    bool HandleMessage(Message message);
}