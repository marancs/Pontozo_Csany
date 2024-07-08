namespace Pontozo.View;

public partial class MainPage : ContentPage
{
	MainViewModel _vm;
	public MainPage(MainViewModel mainViewModel)
	{
		InitializeComponent();
		_vm = mainViewModel;
		BindingContext = _vm;
		if (DeviceInfo.Platform == DevicePlatform.Android)
		{
			VerticalLayout.Add(new MainAndroidView(new MainViewModel()));
		}
		else if (DeviceInfo.Platform == DevicePlatform.WinUI)
		{
            VerticalLayout.Add(new MainWindowsView(new MainViewModel()));
        }

	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        _vm.UpdatePontCommand.Execute(_vm.P);
    }

}