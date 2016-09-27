namespace CommandPattern
{
    public class Invoker : IInvoker
    {
        private ICommand openedCommand = null;
        private ICommand closedCommand = null;

        public Invoker(ICommand openedCommand, ICommand closedCommand)
        {
            this.openedCommand = openedCommand;
            this.closedCommand = closedCommand;
        }

        public object Open()
        {
            return openedCommand.Execute();
        }

        public object Close()
        {
            return closedCommand.Execute();
        }
    }
}