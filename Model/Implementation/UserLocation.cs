using Model.Interfaces;

namespace Model.Implementation
{
    public class UserLocation : IUserLocation
    {
        public UserLocation(string currentLocation, string locationInfo)
        {
            CurrentLocation = currentLocation;
            LocationInfo = locationInfo;
        }

        public UserLocation()
        {
                
        }

        public string CurrentLocation { get; set; }

        public string LocationInfo { get; set; }
    }
}
