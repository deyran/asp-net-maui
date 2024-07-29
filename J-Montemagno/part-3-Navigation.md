# [Implementing navigation in .Net MAUI # passing parameters](https://youtu.be/DuNLR_NJv8U?t=8763)

1. Open the **MonkeysViewModel** class and add the code below:
   
```
[RelayCommand]
async Task GoToDetailsAsync(Monkey monkey)
{
    if (monkey is null)
        return;

    await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true, 
        new Dictionary<string, object>
        {
            {"Monkey",monkey}
        });
}
```

2. Open and edit **MainPage.xaml** as shown in the code below:

```

<ContentPage ... >
    <Grid ...>
        <CollectionView ...>
            <CollectionView.ItemTemplate>
                <DataTemplate ...>
                    <Grid ...>
                        <Frame ...>

                            <Frame.GestureRecognizers>
                                <TapGestureRecognizer Command="{Binding .}"
                                                      CommandParameter="{Binding Source={RelativeSource AncestorType={x:Type viewmodel: viewmodel:MonkeysViewModel}}, Path=GoToDetailsCommand}"/>
                            </Frame.GestureRecognizers>
        ...                            
    </Grid>
</ContentPage>
```

3. AAAAAAAA