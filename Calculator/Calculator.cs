using System;
using System.Collections.Generic;

namespace Calculator
{

    public interface ICalcurator
    {
        void Reset();

        int Multiplier { get; set; }

        int Bet { get; }

        void Win();
        void Lose();

        string ListText { get; }

        string Name { get; }
    }

    public abstract class CalcuratorBase : ICalcurator
    {
        protected List<int> _list = new List<int>();
        protected int _multi = 1;

        public CalcuratorBase()
        {
            Reset();
        }

        public abstract string Name { get; }

        protected abstract int BetInner
        {
            get;
        }

        public int Bet
        {
            get
            {
                return BetInner * Multiplier;
            }
        }

        public abstract void Lose();

        public abstract void Reset();

        public abstract void Win();

        public string ListText
        {
            get
            {
                return string.Join('-', this._list);
            }
        }

        public int Multiplier
        {
            get
            {
                return this._multi;
            }
            set
            {
                if (value < 1) throw new ArgumentOutOfRangeException();
                if (value > 10) throw new ArgumentOutOfRangeException();
                this._multi = value;
            }
        }
    }
}
