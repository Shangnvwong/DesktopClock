﻿using System.Collections.Generic;
using System.Windows;
using DesktopClock.Properties;

namespace DesktopClock;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    // https://www.materialui.co/colors
    public static IReadOnlyList<Theme> Themes { get; } = new[]
    {
        new Theme("Light", "#F5F5F5", "#212121"),
        new Theme("Dark", "#212121", "#F5F5F5"),
        new Theme("Red", "#D50000", "#FF8A80"),
        new Theme("Pink", "#C51162", "#FF80AB"),
        new Theme("Purple", "#AA00FF", "#EA80FC"),
        new Theme("Blue", "#2962FF", "#82B1FF"),
        new Theme("Cyan", "#00B8D4", "#84FFFF"),
        new Theme("Green", "#00C853", "#B9F6CA"),
        new Theme("Amber", "#FFAB00", "#FFE57F"),
        new Theme("Orange", "#FF6D00", "#FFD180"),
    };

    private void Application_Exit(object sender, ExitEventArgs e)
    {
        Settings.Default.SaveIfNotModifiedExternally();
    }
}