# [Design a Screen Using a Grid (3 of 18) | Building Apps with XAML and .NET MAUI](https://youtu.be/ygGSQ8At8w0?si=1SGoWw5GneQ4Fito)

```
<Grid RowDefinitions="Auto, Auto, Auto, Auto, Auto, Auto, Auto"
        ColumnDefinitions="Auto, *" Padding="7">

    <Label Grid.Row="0"
            Grid.ColumnSpan="2"
            Text="User Information"
            FontSize="Title" />
    <Label Grid.Row="1"
            Grid.ColumnSpan="2"
            Text="Use this screen to modify user information"
            FontSize="Body" />

    <BoxView Grid.Row="2"
                Grid.ColumnSpan="2"
                Margin="0, 0, 0, 10"
                HeightRequest="1"
                Color="Black" />
    
        
    <Label Grid.Row="3" Text="Login Id" 
            VerticalOptions="End" HorizontalOptions="End" />
    <Entry Grid.Row="3" Grid.Column="1" Text="" />

    <Label Grid.Row="4" Text="First Name" 
            VerticalOptions="End" HorizontalOptions="End" />
    <Entry Grid.Row="4" Grid.Column="1" Text="" />

    <Label Grid.Row="5" Text="Last Name" 
            VerticalOptions="End" HorizontalOptions="End" />
    <Entry Grid.Row="5" Grid.Column="1" Text="" />
    
    <Label Grid.Row="6" Text="Email address" 
            VerticalOptions="End" HorizontalOptions="End" />
    <Entry Grid.Row="6" Grid.Column="1" Text="" />

</Grid>
```