# [Implementing navigation in .Net MAUI # passing parameters](https://youtu.be/DuNLR_NJv8U?t=8763)

1. Open the **MonkeysViewModel** class and add the code below:
   
```
[RelayCommand]
async Task GoToDetailsAsync(Monkey monkey)
{
    if (monkey is null)
        return;

    await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true, 
        new Dictionary<string, object>
        {
            {"Monkey",monkey}
        });
}
```

2. Open and edit **MainPage.xaml** as shown in the code below:

```

<ContentPage ... >
    <Grid ...>
        <CollectionView ...>
            <CollectionView.ItemTemplate>
                <DataTemplate ...>
                    <Grid ...>
                        <Frame ...>

                            <Frame.GestureRecognizers>
                                <TapGestureRecognizer Command="{Binding .}"
                                                      CommandParameter="{Binding Source={RelativeSource AncestorType={x:Type viewmodel:MonkeysViewModel}}, Path=GoToDetailsCommand}"/>
                            </Frame.GestureRecognizers>
        ...                            
    </Grid>
</ContentPage>
```

3. Passing the object to a specific page. Open and edit **DetailsPage.xaml.cs** as shown in the code below:

```
namespace MonkeyFinder;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(MonkeyDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
```

4. Open and edit **MonkeyDetailsViewModel.cs** as shown in the code below:

```
namespace MonkeyFinder.ViewModel;

[QueryProperty("Monkey", "Monkey")]
public partial class MonkeyDetailsViewModel : BaseViewModel
{
    public MonkeyDetailsViewModel()
    {        
    }

    [ObservableProperty]
    Monkey monkey;
}
```

5. Now it's time to register the route in the **AppShell.xaml.cs** file.
   
```
namespace MonkeyFinder;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
    }
}
```

6. Open the MauiProgram.cs to add **build.Services** as shown in the code below:
   
```
...
builder.Services.AddSingleton<MonkeyService>();

builder.Services.AddSingleton<MonkeysViewModel>();
builder.Services.AddTransient<MonkeyDetailsViewModel>();

builder.Services.AddSingleton<MainPage>();
builder.Services.AddTransient<DetailsPage>();
...
```
   
7. AAAA