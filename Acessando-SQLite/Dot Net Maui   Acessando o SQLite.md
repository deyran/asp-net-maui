# .NET MAUI :  Acessando o SQLite

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

## Criar classe modelo de domínio

* No diretório MVVM/Models criar a classe modelo Contato

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


## Injetar o serviço na aplicação


2. Editar o arquivo MauiProgam.cs, como mostrado abaixo

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

2. No diretório **MVVM/Views** criar a página AgendaView e no diretório **MVVM/ViewModels** criar a classe AgendaViewModel.cs
   
3. Implementar a classe AgendaViewModel.cs
   
```
```

4. 
5. Editar o arquivo App.xaml.cs para injetar IAgendaService

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

4. AAA
5. AAA
6. AAA