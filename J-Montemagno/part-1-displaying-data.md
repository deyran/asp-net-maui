# [Learn .NET MAUI - Full Course for Beginners | Build cross-platform apps in C#](https://youtu.be/DuNLR_NJv8U?si=5bi_V4ljtMNs5Wub)

## Part 1 - Displaying Data

1. [dotnet-maui-workshop](https://github.com/dotnet-presentations/dotnet-maui-workshop) - Clone this repo
      
2. [25:13](https://youtu.be/DuNLR_NJv8U?t=1513) Click on "MonkeyFinder.sln (Part 1 - Displaying Data\MonkeyFinder.sln)
   
3. [29:42](https://youtu.be/DuNLR_NJv8U?t=1608) Monkey data
   
   1. [Mokey Json data](https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/MonkeysApp/monkeydata.json)
   
   2. [Convert json to charp](https://json2csharp.com/)
   
   3. Monkey class

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

4. [39:41](https://youtu.be/DuNLR_NJv8U?t=2381) Collection

    1. In the **View/MainPage.xaml** file, Add the Model reference

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

    5. Working with more data

        ```
        <CollectionView>
            <CollectionView.ItemsSource>
                <x:Array Type="{x:Type model:Monkey}">
                    <model:Monkey
                        Name = "Baboon"
                        Location = "Africa and Asia"
                        Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg" />
                    <model:Monkey
                        Name = "Capuchin Monkey"
                        Location = "Central and South America"
                        Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/capuchin.jpg" />

                    <model:Monkey
                        Name = "Blue Monkey"
                        Location = "Central and East Africa"
                        Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/bluemonkey.jpg" />

                    <model:Monkey
                        Name = "Squirrel Monkey"
                        Location = "Central and South America"
                        Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/saimiri.jpg" />

                    <model:Monkey
                        Name = "Golden Lion Tamarin"
                        Location = "Brazil"
                        Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/tamarin.jpg" />

                    <model:Monkey
                        Name = "Howler Monkey"
                        Location = "South America"
                        Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/alouatta.jpg" />

                    <model:Monkey
                        Name = "Japanese Macaque"
                        Location = "Japan"
                        Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/macasa.jpg" />

                    <model:Monkey
                        Name = "Mandrill"
                        Location = "Southern Cameroon, Gabon, and Congo"
                        Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/mandrill.jpg" />

                </x:Array>
            </CollectionView.ItemsSource>

            <CollectionView.ItemTemplate>
                <DataTemplate x:DataType="model:Monkey">
                    <HorizontalStackLayout Padding="10">
                        <Image Source="{Binding Image}"
                            HeightRequest="100"
                            WidthRequest="100"
                            Aspect="AspectFill" />
                        
                        <VerticalStackLayout Padding="10" Spacing="10" VerticalOptions="Center">
                            <Label Text="{Binding Name}" FontSize="24" />
                            <Label Text="{Binding Location}" FontSize="12" />
                        </VerticalStackLayout>
                    </HorizontalStackLayout>
                </DataTemplate>
            </CollectionView.ItemTemplate>
        </CollectionView>            
        ```

    6. Single label set up a binding multiple properties

        ```
        <Label VerticalOptions="Center">
            <Label.Text>
                <MultiBinding StringFormat="{}{0} | {1}">
                    <Binding Path="Name" />
                    <Binding Path="Location" />
                </MultiBinding>
            </Label.Text>
        </Label>
        ```

5. A
6. A
7. A