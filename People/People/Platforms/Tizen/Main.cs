using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

<<<<<<< HEAD
namespace Projet_MAUI;
=======
namespace People;
>>>>>>> e5d550d (gestion SQLite)

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
