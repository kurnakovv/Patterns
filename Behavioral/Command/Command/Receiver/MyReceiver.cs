using System.IO;

namespace Command.Receiver
{
    // This we implement BL.
    public class MyReceiver
    {
        public string SaveText(string text)
        {
            using (var writer = new StreamWriter("test.txt", false))
            {
                writer.WriteLine(text);
            }

            return "The text is saved";
        }

        public string PrintText()
        {
            // TODO: Logic for print text from file.
            return "The text printed";
        }

        public string Open(string path)
        {
            // TODO: Logic for open file.
            return "The file opened";
        }

        public string Undo()
        {
            // TODO: Logic for returning the previous text 
            return "The act undo";
        }
    }
}
