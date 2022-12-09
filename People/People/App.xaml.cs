<<<<<<< HEAD
﻿namespace Projet_MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
=======
﻿public partial class App : Application
{
    public static PersonRepository PersonRepo { get; private set; }

    public App(PersonRepository repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        PersonRepo = repo;
    }
}
>>>>>>> e5d550d (gestion SQLite)
