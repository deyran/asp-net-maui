namespace AdventureWorks.Views;

public partial class UserListView : ContentPage
{
	public UserListView()
	{
		InitializeComponent();
	}

    private async void NavigateToDetail_Clicked(System.Object sender, System.EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(Views.UserDetailView));
    }
}