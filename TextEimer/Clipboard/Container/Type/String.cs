using System;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using Clip = System.Windows.Forms.Clipboard;

namespace TextEimer.Clipboard.Container.Type
{
	public class String : IType
	{
		private string key;
		private object value;
        private string menuValue;
		private System.Type type;
		
		public String(string value)
		{
			this.value = (object) value;
            this.MenuValue = value;
			this.Key = value;
			this.type = value.GetType();
		}
		
		public string Key
		{
			get
			{
				return this.key;
			}
			set
			{
				MD5CryptoServiceProvider checksum = new MD5CryptoServiceProvider();
	            Byte[] byteValue = System.Text.Encoding.UTF8.GetBytes(value);
	            byteValue = checksum.ComputeHash(byteValue);
	            checksum.Clear();
	
	            System.Text.StringBuilder s = new System.Text.StringBuilder();
	            foreach (Byte b in byteValue)
	            {
	                s.Append(b.ToString("x2").ToLower());
	            }
	            this.key = s.ToString();
			}
		}
		
		public object Value
		{
			get
			{
				return this.value;
			}
		}

        public string MenuValue
        {
            get
            {
                return this.menuValue;
            }
            set
            {
                value = Regex.Replace(value, "[\n\r\t]+", "", RegexOptions.None);
                value = Regex.Replace(value, "[ ]{2,}", " ", RegexOptions.None);
                
                if (value.Length > 50)
                {
                    value = value.Remove(50);
                }
                this.menuValue = value;
            }
        }
		
		public System.Type ValueType
		{
			get
			{
				return this.type;
			}
		}

        public void AddValueToClipboard()
        {
            Clip.SetText((string) this.value);
        }
	}
}
