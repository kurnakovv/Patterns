using Command.Receiver;

namespace Command.Command
{
    public class OpenCommand : IButtonCommand
    {
        public string Text { get; set; }
        private MyReceiver _receiver;
        private readonly string _pathToFile =
            "D:\\C#\\Pattern\\MyImplementatedPatterns\\Command\\Command\bin\\Debug";

        public OpenCommand(MyReceiver receiver)
        {
            _receiver = receiver;
        }

        public string Execute()
        {
            return _receiver.Open(_pathToFile);
        }

        public string Undo()
        {
            return _receiver.Undo();
        }
    }
}
