namespace BandsApp.Web.Models;

public class Band
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public string YouTubeUrl { get; set; } = null!;

    public List<Album> Albums { get; set; } = new List<Album>();
}
