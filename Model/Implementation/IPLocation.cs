using Model.Interfaces;

namespace Model.Implementation
{
    public class IPLocation : IIPLocation
    {
        public string Ip { get; set; }

        public string Hostname { get; set; }

        public string Loc { get; set; }

        public string Org { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string Country { get; set; }

        public int Phone { get; set; }
    }
}
