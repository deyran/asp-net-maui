using AgendaApp.MVVM.ViewModels;

namespace AgendaApp.MVVM.Views;

public partial class AgendaView : ContentPage
{
	public AgendaView(IAgendaService service)
	{
		InitializeComponent();
 
        BindingContext = new AgendaViewModel(service);
    }
}