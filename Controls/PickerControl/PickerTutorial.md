# Picker tutorial

## Dados estáticos

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