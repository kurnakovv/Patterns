using System.Collections.Generic;

namespace TempleteMethod.Abstract
{
    public abstract class DataMiner
    {
        /// <summary>
        /// Template method.
        /// </summary>
        /// <param name="path"></param>
        public void Mine(string path)
        {
            string file = string.Empty;
            List<string> rawData = new List<string>();
            string data = string.Empty;
            string analyze = string.Empty;

            file = OpenFile(path);
            rawData = ExtractData(file);
            data = ParseData(rawData);
            analyze = AnalyzeData(data);
            SendReport(analyze);
            CloseFile(file);
        }

        // Steps.

        protected abstract string OpenFile(string path);
        protected abstract List<string> ExtractData(string file);
        protected virtual string ParseData(List<string> rowData)
        {
            return "Parse data...";
        }
        protected virtual string AnalyzeData(string data)
        {
            return "Analyze data...";
        }
        protected virtual string SendReport(string analyze)
        {
            return "Mining finish complete: " + analyze;
        }
        protected abstract bool CloseFile(string file);
    }
}
