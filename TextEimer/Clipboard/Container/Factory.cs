using System;
using TypeContainer = TextEimer.Clipboard.Container.Type;
using Clip = System.Windows.Forms.Clipboard;

namespace TextEimer.Clipboard.Container
{
	/// <summary>
	/// Creates a type container for a new clipboard value
	/// </summary>
	public class Factory
	{
		public Factory()
		{
		}
		
		/// <summary>
		/// Creates a type container with a clipboard value
		/// </summary>
		/// <returns></returns>
		public static TypeContainer.IType CreateTypeContainer()
		{
			TypeContainer.IType typeContainer = null;
			
			if (Clip.ContainsText()) {
				typeContainer = new TypeContainer.String(Clip.GetText());
			}
			
			return typeContainer;
		}
	}
}
