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

1. [01:12:04](https://youtu.be/DuNLR_NJv8U?t=4324) INotifyPropertyChanged
2. [01:22:54](https://youtu.be/DuNLR_NJv8U?t=4947) CommunityToolkit.Mvvm

    * **CommunityToolkit.Mvvm** is a library that simplifies the implementation of the MVVM pattern in .Net applications. It includes an abstract base class called **ObservableObject**.

    * When a ViewModel class inherits from the ObservableObject class, it automatically handles property change notifications without requiring manual implementation of the interface.

3. [01:27:14](https://youtu.be/DuNLR_NJv8U?t=5234) ObservableObject