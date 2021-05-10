using Command.Receiver;

namespace Command.Command
{
    public class PrintCommand : IButtonCommand
    {
        public string Text { get; set; }

        private MyReceiver _receiver;

        public PrintCommand(MyReceiver receiver)
        {
            _receiver = receiver;
        }

        public string Execute()
        {
            return _receiver.PrintText();
        }

        public string Undo()
        {
            return _receiver.Undo();
        }
    }
}
