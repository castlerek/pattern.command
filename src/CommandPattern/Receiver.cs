namespace CommandPattern
{
    public class Receiver : IReceiver
    {
        public string PowerOn()
        {
            return "Is on";
        }

        public string PowerOff()
        {
            return "Is off";
        }
    }
}