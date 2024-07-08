namespace Pontozo.ViewModel;
[QueryProperty(nameof(P), nameof(P))]
public partial class DetailViewModel : ObservableObject
{
	[ObservableProperty]
	public Pont p;
    
    [ObservableProperty]
    public Color? hatter;

    [ObservableProperty]
    ObservableCollection<Color> szinek = new();

    [RelayCommand]
    public void FillColors()
    {
        Szinek.Clear();
        Szinek.Add(Colors.Aqua);
        Szinek.Add(Colors.LightBlue);
        Szinek.Add(Colors.LightGray);
        Szinek.Add(Colors.LightGreen);
        Szinek.Add(Colors.Yellow);
        Szinek.Add(Colors.LightCoral);
        Szinek.Add(Colors.Orange);
        Szinek.Add(Colors.AliceBlue);
        Szinek.Add(Colors.Cyan);

    }
    [RelayCommand]
    public void SetBackground(Color c)
    {
        P.Hatter = c;
        Hatter = c;
    }

    [RelayCommand]
    public void Nullaz()
    {
        P.Ertek = 0;
    }

    [RelayCommand]
    Task GoBack()
    {
        return Shell.Current.GoToAsync($"..",
                new Dictionary<string, object>
                {
                    ["P"] = P
                });
    }
    public DetailViewModel()
	{
		
	}
}