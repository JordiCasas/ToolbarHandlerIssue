// Copyright 2023 MED-EL Elektromedizinische Geraete Gesellschaft m.b.H.

using Foundation;
using Microsoft.Maui.Handlers;
using UIKit;

namespace MauiApp2;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() {

        System.Diagnostics.Debug.WriteLine("IN CREATE MAUI APP iOS");

        ToolbarHandler.Mapper.AppendToMapping("CustomToolbarMapper2", (handler, toolbar) =>
        {
            // Not reached!!
            System.Diagnostics.Debug.WriteLine("IN TOOLBAR HANDLER");
        });

        return MauiProgram.CreateMauiApp();
    }
}
