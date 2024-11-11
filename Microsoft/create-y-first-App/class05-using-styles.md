# [Use Styles to Improve the UI (5 of 18) | Building Apps with XAML and .NET MAUI](https://youtu.be/rHflpkCZeF8?si=RKVjBd9Sxe2MH54j)

## Adding styles in a single page

```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="AdventureWorks.MainPage"
             Title="Home">

    <ContentPage.Resources>
        <Style TargetType="Grid">
            <Setter Property="ColumnSpacing"    Value="10" />
            <Setter Property="RowSpacing"       Value="10" />
            <Setter Property="Margin"           Value="10" />
            <Setter Property="Padding"          Value="10" />
        </Style>

        <Style TargetType="Label">
            <Setter Property="VerticalTextAlignment"
                    Value="Center" />
        </Style>

        <Style TargetType="HorizontalStackLayout">
            <Setter Property="Spacing"
                    Value="5" />
        </Style>
    </ContentPage.Resources>
    
    <Grid ...>
        ...
    </Grid>

</ContentPage>
```

*The <ContentPage.Resources> element is used to define resources that can be reused within the content page. In this example, it contains a Style for Grid elements, setting properties like ColumnSpacing, RowSpacing, Margin, and Padding. This helps maintain consistency and avoid repetitive code by centralizing style definitions.*

## [Adding styles to the entire application](https://youtu.be/rHflpkCZeF8?t=311)

Open *App.xaml* file, cut the content of *<ContentPage.Resources>* element and past inside the *<ResourceDictionary>* element as show in the code below:

```
<?xml version = "1.0" encoding = "UTF-8" ?>
<Application ...>
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="Resources/Styles/Colors.xaml" />
                <ResourceDictionary Source="Resources/Styles/Styles.xaml" />
            </ResourceDictionary.MergedDictionaries>

            <!--STYLE CONTENT-->
            <Style TargetType="Grid">
                <Setter Property="ColumnSpacing"    Value="10" />
                <Setter Property="RowSpacing"       Value="10" />
                <Setter Property="Margin"           Value="10" />
                <Setter Property="Padding"          Value="10" />
            </Style>

            <Style TargetType="Label">
                <Setter Property="VerticalTextAlignment"    Value="Center" />
                <Setter Property="VerticalOptions"          Value="Center" />
                <Setter Property="HorizontalOptions"        Value="End" />
            </Style>

            <Style TargetType="HorizontalStackLayout">
                <Setter Property="Spacing" Value="5" />
            </Style>

            <Style TargetType="Button">
                <Setter Property="WidthRequest"     Value="70" />
                <Setter Property="HeightRequest"    Value="40" />
                <Setter Property="BackgroundColor"  Value="Blue"/>
                <Setter Property="TextColor"        Value="White" />
            </Style>

        </ResourceDictionary>
    </Application.Resources>
</Application>
```

1. *<ResourceDictionary> - Is a repository for resources that are used by a .Net Maui. These resources are: styles, control templates, data templates, converters and colors*
   
2. *To override the global style for a specific element on a specific page, the only thing to do is write the style inside the <ContentPage.Resources> of the page.*
   
3. *This procedure affects all elements on the page.*

## [x:Key="..." and StaticResource](https://youtu.be/rHflpkCZeF8?t=485)

1. In App.xaml

```
<?xml version = "1.0" encoding = "UTF-8" ?>
<Application ...>
    <Application.Resources>
        <ResourceDictionary>
            
            ...

            <!--STYLE CONTENT => x:Key="..."-->
            <Style TargetType="Grid" x:Key="Grid.Page">
                <Setter Property="ColumnSpacing"    Value="10" />
                
                ...

            </Style>

            ...

        </ResourceDictionary>
    </Application.Resources>
</Application>
```

2. In MainPage.xaml

```
...

<Grid RowDefinitions="Auto,Auto,Auto,Auto,Auto,Auto,Auto,Auto,Auto"
        ColumnDefinitions="Auto, *"
        Style="{StaticResource Grid.Page}">
</Grid>
...

```

# [Adding resource dictionary](https://youtu.be/rHflpkCZeF8?t=730)

1. In the folder *Resources/Style, add, new Item*
2. Name the file as *AppStyles.xaml*
3. In the App.xaml file add the *AppStyles.xaml* reference as shown in the code below:

```
<?xml version = "1.0" encoding = "UTF-8" ?>
<Application ...>
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="Resources/Styles/Colors.xaml" />
                <ResourceDictionary Source="Resources/Styles/Styles.xaml" />

                <ResourceDictionary Source="Resources/Styles/appStyles.xaml" />

            </ResourceDictionary.MergedDictionaries>
    </Application.Resources>
</Application>
```

# [Using reusable string in resource dictionary](https://youtu.be/rHflpkCZeF8?t=833)

1. In the *AppStyles.xaml* add the code below:
   
```
<x:String x:Key="ApplicationTitle">
Adventure Works - Rannyere Costa
</x:String>

```

2. In the *MainPage.xmal* file, edit it as shown in the code below:

```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="AdventureWorks.MainPage"
             Title="{StaticResource ApplicationTitle}">
...             
</ContentPage>             
```