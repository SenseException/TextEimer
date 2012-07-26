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
		private string logFilePath = null;
		
		public Writer(Settings settings)
		{
			this.settings = settings;
		}
		
		public void Write(string message, Exception e = null)
		{
			// TODO use exception object for logs
			// TODO add settings check of LoggingOn
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
			
			log.Write(DateTime.Now);
			log.WriteLine(message);
			
			log.Close();
		}
		
		public string FilePath
		{
			get
			{
				if (null == this.logFilePath)
				{
					this.logFilePath = Path.GetTempPath();
				}
				
				return this.logFilePath;
			}
			set
			{
				this.logFilePath = value;
			}
		}
	}
}
