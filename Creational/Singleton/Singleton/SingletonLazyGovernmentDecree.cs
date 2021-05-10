using System;
using System.IO;

namespace Singleton
{
    public class SingletonLazyGovernmentDecree
    {
        public string GovernmentDecree { get; private set; }
        public static SingletonLazyGovernmentDecree SingleInstance => _singleInstance.Value;

        private SingletonLazyGovernmentDecree()
        {
            ReadFileGovernmentDecree();
        }

        private static readonly Lazy<SingletonLazyGovernmentDecree> _singleInstance =
            new Lazy<SingletonLazyGovernmentDecree>(() => new SingletonLazyGovernmentDecree());

        private const string _filePath = "GovernmentDecree.txt";

        public void MakeGovernmentDecree(string text)
        {
            if (text != null)
            {
                GovernmentDecree += $"{text} {DateTime.Now}\r\n";
                SaveGovernmentDecree();
            }
        }

        private void SaveGovernmentDecree()
        {
            using (StreamWriter streamWriter = new StreamWriter(_filePath))
            {
                streamWriter.WriteLine(GovernmentDecree);
            }
        }

        public void ReadFileGovernmentDecree()
        {
            if (File.Exists(_filePath))
            {
                using (StreamReader streamReader = new StreamReader(_filePath))
                {
                    GovernmentDecree = streamReader.ReadToEnd();
                }
            }
            else
            {
                GovernmentDecree = string.Empty;
            }
        }
    }
}
