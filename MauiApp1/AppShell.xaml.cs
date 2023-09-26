namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Configuracion", typeof(Configuracion));
            Routing.RegisterRoute("Admistrador", typeof(Admistrador));
            Routing.RegisterRoute("Alertas", typeof(Alertas));
        }
    }
}