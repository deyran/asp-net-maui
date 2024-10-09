# [Use Styles to Improve the UI (5 of 18) | Building Apps with XAML and .NET MAUI](https://youtu.be/rHflpkCZeF8?si=RKVjBd9Sxe2MH54j)

## <ContentPage.Resources>

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


*Continue ...*
https://youtu.be/rHflpkCZeF8?t=311