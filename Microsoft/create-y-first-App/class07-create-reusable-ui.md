# [Create Reusable UI (7 of 18)](https://youtu.be/_z8cbTLVOm0?si=hHGRxmoMBuVW00Ky)

1. In the root, create a folder called *ViewsPartial*
2. Inside the ViewsPartial folder, add new item [.NET MAUI ContentView (XAML)] called *HeaderView.xaml*, type the code below:

```
<Grid RowDefinitions="Auto, Auto, Auto">
    <Label Grid.Row="0"
        Text="{Binding ViewTitle}"
        HorizontalOptions="Center"
        FontSize="Title" />
    <Label Grid.Row="1"
        Grid.ColumnSpan="2"
        Text="{Binding ViewDescription}"
        HorizontalOptions="Center"
        FontSize="Body" />
    <BoxView Grid.Row="2"
        Margin="0,0,0,20"
        HeightRequest="1"
        Color="Black" />
</Grid>
```

3. Binding content, open the *HeaderView.xaml.cs* file and edit it as shown in the code below:

```
namespace AdventureWorks.ViewsPartial;

public partial class HeaderView : ContentView
{
    public HeaderView()
    {
        InitializeComponent();

        ViewTitle = "ViewTitle";
        ViewDescription = "View Description";

        this.BindingContext = this;
    }

    public string ViewTitle
    {
        get { return (string)GetValue(ViewTitleProperty); }
        set { SetValue(ViewTitleProperty, value); }
    }

    public static readonly BindableProperty ViewTitleProperty =
        BindableProperty.Create("ViewTitle", typeof(string), typeof(HeaderView), string.Empty);

    public string ViewDescription
    {
        get { return (string)GetValue(ViewDescriptionProperty); }
        set { SetValue(ViewDescriptionProperty, value); }
    }

    public static readonly BindableProperty ViewDescriptionProperty =
        BindableProperty.Create("ViewDescription", typeof(string), typeof(HeaderView), string.Empty);   
}
```

4. AAAAAA