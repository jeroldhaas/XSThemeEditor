using System;
using MonoDevelop.Components.Commands;

namespace XSThemeEditor
{
	class EditThemeHandler : CommandHandler
	{
		protected override void Run()
		{
			MonoDevelop.Core.Text = "foo";
		}
		
		protected override void Update(CommandInfo info)
		{
		}
	}
	
	public enum EditTheme
	{
		EditTheme,
	}
}

