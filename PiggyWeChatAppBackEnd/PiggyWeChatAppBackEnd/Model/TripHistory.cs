using PiggyWeChatAppBackEnd.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PiggyWeChatAppBackEnd.Model
{
    public class TripHistory
    {
        private static TripHistory _instance = null;
        private readonly DateTime _lastUpdate;
        private readonly List<Trip> _trips;
        private static readonly object o = new object();

        public TripHistory(DateTime last, List<Trip> trips)
        {
            _lastUpdate = last;
            _trips = trips;
        }

        public static TripHistory GetInstance()
        {
            lock (o)
            {
                if(_instance == null)
                    _instance = DataHelper.GetFromJSon<TripHistory>("./wwwroot/Data/TripTest.json");
            }

            return _instance;
        }

        public int GetTripCount()
        {
            return _trips.Count();
        }

        public List<Trip> GetTripList()
        {
            return _trips;
        }

        public bool AddTrip(string location, string date, string feeling)
        {
            try
            {
                _trips.Add(new Trip() {
                    Location = location,
                    Feeling = feeling,
                    Date = date,
                    Activities = new List<Activity>()
                });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SaveTripsToFile()
        {
            return DataHelper.WriteToJson("./wwwroot/Data/TripTest.json", _instance);
        }

        ~TripHistory()
        {
            lock (o)
            {
                SaveTripsToFile();
            }
        }
    }
}
