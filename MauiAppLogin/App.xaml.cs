
namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            string? usuario_logado = null;



            //MainPage = new AppShell();
            MainPage = new Login();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 650;

            return window;
        }

    } // Fecha classe
} // Fecha namespace
