class Activity
    {
        protected DateTime _date;
        protected int _minutes;
        protected double _distance;

        public Activity(DateTime date, int length, double distance)
        {
            _date = date;
            _minutes = length;
            _distance = distance;
        }

        public virtual double GetDistance()
        {
            return _distance;
        }

        public virtual double GetSpeed()
        {
            return (_distance / _minutes) * 60.0;
        }

        public virtual double GetPace()
        {
            return 60 / GetSpeed();
        }

        public string GetSummary()
        {
            return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_minutes} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
        }
    }