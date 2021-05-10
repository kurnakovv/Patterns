using Command.Command;
using System.Collections.Generic;

namespace Command.Invoker
{
    public class Editor
    {
        private IButtonCommand _buttonCommand;
        private Stack<IButtonCommand> buttonCommands = new Stack<IButtonCommand>();

        public void SetCommand(IButtonCommand buttonCommand)
        {
            _buttonCommand = buttonCommand;
        }

        public string Execute()
        {
            if (_buttonCommand != null)
            {
                buttonCommands.Push(_buttonCommand);
                return _buttonCommand.Execute();
            }

            throw new System.Exception();
        }

        public string Undo()
        {
            if (_buttonCommand != null)
            {
                buttonCommands.Pop();
                return _buttonCommand.Undo();
            }

            throw new System.Exception();
        }
    }
}
