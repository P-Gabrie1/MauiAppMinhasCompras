using MauiAppMinhasCompras.Helpers;

namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        static SQLIteDataBaseHelper _db;

        public static SQLIteDataBaseHelper Db 
        {
            get 
            {
                if(_db == null) 
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "banco_sqlite_compras.db3");

                   _db = new SQLIteDataBaseHelper(path);
                }

                return _db;
            }
        }
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Views.ListaProduto());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var Window = base.CreateWindow(activationState);
            Window.Width = 400;
            Window.Height = 650;
            return Window;
        }

    }
}
