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
                                <TapGestureRecognizer 
                                        Command="{Binding Source={RelativeSource AncestorType={x:Type viewmodel:MonkeysViewModel}}, Path=GoToDetailsCommand}"
                                        CommandParameter="{Binding .}"/>
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

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
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
   
# [Create DetailsPage.xaml UI](https://youtu.be/DuNLR_NJv8U?t=9868)

## DetailsPage.xaml
  
1. Defining our DataType by defining the view model namespace and also setting the title:
   
```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MonkeyFinder.DetailsPage"
                          
             xmlns:viewmodel="clr-namespace:MonkeyFinder.ViewModel"
             x:DataType="viewmodel:MonkeyDetailsViewModel"            
             Title="{Binding Monkey.Name}">

    <Label Text="{Binding Monkey.Name}"
           FontSize="25" />

</ContentPage>
```

2. `ScrollView`, `VerticalStackLayout` and `Grid` to layout
   
```
<ScrollView>
    <VerticalStackLayout>
        <Grid ColumnDefinitions="*,Auto,*"
                RowDefinitions="160, Auto">
                ....
        </Grid>
    </VerticalStackLayout>
</ScrollView>
```

3. Putting the monkey picture in the middle of the screen

```
<ScrollView>
    <VerticalStackLayout>
        <Grid ColumnDefinitions="*,Auto,*"
                RowDefinitions="160, Auto">

            <BoxView
                BackgroundColor="{StaticResource Primary}"
                Grid.ColumnSpan="3"
                HeightRequest="160" 
                HorizontalOptions="FillAndExpand"/>

            <Frame Grid.RowSpan="2"
                    Grid.Column="1"
                    HeightRequest="160"
                    WidthRequest="160"
                    CornerRadius="80"
                    HorizontalOptions="Center"
                    IsClippedToBounds="True"
                    Padding="0"
                    Margin="0,80,0,0">

                <Image Aspect="AspectFill"
                        HeightRequest="160"
                        WidthRequest="160"
                        HorizontalOptions="Center"
                        VerticalOptions="Center"
                        Source="{Binding Monkey.Image}" />
            </Frame>
            
        </Grid>
    </VerticalStackLayout>
</ScrollView>
```

4. Now we're gonna to put some information

```
...
<ScrollView>
    <VerticalStackLayout>
        <Grid ColumnDefinitions="*,Auto,*"
                RowDefinitions="160, Auto">
        ...
        </Grid>   

        <VerticalStackLayout Padding="10" Spacing="10" HorizontalOptions="Center">
            <Label Text="{Binding Monkey.Details}" 
                    Style="{StaticResource MediumLabel}" />
            <Label Text="{Binding Monkey.Location, StringFormat='Location: {0}'}" 
                    Style="{StaticResource SmallLabel}"/>
            <Label Text="{Binding Monkey.Population, StringFormat='Population: {0}'}" 
                    Style="{StaticResource SmallLabel}"/>
        </VerticalStackLayout>

    </VerticalStackLayout>
</ScrollView>
...
```

5. AAAAAAA