namespace Pontozo.ViewModel;
[QueryProperty(nameof(P), nameof(P))]
public partial class MainViewModel : ObservableObject
{
    
    Random ran = new Random();
    [ObservableProperty]
    public Pont p;

    [ObservableProperty]
    public bool isMinus;

    [ObservableProperty]
    ObservableCollection<Pont> pontLista = new();
    public MainViewModel()
    {
        
    }
    

    [RelayCommand]
    public void AddPont()
    {
        string[] gyumolcsok = ["Ananász", "Banán", "Avokádó", "Eper", "Egres", "Fekete ribiszke", "Körte", "Kaktuszszamóca", "Málna", "Meggy", "Narancs", "Õszibarack", "Paradicsom", "Ribiszke", "Sárgadinnye", "Vadkörte"];
        ran.Shuffle(gyumolcsok);
                
        Pont pont = new Pont();
        pont.Id = ran.Next(1, 1000000);
        pont.Name = gyumolcsok[0];
        pont.Ertek = 0;
        pont.Hatter = Color.FromRgb(ran.Next(100,256), ran.Next(100, 256), ran.Next(100, 256));
        PontLista.Add(pont);
        IsMinus = true;
    }

    [RelayCommand]
    public void RemovePoint()
    {
        if (PontLista.Count > 0)
        {
            int last = PontLista.Count - 1;
            PontLista.RemoveAt(last);
        }
        IsMinus = PontLista.Count > 0;
        
    }
    
    [RelayCommand]
    public void IncrementValue(Pont p)
    {
        foreach(Pont pont in PontLista)
        {
            if (!string.IsNullOrEmpty(pont.Name) && pont.Name.Equals(p.Name))
            {
                pont.Ertek += pont.Novekmeny;
                break;
            }
        }
    }
    
    [RelayCommand]
    public void DecreaseValue(Pont p)
    {
        foreach (Pont pont in PontLista)
        {
            if (!string.IsNullOrEmpty(pont.Name) && pont.Name.Equals(p.Name))
            {
                pont.Ertek -= pont.Novekmeny; ;
                break;
            }
        }
    }
    
    [RelayCommand]
    public void UpdatePont(Pont p)
    {
        foreach( Pont pont in PontLista)
        {
            if (pont.Id== p.Id)
            {
                pont.Hatter = p.Hatter;
                pont.Name = p.Name;
                pont.Ertek  = p.Ertek;
                pont.Novekmeny  = p.Novekmeny;
                break;
            }
        }
    }

    [RelayCommand]
    Task GoToDetails(Pont P)
    {
        return Shell.Current.GoToAsync($"{nameof(DetailView)}",
                new Dictionary<string, object>
                {
                    ["P"] = P
                });
    }

}