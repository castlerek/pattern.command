namespace CommandPattern
{
    public interface ICommand
    {
        object Execute();
    }

    public interface IReceiver
    {
        string PowerOn();

        string PowerOff();
    }

    public interface IInvoker
    {
        object Open();

        object Close();
    }
}