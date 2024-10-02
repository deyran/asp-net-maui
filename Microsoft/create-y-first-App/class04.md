# [Use Stacks and Flex Layouts (4 of 18) | Building Apps with XAML and .NET MAUI](https://youtu.be/VJ2at_4ZiGE?si=H1QEOlaxLdPOT-lj)

1. In the MainPage.xaml file add new row, HorizontalStackLayout and Buttons control
   
```
<Grid RowDefinitions="Auto,Auto,Auto,Auto,Auto,Auto,Auto,Auto,Auto" ...>
    
    ...

    <Label Grid.Row="3" Text="Login Id" 
            VerticalOptions="Center" HorizontalOptions="End" />
    <VerticalStackLayout Grid.Row="3" Grid.Column="1">
        <Entry Text="" 
                Placeholder="Please use a combination of letters and numbers." />
        <Label FontSize="Micro" 
                Text="Please use a combination of letters and numbers." />
    </VerticalStackLayout>

    ...

    <Label Grid.Row="7"
            Text="Is Enrolled?"
            VerticalOptions="Center" />
    <FlexLayout Grid.Row="7"
                Grid.Column="1"
                Wrap="Wrap">
        <HorizontalStackLayout Spacing="5">
            <Label Text="401k?" 
                    VerticalOptions="Center" />
            <CheckBox IsChecked="True" />
        </HorizontalStackLayout>
        <HorizontalStackLayout Spacing="5">
            <Label Text="Flex Time?" 
                    VerticalOptions="Center" />
            <CheckBox />
        </HorizontalStackLayout>
        <HorizontalStackLayout Spacing="5">
            <Label Text="Health Care?" 
                    VerticalOptions="Center" />
            <CheckBox IsChecked="True" />
        </HorizontalStackLayout>
        <HorizontalStackLayout Spacing="5">
            <Label Text="Health Saving Account?" 
                    VerticalOptions="Center" />
            <CheckBox IsChecked="True" />
        </HorizontalStackLayout>
    </FlexLayout>
            
    <HorizontalStackLayout Grid.Row="9"
                            Grid.Column="1"
                            Spacing="5">
        <Button Text="Save" />
        <Button Text="Cancel" />            
    </HorizontalStackLayout>

</Grid>
```

2. AAA