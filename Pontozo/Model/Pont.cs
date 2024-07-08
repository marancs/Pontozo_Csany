namespace Pontozo.Model
{
    public class Pont: ObservableObject
    {
        private long _id;
        private string? _name;
        private int _ertek;
        private Color? _hatter;
        private int _novekmeny;
        public long Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }
        public string? Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        public int Ertek
        {
            get { return _ertek; }
            set { SetProperty(ref _ertek, value); }
        }

        public Color? Hatter
        {
            get { return _hatter; }
            set { SetProperty(ref _hatter, value); }
        }
        public int Novekmeny
        {
            get { return _novekmeny==0?1:_novekmeny; }
            set { SetProperty(ref _novekmeny, value);}
        }
    }
}
