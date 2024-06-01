namespace AgendaApp.MVVM.ViewModels;

public partial class AgendaViewModel : ContentPage
{
	public AgendaViewModel()
	{
		InitializeComponent();
	}

	public AgendaViewModel(IAgendaService contatoRepository)
	{
	}
}