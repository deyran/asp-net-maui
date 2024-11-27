namespace AdventureWorks
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.UserDetailView), typeof(Views.UserDetailView));
        }
    }
}