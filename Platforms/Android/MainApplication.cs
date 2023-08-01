// Copyright 2023 MED-EL Elektromedizinische Geraete Gesellschaft m.b.H.

using Android.App;
using Android.Runtime;

namespace MauiApp2;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
