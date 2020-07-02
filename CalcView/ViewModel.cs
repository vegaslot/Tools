using Calculator;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CalcView
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ICalcurator _calc = new MonteCalro2();
        public ICalcurator Calcurator
        {
            get { return _calc; }
            set
            {
                _calc = value;
                Reset();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public string Name => _calc.Name;

        public string ListText => _calc.ListText;

        public int Bet => this._calc.Bet;

        public int Multiplier
        {
            get { return this._calc.Multiplier; }
            set
            {
                this._calc.Multiplier = value;
                RaisePropertyChanged();
                this.Refresh();
            }
        }

        public void Win()
        {
            this._calc.Win();
            this.Refresh();
        }

        public void Lose()
        {
            this._calc.Lose();
            this.Refresh();
        }

        public void Reset()
        {
            this._calc.Reset();
            this.Refresh();
        }

        private void Refresh()
        {
            RaisePropertyChanged(nameof(Bet));
            RaisePropertyChanged(nameof(ListText));
            RaisePropertyChanged(nameof(Name));
        }
    }
}
