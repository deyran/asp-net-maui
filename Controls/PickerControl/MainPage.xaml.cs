using PickerControl.Models;
using System.Collections.ObjectModel;

namespace PickerControl
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Pessoas> PessoasList { get; set; }
        public MainPage()
        {
            InitializeComponent();

            PessoasList = new ObservableCollection<Pessoas>
            {
                new Pessoas { IdPessoa = 0, Nome = "Deyvid Rannyere de Moraes Costa" },
                new Pessoas { IdPessoa = 1, Nome = "Márcia Costa de Moraes" },
                new Pessoas { IdPessoa = 2, Nome = "Lara Hellena Costa de Moraes" }
            };

            BindingContext = this;
        }
    }
}
