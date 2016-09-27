using System;
using Xunit;

namespace CommandPattern.Tests
{
    public class InvokerTests
    {
        private readonly IReceiver receiver = null;
        private readonly IInvoker invoker = null;

        public InvokerTests()
        {
            receiver = new Receiver();

            var commands = PrepareCommands();
            invoker = new Invoker(commands.Item1, commands.Item2);
        }

        [Fact]
        public void TestPowerOn()
        {
            // arrange
            const string awaitedResult = "Is on";

            // act
            var fetchedResult = invoker.Open();

            // assert
            Assert.Equal(awaitedResult, fetchedResult);
        }

        [Fact]
        public void TestPowerOff()
        {
            // arrange
            const string awaitedResult = "Is off";

            // act
            var fetchedResult = invoker.Close();

            // assert
            Assert.Equal(awaitedResult, fetchedResult);
        }

        private Tuple<ICommand, ICommand> PrepareCommands()
        {
            return new Tuple<ICommand, ICommand>(
                new OpenSwitchCommand(receiver),
                new CloseSwitchCommand(receiver)
            );
        }
    }
}