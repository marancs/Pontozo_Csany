namespace Pontozo.View;

public partial class MainAndroidView : ContentView
{
    MainViewModel _vm;
    public MainAndroidView(MainViewModel mainViewModel)
	{
		InitializeComponent();
        _vm = mainViewModel;
        BindingContext = _vm;
        MinusGomb.ImageSource = "minus.png";
        MinusGomb.IsEnabled = false;
  
    }


    private void MinusGomb_Clicked(object sender, EventArgs e)
    {
        _vm.RemovePointCommand.Execute(null);
        if (!_vm.IsMinus)
        {
            MinusGomb.ImageSource = "minus.png";
        }

    }

    private void AddGomb_Clicked(object sender, EventArgs e)
    {
        _vm.AddPontCommand.Execute(null);
        MinusGomb.ImageSource = "minusw.png";
        MinusGomb.IsEnabled = true;
    }
}