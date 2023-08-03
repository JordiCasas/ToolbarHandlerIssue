// Copyright 2023 MED-EL Elektromedizinische Geraete Gesellschaft m.b.H.

using Android.App;
using Android.Runtime;
using Microsoft.Maui.Handlers;

namespace MauiApp2;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() {

        ToolbarHandler.Mapper.AppendToMapping("CustomToolbarMapper", (handler, toolbar) =>
        {
            var materialToolbar = handler.PlatformView;
            materialToolbar.ContentInsetStartWithNavigation = 0;
            materialToolbar.TitleCentered = true;
        });

        return MauiProgram.CreateMauiApp();
    }
}
