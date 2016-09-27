namespace CommandPattern
{
    public class OpenSwitchCommand : ICommand
    {
        private IReceiver receiver = null;

        public OpenSwitchCommand(IReceiver switchable)
        {
            receiver = switchable;
        }

        public object Execute()
        {
            return receiver.PowerOn();
        }
    }

    public class CloseSwitchCommand : ICommand
    {
        private IReceiver receiver = null;

        public CloseSwitchCommand(IReceiver switchable)
        {
            this.receiver = switchable;
        }

        public object Execute()
        {
            return receiver.PowerOff();
        }
    }
}