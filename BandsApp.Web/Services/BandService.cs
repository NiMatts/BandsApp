using BandsApp.Web.Models;

namespace BandsApp.Web.Services;

public class BandService
{
    private List<Band> bands = [
        new Band{ Id = 1, Name = "Spice Girls", Description = "Spice Girls är ett brittiskt popband som blev världskända på 90-talet med sitt budskap om \"girl power\".", ImageUrl="spice_girls.jpg" },
        new Band{ Id = 2, Name = "Westlife", Description = "Westlife är ett irländskt pojkband känt för sina romantiska hits och stora internationella framgångar.", ImageUrl="westlife.jpg"},
        new Band{ Id = 3, Name = "The Real Group", Description = "The Real Group är en svensk a cappella-grupp känd för sin jazziga stil och vokala perfektion.", ImageUrl = "The_Real_Group.jpg"},
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
