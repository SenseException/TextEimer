using System;
using System.IO;

using TextEimer.Config;

namespace TextEimer.Log
{
	/// <summary>
	/// Writing Log Entrys
	/// </summary>
	public class Writer
	{
		private Settings settings;
		private string logFilePath;
		
		public Writer(Settings settings)
		{
			this.settings = settings;
            this.logFilePath = Path.GetTempPath() + "TextEimer.log";
		}
		
		public void Write(string message, Exception e = null)
		{
            if (this.settings.LoggingOn)
            {
                StreamWriter log;
                string filePath = this.FilePath;

                if (!File.Exists(filePath))
                {
                    log = new StreamWriter(filePath);
                }
                else
                {
                    log = File.AppendText(filePath);
                }

                if ("" == message && null != e)
                {
                    message = e.Message;
                }

                log.Write(DateTime.Now.ToString());
                log.WriteLine(message);

                if (null != e)
                {
                    log.WriteLine();
                    log.WriteLine(e.StackTrace);
                }
                log.WriteLine("###########################");

                log.Flush();
                log.Close();
            }
		}
		
		public string FilePath
		{
			get
			{
				return this.logFilePath;
			}
			set
			{
				this.logFilePath = value;
			}
		}
	}
}
