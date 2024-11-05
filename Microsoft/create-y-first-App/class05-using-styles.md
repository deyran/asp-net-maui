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

* *Now, any page got this resource*
* To override the global style for a specific element on a specific page, the only thing to do is write the style inside the *<ContentPage.Resources>* of the page.