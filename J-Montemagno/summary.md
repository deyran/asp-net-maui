# [Learn .NET MAUI - Full Course for Beginners | Build cross-platform apps in C#](https://youtu.be/DuNLR_NJv8U?si=5bi_V4ljtMNs5Wub)

## Introduction

* [08:58](https://youtu.be/DuNLR_NJv8U?t=538) - Project Structure
* [15:28](https://youtu.be/DuNLR_NJv8U?t=928) - Application lifecycle
* [17:06](https://youtu.be/DuNLR_NJv8U?t=1026) - Shell
* [18:02](https://youtu.be/DuNLR_NJv8U?t=1082) - Pages
* [18:43](https://youtu.be/DuNLR_NJv8U?t=1123) - Layout
* [20:13](https://youtu.be/DuNLR_NJv8U?t=1213) - Providing Behavior

## Part 1 - Displaying Data

### [22:06](https://youtu.be/DuNLR_NJv8U?t=1326) - Building our first applications

1. [dotnet-maui-workshop](https://github.com/dotnet-presentations/dotnet-maui-workshop) - Clone this repo
      
2. [25:13](https://youtu.be/DuNLR_NJv8U?t=1513) Click on "MonkeyFinder.sln (Part 1 - Displaying Data\MonkeyFinder.sln)
   
3. [29:42](https://youtu.be/DuNLR_NJv8U?t=1608) Monkey data
   
   * [Mokey Json data](https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/MonkeysApp/monkeydata.json)
   * [Convert json to charp](https://json2csharp.com/)
   * Monkey class

        ```
        using System.Text.Json.Serialization;

        namespace MonkeyFinder.Model;

        public class Monkey
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Details { get; set; }
            public string Image { get; set; }
            public int Population { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }
        ```

   * [39:41](https://youtu.be/DuNLR_NJv8U?t=2381) CollectionView
  
        1. Static Collection
     
            1. Add the Model reference
         
                ```
                xmlns:model="clr-namespace:MonkeyFinder.Model"
                ```

            2. Structure of the CollectionView

                ```
                <CollectionView>
                    <CollectionView.ItemsSource>

                    </CollectionView.ItemsSource>
                </CollectionView>
                ```

            3. Specifying the static Collection and putting data
      
                ```
                <CollectionView>
                    <CollectionView.ItemsSource>
                        <x:Array Type="{x:Type model:Monkey}">
                            <model:Monkey Name="Baboon" />
                            <model:Monkey Name="Capuchin Monkey" />
                            <model:Monkey Name="Red-shanked douc" />
                        </x:Array>            
                    </CollectionView.ItemsSource>
                </CollectionView>
                ```

            4. Using **Item template** 
         
                Item template is used to define specifically what each of items looks like. Look in the code below:

                ```
                <CollectionView>
                    <CollectionView.ItemsSource>
                        <x:Array Type="{x:Type model:Monkey}">
                            <model:Monkey Name="Baboon" />
                            <model:Monkey Name="Capuchin Monkey" />
                            <model:Monkey Name="Red-shanked douc" />
                        </x:Array>            
                    </CollectionView.ItemsSource>
                    <CollectionView.ItemTemplate>
                        <DataTemplate x:DataType="model:Monkey">
                            <HorizontalStackLayout Padding="10">
                                <Label Text="{Binding Name}" />
                            </HorizontalStackLayout>
                        </DataTemplate>
                    </CollectionView.ItemTemplate>
                </CollectionView>
                ```

        2. AAA
   
   * AAA

4. AAA

* A
* A
* A
* A
* A
* A
* A
* 
* A
* A