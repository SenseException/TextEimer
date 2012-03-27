using System;
using System.Security.Cryptography;

namespace TextEimer.Clipboard.Container.Type
{
	public class String : IType
	{
		private string key;
		private object value;
		private System.Type type;
		
		public String(string value)
		{
			this.value = (object) value;
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
		
		public System.Type ValueType
		{
			get
			{
				return this.type;
			}
		}
	}
}
