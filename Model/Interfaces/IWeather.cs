
namespace Model.Interfaces
{
    public interface IWeather
    {
        int Id { get; set; }
        string QuickDescription { get; set; }
        string Description { get; set; }
        string Icon { get; set; }
    }
}
