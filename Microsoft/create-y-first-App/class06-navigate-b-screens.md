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