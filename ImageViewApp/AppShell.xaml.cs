using ImageViewApp.Views;

namespace ImageViewPage
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("FunFactsPage", typeof(FunFactsPageView));
        }
    }
}