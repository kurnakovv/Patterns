using Command.Command;
using Command.Invoker;
using Command.Receiver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Editor _editor = new Editor();

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MyReceiver myReceiver = new MyReceiver();
            _editor.SetCommand(new SaveCommand(myReceiver, textBox1.Text));
            MessageBox.Show(_editor.Execute());
        }

        private void UndoSaveBtn_Click(object sender, EventArgs e)
        {
            MyReceiver myReceiver = new MyReceiver();
            _editor.SetCommand(new SaveCommand(myReceiver, textBox1.Text));
            MessageBox.Show(_editor.Undo());
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            MyReceiver myReceiver = new MyReceiver();
            _editor.SetCommand(new PrintCommand(myReceiver));
            MessageBox.Show(_editor.Execute());
        }

        private void UndoPrintBtn_Click(object sender, EventArgs e)
        {
            MyReceiver myReceiver = new MyReceiver();
            _editor.SetCommand(new PrintCommand(myReceiver));
            MessageBox.Show(_editor.Undo());
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            MyReceiver myReceiver = new MyReceiver();
            _editor.SetCommand(new OpenCommand(myReceiver));
            MessageBox.Show(_editor.Execute());
        }

        private void UndoOpenBtn_Click(object sender, EventArgs e)
        {
            MyReceiver myReceiver = new MyReceiver();
            _editor.SetCommand(new OpenCommand(myReceiver));
            MessageBox.Show(_editor.Undo());
        }
    }
}
