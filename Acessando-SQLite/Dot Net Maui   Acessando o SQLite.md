# [.NET MAUI :  Acessando o SQLite](https://youtu.be/F5kDagLBlPw?si=LqIhYVngpmaqIxX7)

## Pacotes a serem instalados

1. sqlite-net-pcl						1.8.116
2. SQLitePCLRaw.bundle_green			2.1.6
3. SQLitePCLRaw.core					2.1.6
4. SQLitePCLRaw.provider.dynamic_cdecl	2.1.6
5. CommunityToolkit.Mvvm				8.2.1

## Atributos da biblioteca SQLite.Net

1. [Table]
2. [Column]
3. [PrimaryKey]
4. [NotNull]
5. [ForeignKey]
6. [Unique]
7. [AutoIncrement]

## Tipos de dados no SQLite

1. Integer
2. Real
3. Text
4. Blog	

## DB Browser for SQLite

Permite criar, pesquisar e editar banco de dados SQLite

## Implementar a arquitetura MVVM
  
1. No diretório **MVVM/Views** criar a página **AgendaView.xaml**
   
2. No diretório **MVVM/Models** implementar a classe modelo Contato 
   
```
using SQLite;

[Table("Contato")]
public class Contato
{
	[PrimaryKey, AutoIncrement]
	public int Id { get; set; }

	[MaxLength(100), NotNull]
	public string Nome { get; set; }

	[MaxLength(200), NotNull]
	public string Email { get; set; }
}
```

2. No diretório **MVVM/ViewModels** criar e classe **AgendaViewModel.cs**
   

## Criar classe de serviço

1. No diretório Services, criar a interface **IAgendaService.cs**

```
public interface IAgendaService
{
    Task InitializeAsync();
    Task<List<Contato>> GetContatos();
    Task<Contato> GetContato(int contatoId);
    Task<int> AddContato(Contato contato);
    Task<int> UpdateContato(Contato contato);
    Task<int> DeleteContato(Contato contato);
}
```

2. No diretório Services, criar a classe **AgendaService.cs**

```
using SQLite;

public class AgendaService : IAgendaService
{
    private SQLiteAsyncConnection _dbConnection;

    public async Task InitializeAsync()
    {
        await SetUpDb();
    }

    private async Task SetUpDb()
    {
        if (_dbConnection == null)
        {
            string dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "Agenda.db3"
            );

            _dbConnection = new SQLiteAsyncConnection(dbPath);
            
            await _dbConnection.CreateTableAsync<Contato>();
        }
    }

    public async Task<int> AddContato(Contato contato)
    {
        return await _dbConnection.InsertAsync(contato);
    }

    public async Task<int> DeleteContato(Contato contato)
    {
        return await _dbConnection.DeleteAsync(contato);
    }

    public async Task<int> UpdateContato(Contato contato)
    {
        return await _dbConnection.UpdateAsync(contato);
    }

    public async Task<List<Contato>> GetContatos()
    {
        return await _dbConnection.Table<Contato>().ToListAsync();
    }

    public async Task<Contato> GetContato(int contatoId)
    {
        return await _dbConnection.Table<Contato>().FirstOrDefaultAsync(x => x.Id == contatoId);
    }
}
```

## Injetar o serviço na aplicação

1. No diretório **MVVM/ViewModels** implementar e classe **AgendaViewModel.cs** e injetar a classe serviço
   
```
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace AgendaApp.MVVM.ViewModels
{
    public partial class AgendaViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<Contato> _contatos;

        [ObservableProperty]
        private Contato _contatoAtual;

        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand DisplayCommand { get; set; }

        public AgendaViewModel(IAgendaService contatoRepository)
        {
            ContatoAtual = new Contato();

            AddCommand = new Command(
                async () =>
                {
                    await contatoRepository.InitializeAsync();
                    await contatoRepository.AddContato(ContatoAtual);
                    await Refresh(contatoRepository);
                }
            );

            UpdateCommand = new Command(
                async () =>
                {
                    await contatoRepository.InitializeAsync();
                    await contatoRepository.UpdateContato(ContatoAtual);
                    await Refresh(contatoRepository);
                }
            );

            DeleteCommand = new Command(
                async () =>
                {
                    await contatoRepository.InitializeAsync();

                    var resposta = await App.Current.MainPage.DisplayAlert("Alerta", "Confirma exclusão ?", "Sim", "Não");
                    if (resposta)
                        await contatoRepository.DeleteContato(ContatoAtual);

                    await Refresh(contatoRepository);
                }
            );

            DisplayCommand = new Command(
                async() =>
                {
                    await contatoRepository.InitializeAsync();
                    await Refresh(contatoRepository);
                }
            );
        }

        private async Task Refresh(IAgendaService contato)
        {
            Contatos = await contato.GetContatos();
        }
    }
}
```

2. Editar o arquivo **MauiProgam.cs** para registrar o serviço na container DI
   
```
using Microsoft.Extensions.Logging;

namespace AgendaApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            // AQUI
            builder.Services.AddSingleton<IAgendaService, AgendaService>();

            return builder.Build();
        }
    }
}
```

3. No arquivo **AgendaView.xaml.cs**, injetar classe serviço
   
```
using AgendaApp.MVVM.ViewModels;

namespace AgendaApp.MVVM.Views;

public partial class AgendaView : ContentPage
{
	public AgendaView(IAgendaService service)
	{
		InitializeComponent();
 
        BindingContext = new AgendaViewModel(service);
    }
}
```

4. No arquivo **App.xaml.cs**, injetar classe serviço
   
```
using AgendaApp.MVVM.Views;

namespace AgendaApp
{
    public partial class App : Application
    {
        public App(IAgendaService agendaService)
        {
            InitializeComponent();           
                        
            MainPage = new NavigationPage(new AgendaView(agendaService));
        }
    }
}
```

## Implementação da interface da aplicação

1. Na página AgendaView.xaml, definir o namespace da classe ViewModels

```
xmlns:local="clr-namespace:AgendaApp.MVVM.ViewModels"
```

2. Estrutura da interface
   
```
<Grid RowDefinitions=".3*,.9*" Padding="10">

    <VerticalStackLayout Padding="10" Margin="5">
        <Entry x:Name="txtNome" Placeholder="Nome" Text="{Binding ContatoAtual.Nome, Mode=TwoWay}" FontSize="Medium"  />
        <Entry x:Name="txtEmail" Placeholder="Email" Text="{Binding ContatoAtual.Email, Mode=TwoWay}" FontSize="Medium" />
        <HorizontalStackLayout HorizontalOptions="Center" Padding="5" Spacing="10">
            <Button Command="{Binding AddCommand}" Text="Incluir" BackgroundColor="Blue" FontAttributes="Bold"/>
            <Button Command="{Binding UpdateCommand}" Text="Alterar" BackgroundColor="Green" FontAttributes="Bold"/>
            <Button Command="{Binding DisplayCommand}" Text="Carregar" BackgroundColor="Black" FontAttributes="Bold"/>
        </HorizontalStackLayout>
    </VerticalStackLayout>

    <CollectionView
        Grid.Row="1" Margin="5"
        ItemsSource="{Binding Contatos}"
        SelectedItem="{Binding ContatoAtual}"
        SelectionMode="Single">
        <CollectionView.ItemTemplate>

            <DataTemplate>

                <SwipeView>
                    <SwipeView.LeftItems>
                        <SwipeItems>
                            <SwipeItem
                                BackgroundColor="Purple"
                                Command="{Binding Source={RelativeSource AncestorType={x:Type local:AgendaViewModel}}, Path=DeleteCommand}"
                                Text="Deleta" />
                        </SwipeItems>
                    </SwipeView.LeftItems>

                    <Grid ColumnDefinitions=".4*,.6*">
                        <Label Text="{Binding Nome}" FontSize="15" />
                        <Label Grid.Column="1" Text="{Binding Email}" FontSize="15" TextColor="Blue" />
                    </Grid>

                </SwipeView>

            </DataTemplate>
        </CollectionView.ItemTemplate>
    </CollectionView>

</Grid>
```