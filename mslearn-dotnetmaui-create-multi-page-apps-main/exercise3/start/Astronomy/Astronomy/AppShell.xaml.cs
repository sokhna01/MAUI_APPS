using Astronomy.Pages;
using Microsoft.Maui.Controls;

namespace Astronomy;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("astronomicalbodydetails", typeof(AstronomicalBodyPage));

    }
}
