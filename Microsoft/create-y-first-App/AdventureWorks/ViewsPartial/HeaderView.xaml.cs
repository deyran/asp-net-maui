namespace AdventureWorks.ViewsPartial;

public partial class HeaderView : ContentView
{
	public HeaderView()
	{
		InitializeComponent();

        ViewTitle = "ViewTitle";

        this.BindingContext = this;
	}

    public string ViewTitle
    {
        get { return (string)GetValue(ViewTitleProperty); }
        set { SetValue(ViewTitleProperty, value); }
    }

    public static readonly BindableProperty ViewTitleProperty = 
        BindableProperty.Create("ViewTitle", typeof(string), typeof(HeaderView), string.Empty);

}