# [Implementing navigation in .Net MAUI # passing parameters](https://youtu.be/DuNLR_NJv8U?t=8763)

1. Open the MonkeysViewModel class and add the code below:
   
```
[RelayCommand]
async Task GoToDetailsAsync(Monkey monkey)
{
    if (monkey is null)
        return;

    await Shell.Current.GoToAsync($"{nameof(DetailsPage)}");

}
```

2. AAAAAAAAA