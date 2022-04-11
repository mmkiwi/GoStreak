// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System;
using GLib;
using Uno.UI.Runtime.Skia;

namespace GoStreak.Skia.Gtk
{
	class Program
	{
		static void Main(string[] args)
		{
			ExceptionManager.UnhandledException += delegate (UnhandledExceptionArgs expArgs)
			{
				Console.WriteLine("GLIB UNHANDLED EXCEPTION" + expArgs.ExceptionObject.ToString());
				expArgs.ExitApplication = true;
			};

			var host = new GtkHost(() => new App(), args);

			host.Run();
		}
	}
}
