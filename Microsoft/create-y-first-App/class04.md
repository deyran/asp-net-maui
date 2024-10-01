# [Use Stacks and Flex Layouts (4 of 18) | Building Apps with XAML and .NET MAUI](https://youtu.be/VJ2at_4ZiGE?si=H1QEOlaxLdPOT-lj)

1. Add new row, HorizontalStackLayout and Buttons control
   
```
<Grid RowDefinitions="Auto, ..." ...>
    
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