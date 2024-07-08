namespace Pontozo.View;

public partial class DetailView : ContentPage
{
	DetailViewModel viewModel;
	public DetailView(DetailViewModel v)
	{
		InitializeComponent();
        viewModel = v;
        BindingContext = viewModel;
	}

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        viewModel.FillColorsCommand.Execute(null);  
    }
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}