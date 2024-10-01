# [Use Stacks and Flex Layouts (4 of 18) | Building Apps with XAML and .NET MAUI](https://youtu.be/VJ2at_4ZiGE?si=H1QEOlaxLdPOT-lj)

1. In the MainPage.xaml file add new row, HorizontalStackLayout and Buttons control
   
```
<Grid RowDefinitions="Auto, ..." ...>
    
    ...
    
    <Label Grid.Row="3" Text="Login Id" 
            VerticalOptions="Center" HorizontalOptions="End" />
    <VerticalStackLayout Grid.Row="3" Grid.Column="1">
        <Entry Text="" />
        <Label FontSize="Micro" 
                Text="Please use a combination of letters and numbers." />
    </VerticalStackLayout>

    ...

    <HorizontalStackLayout Grid.Row="7"
                            Grid.Column="1"
                            Spacing="5">
        
        <Button Text="Save" />
        <Button Text="Cancel" />
        
    </HorizontalStackLayout>

</Grid>
```

2. AAA