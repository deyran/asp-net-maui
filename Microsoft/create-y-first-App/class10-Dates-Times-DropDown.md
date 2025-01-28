# [Dates, Times, and Drop-Down Lists (10 of 18)](https://youtu.be/n1lxyQXVmkc?si=eUBlbDjjsnFqfikM)

1. DatePicker

```
<Frame Padding="10" Margin="20">
    <HorizontalStackLayout>
        <Label Text="DatePicker" />
        <DatePicker HorizontalOptions="Start" />
    </HorizontalStackLayout>
</Frame>
```

2. TimerPicker
   
```
<Frame Padding="10" Margin="20">
    <HorizontalStackLayout>
        <Label Text="TimePicker" />
        <TimePicker Time="06:00:00" />
    </HorizontalStackLayout>
</Frame>

```

3. Picker
   
```
<Frame Padding="10" Margin="20">
    <HorizontalStackLayout>
        <Picker>
            <Picker.ItemsSource>
                <x:Array Type="{x:Type x:String}">
                    <x:String>Home</x:String>
                    <x:String>Mobile</x:String>
                    <x:String>Other</x:String>
                </x:Array>
            </Picker.ItemsSource>
        </Picker>
    </HorizontalStackLayout>
</Frame>
```

4. AAAAA