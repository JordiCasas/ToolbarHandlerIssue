// Copyright 2023 MED-EL Elektromedizinische Geraete Gesellschaft m.b.H.

namespace MauiApp2;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
