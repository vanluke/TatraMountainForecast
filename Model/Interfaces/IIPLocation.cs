
namespace Model.Interfaces
{
    public interface IIPLocation
    {
        string Ip { get; set; }
        string Hostname { get; set; }
        string Loc { get; set; }
        string Org { get; set; }
        string City { get; set; }
        string Region { get; set; }
        string Country { get; set; }
        int Phone { get; set; }
    }
}
