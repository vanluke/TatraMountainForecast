using Model.Interfaces;

namespace Model.Implementation
{
    public class Geolocation : IGeolocation
    {
        public Geolocation(string latitude, string longitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }
        public Geolocation()
        {
                
        }
        public string Latitude { get; set; }

        public string Longitude { get; set; }
    }
}
