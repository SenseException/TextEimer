using System;


namespace TextEimer.Clipboard.Container.Type
{
	public interface IType
	{
		/// <summary>
		/// Sets / Returns the name of the key name for the ContextMenuStrip item
		/// </summary>
		string Key {
			get;
			set;
		}
		
		/// <summary>
		/// Returns the value of the Item
		/// </summary>
		object Value {
			get;
		}
		
		/// <summary>
		/// Returns the type of the Item
		/// </summary>
		System.Type ValueType {
			get;
		}
	}
}
