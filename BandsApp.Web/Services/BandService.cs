using BandsApp.Web.Models;

namespace BandsApp.Web.Services;

public class BandService
{
    private List<Band> bands = [
        new Band{ Id = 1, Name = "Spice Girls", Description = "", ImageUrl="spice_girls.jpg" },
        new Band{ Id = 2, Name = "Westlife", Description = "", ImageUrl="westlife.jpg"},
        new Band{ Id = 3, Name = "The Real Group", Description = "", ImageUrl = "The_Real_Group.jpg"},
        ];

    public Band? GetBandById(int id)
    {
        return bands.SingleOrDefault(o => o.Id == id);
    }

    public Band[] GetAllBands()
    {
        return bands.OrderBy(o => o.Name).ToArray();
    }
}
