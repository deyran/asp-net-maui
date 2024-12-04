namespace AdventureWorks.ViewsPartial;

public partial class HeaderView : ContentView
{
    public HeaderView()
    {
        InitializeComponent();

        ViewTitle = "ViewTitle";
        ViewDescription = "View Description";

        this.BindingContext = this;
    }

    public string ViewTitle
    {
        get { return (string)GetValue(ViewTitleProperty); }
        set { SetValue(ViewTitleProperty, value); }
    }

    public static readonly BindableProperty ViewTitleProperty =
        BindableProperty.Create("ViewTitle", typeof(string), typeof(HeaderView), string.Empty);

    public string ViewDescription
    {
        get { return (string)GetValue(ViewDescriptionProperty); }
        set { SetValue(ViewDescriptionProperty, value); }
    }

    public static readonly BindableProperty ViewDescriptionProperty =
        BindableProperty.Create("ViewDescription", typeof(string), typeof(HeaderView), string.Empty);   
}