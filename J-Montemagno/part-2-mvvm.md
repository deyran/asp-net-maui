# Part 2 - MVVM

## The basics

### [View-ViewModel-Model](https://youtu.be/DuNLR_NJv8U?t=3454)

1. Is an architecture pattern used to **separation of concerns** of the Code. The image below shows the interaction between View, ViewModel and Model.

<p align="center">
    <img src="part-2-mvvm-imgs/view-viewModel-model.png" />
</p>  

2. **View** -  *How to display* the information, it doesn't know about where the data is coming from or the data types. It just display data in a specific way. The view notify the ViewModel when the events happens, for example, when a button is clicked.

3. **ViewModel** - It's like the code behind of View. Tells the page *what to display* without knowing where the data is comes from. It controls the flow of interaction, it's going to do two way back and forth updates of *what to display*. When things change, notify the View that things need to be updated

4. **Model** - Business logic and Data handling. The Model encapsulates the application's business logic and manages data. Essentially, it's responsible for handling data persistence and manipulation.

### [Data Binding](https://youtu.be/DuNLR_NJv8U?t=3632)

1. **Data Binding** synchronizes the values of UI elements (views) with underlying data (often from a view model). When the data property changes or the events happen, for example, the view automatically reflects the update. The image below shows the interaction between View, Data Binding and ModelView

<p align="center">
    <img src="part-2-mvvm-imgs/data-binding.png" />
</p>  

2. **INotifyPropertyChanged** - The INotifyPropertyChanged interface is used to notify binding clients that a property value has changed. When a property in the ViewModel changes, it raises the **PropertyChanged** event causing the View reflects that change.

## [Let's do it!](https://youtu.be/DuNLR_NJv8U?t=4139)

1. [01:12:04](https://youtu.be/DuNLR_NJv8U?t=4324) In the **ViewModel/BaseViewModel** file, implement the INotifyPropertyChanged interface as shown in the code below:

```
namespace MonkeyFinder.ViewModel;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
}
```

2. Now create a method that any view could call and raise this event:

```
namespace MonkeyFinder.ViewModel;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged(string name)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
```

4. A