using Android.App;
using Android.Runtime;

<<<<<<< HEAD
namespace Projet_MAUI;
=======
namespace People;
>>>>>>> e5d550d (gestion SQLite)

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
