using AgendaApp.MVVM.Views;

namespace AgendaApp
{
    public partial class App : Application
    {
        public App(IAgendaService agendaService)
        {
            InitializeComponent();           
                        
            MainPage = new NavigationPage(new AgendaView(agendaService));
        }
    }
}
