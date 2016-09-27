using System;

namespace CommandPattern
{
    internal class Program
    {
        private static string arg = "on";

        [STAThread]
        public static void Main()
        {
            IReceiver receiver = new Receiver();

            ICommand switchOpen = new OpenSwitchCommand(receiver);
            ICommand switchClose = new CloseSwitchCommand(receiver);

            var invoker = new Invoker(switchClose, switchOpen);

            switch(arg)
            {
                case "on":
                    invoker.Close();
                    break;
                case "off":
                    invoker.Open();
                    break;
                default:
                    break;
            }
        }
    }
}