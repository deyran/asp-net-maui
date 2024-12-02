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
https://youtu.be/_z8cbTLVOm0?t=269
```

4. AAAAAA