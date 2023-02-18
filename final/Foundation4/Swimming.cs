 class Swimming : Activity
    {
        private double _laps;

        public Swimming(DateTime date, int length, double laps) : base(date, length, 0.0)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return _laps * 0.05;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / _minutes) * 60.0;
        }
    }