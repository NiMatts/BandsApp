using BandsApp.Web.Models;

namespace BandsApp.Web.Services;

public class BandService
{
    private List<Band> bands = [
        new Band{ Id = 1, Name = "Spice Girls", Description = ""},
        new Band{ Id = 2, Name = "Westlife", Description = ""},
        new Band{ Id = 3, Name = "The Real Group", Description = ""},
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
