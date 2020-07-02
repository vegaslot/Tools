using System.Linq;

namespace Calculator
{
    public class MonteCalro3 : CalcuratorBase
    {

        public MonteCalro3()
        {
            Reset();
        }

        protected override int BetInner
        {
            get
            {
                return this._list.First() + this._list.Last();
            }
        }

        public override string Name => "MonteCarlo for3";

        public override void Lose()
        {
            this._list.Add(this.BetInner);
        }

        public override void Reset()
        {
            this._list.Clear();
            this._list.AddRange(new int[] { 1, 2, 3 });
        }

        public override void Win()
        {
            if (this._list.Count <= 5)
            {
                Reset();
                return;
            }

            this._list.RemoveAt(0);
            this._list.RemoveAt(0);
            this._list.RemoveAt(this._list.Count - 1);
            this._list.RemoveAt(this._list.Count - 1);
        }
    }
}
