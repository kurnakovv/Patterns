using Command.Receiver;

namespace Command.Command
{
    public class SaveCommand : IButtonCommand
    {
        public string Text { get; set; }
        private MyReceiver _receiver;

        public SaveCommand(MyReceiver receiver, string text)
        {
            _receiver = receiver;
            Text = text;
        }

        public string Execute()
        {
            return _receiver.SaveText(Text);
        }

        public string Undo()
        {
            return _receiver.Undo();
        }
    }
}
