# [Navigate Between Screens [6-18]](https://youtu.be/1FI3fAe1bBA?si=EgCgLv9-DcDaEnsm)

## [Adding new pages](https://youtu.be/1FI3fAe1bBA?t=71)

1. In the root directory, add new folder called **Views**
2. Inside the Views folder, add new item (.NET MAUI Content pages) called *UserDetailView.xaml*
3. Open the *UserDetailView.xaml* page, edit it as shown in the code below:

```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="AdventureWorks.Views.UserDetailView"
             Title="User Information">
        
</ContentPage>
```

4. Open the *MainPage.xaml* page, cut the Grid content and paste into the *UserDetailView.xaml* page.
5. In the *MainPage.xaml* page, type the following code:

```
<Label  Text="{StaticResource ApplicationTitle}"
        FontSize="Large"
        VerticalOptions="Center"
        HorizontalOptions="Center" />
```

## [Navigating between pages | Using TabBar](https://youtu.be/1FI3fAe1bBA?t=242)

1. Open AppShell.xaml file and create XML namespace as shown in the code below:

```
<?xml version="1.0" encoding="UTF-8" ?>
<Shell
    ...
    xmlns:views="clr-namespace:AdventureWorks.Views"
    ...>

    <ShellContent
        Title="Home"
        ContentTemplate="{DataTemplate local:MainPage}"
        Route="MainPage" />

</Shell>
```

2. Add TabBar, this element allows you have more than one ShellContent:

```
<?xml version="1.0" encoding="UTF-8" ?>
<Shell ...>
    <TabBar>
        <ShellContent
            Title="Home"
            ContentTemplate="{DataTemplate local:MainPage}"
            Route="MainPage" />

        <ShellContent
            Title="User"
            ContentTemplate="{DataTemplate views:UserDetailView}"
            Route="UserDetailView" />
    </TabBar>
</Shell>
```

## [Add few more pages](https://youtu.be/1FI3fAe1bBA?t=532)

## [Add more shell contents](https://youtu.be/1FI3fAe1bBA?t=572)

## [Drop-down menus](https://youtu.be/1FI3fAe1bBA?t=647)

```
...

<Tab Title="Maintenance">
        <ShellContent
        Title="Colors"
        ContentTemplate="{DataTemplate views:ColorListView}"
        Route="ColorListView" />

        <ShellContent
        Title="Phones types"
        ContentTemplate="{DataTemplate views:PhoneTypesListView}"
        Route="PhoneTypesListView" />
</Tab>

<ShellContent
        Title="Login"
        ContentTemplate="{DataTemplate views:LoginView}"
        Route="LoginView" />
...
```

## [Navigate using click event and register Route](https://youtu.be/1FI3fAe1bBA?t=781)

1. Create another view page called UserListView.xaml in the View folder. Edit the UserListView.xaml as shown in the code below:

```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="AdventureWorks.Views.UserListView"
             Title="User List">

    <VerticalStackLayout VerticalOptions="Center"
                         HorizontalOptions="Center"
                         Spacing="10">
        <Label Text="User List"
               FontSize="Header"
               HorizontalOptions="Center" />
        <Button Text="Navigate to detail"
                Clicked="NavigateToDetail_Clicked" />
    </VerticalStackLayout>
    
</ContentPage>
```

2. Open the UserListView.xaml.cs file, edit the NavigateToDetail_Clicked method as shown in the code below:

```
private async void NavigateToDetail_Clicked(System.Object sender, System.EventArgs e)
{
    await Shell.Current.GoToAsync(nameof(Views.UserDetailView));
}
```

3. Now open the AppShell.xaml file in the User ShellContent edit it as shown in the code below:

```
<ShellContent
    Title="User"
    ContentTemplate="{DataTemplate views:UserListView}"
    Route="UserListView" />
```

4. Open the AppShell.xaml and register the route as shown in the code below:

```
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
```