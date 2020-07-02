using System.Linq;

namespace Calculator
{
    public class ChampionGame : CalcuratorBase
    {
        private bool _isChampionStage = false;

        protected override int BetInner
        {
            get
            {
                if (this._list.Count == 1) return _list.First();
                return this._list.First() + this._list.Last();
            }
        }

        public override string Name => "Champion Game";

        public override void Lose()
        {
            this._list.Add(this.BetInner);
        }

        public override void Reset()
        {
            this._isChampionStage = false;
            this._list.Clear();
            this._list.AddRange(new int[] { 1, 1 });
        }

        public override void Win()
        {
            if (this._list.Count <= 2)
            {
                if (this._isChampionStage)
                {
                    Reset();
                    return;
                }

                this._isChampionStage = true;
                this._list.Clear();
                this._list.AddRange(new int[] { 1, 1, 1 });
                return;
            }

            this._list.RemoveAt(0);
            this._list.RemoveAt(this._list.Count - 1);
        }
    }
}
