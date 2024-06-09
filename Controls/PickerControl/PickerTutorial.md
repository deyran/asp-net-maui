# Picker tutorial

## Dados estáticos na página

```
<Picker x:Name="PickerTest01" Title="Select a monkey" SelectedIndexChanged="picker_SelectedIndexChanged">
    <Picker.Items>
        <x:String>Baboon</x:String>
        <x:String>Capuchin Monkey</x:String>
        <x:String>Blue Monkey</x:String>
        <x:String>Squirrel Monkey</x:String>
        <x:String>Golden Lion Tamarin</x:String>
        <x:String>Howler Monkey</x:String>
        <x:String>Japanese Macaque</x:String>
    </Picker.Items>
</Picker>
```

## Dados estáticos no Código

1. Na página

```
<Picker 
    x:Name="PickerTest01" 
    Title="Select a monkey" 
    SelectedIndexChanged="picker_SelectedIndexChanged">
</Picker>

<Button 
    x:Name="BttDados" 
    Text="Preencher dados" 
    Clicked="BttDados_Clicked" />
```

2. No código

```
private void BttDados_Clicked(object sender, EventArgs e)
{
    var monkeyList = new List<string>();

    monkeyList.Add("Baboon");
    monkeyList.Add("Capuchin Monkey");
    monkeyList.Add("Blue Monkey");
    monkeyList.Add("Squirrel Monkey");
    monkeyList.Add("Golden Lion Tamarin");
    monkeyList.Add("Howler Monkey");
    monkeyList.Add("Japanese Macaque");

    PickerTest01.Title = "Select a monkey";
    PickerTest01.ItemsSource = monkeyList;
}
```

## Evento SelectedIndexChanged

1. No arquivo MainPage.xaml

```
<Picker x:Name="PickerTest01" Title="Select a monkey" SelectedIndexChanged="picker_SelectedIndexChanged">
...
</Picker>

<Label x:Name="LabelName" Text="Selecione um item no Picker" />
```

2. No arquivo MainPage.xaml.cs

```
private void picker_SelectedIndexChanged(object sender, EventArgs e)
{
    var picker = (Picker)sender;
    int selectedIndex = picker.SelectedIndex;

    if (selectedIndex != -1)
    {
        LabelName.Text = picker.Items[selectedIndex];                
    }
}
```

## Label vinculado ao Picker

```
<Picker x:Name="PickerTest01" Title="Select a monkey">
    <Picker.Items>
        <x:String>Baboon</x:String>
        <x:String>Capuchin Monkey</x:String>
        <x:String>Blue Monkey</x:String>
        <x:String>Squirrel Monkey</x:String>
        <x:String>Golden Lion Tamarin</x:String>
        <x:String>Howler Monkey</x:String>
        <x:String>Japanese Macaque</x:String>
    </Picker.Items>
</Picker>

<Label Text="{Binding Source={x:Reference PickerTest01}, Path=SelectedItem}" />
```