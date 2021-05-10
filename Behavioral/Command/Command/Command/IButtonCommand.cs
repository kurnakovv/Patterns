namespace Command.Command
{
    public interface IButtonCommand
    {
        string Text { get; set; }
        string Execute();
        string Undo();
    }
}
