using BandsApp.Web.Models;

namespace BandsApp.Web.Services;

public class BandService
{       //Westlife, Coast to Coast, World of Our Own, Turnaround, Back Home
    //spice girls: Spice, Spiceworld, Forever, Greatest Hits, Spice 25.
    //the real group: Debut, Nothing But the Real Group, Unreal!, Commonly Unique, In the Middle of Life.
    private List<Band> bands = [
        new Band{
            Id = 1,
            Name = "Spice Girls",
            Description = "Spice Girls är ett brittiskt popband som blev världskända på 90-talet med sitt budskap om \"girl power\".",
            ImageUrl="spice_girls.jpg" ,
            YouTubeUrl="https://www.youtube.com/embed/5JD6ejmlpa8?si=08DtOjDMKcBTL_Si",
            Albums=[
                new Album{ Id=100, BandId=1, Name= "Spiceworld" },
                new Album{ Id=101, BandId=1, Name= "Spice" }
                ]
            },

        new Band{
            Id = 2,
            Name = "Westlife",
            Description = "Westlife är ett irländskt pojkband känt för sina romantiska hits och stora internationella framgångar.",
            ImageUrl="westlife.jpg", 
            YouTubeUrl="https://www.youtube.com/embed/ulOb9gIGGd0?si=pB_ZrK7GYXQfPBgf",
            Albums=[
                new Album{ Id=200, BandId=2, Name= "Coast to Coast" },
                new Album{ Id=201, BandId=2, Name= "World of Our Own" }
                ]},
        new Band{
            Id = 3,
            Name = "The Real Group",
            Description = "The Real Group är en svensk a cappella-grupp känd för sin jazziga stil och vokala perfektion.",
            ImageUrl = "The_Real_Group.jpg" , YouTubeUrl="https://www.youtube.com/embed/bRqOjKWobSI?si=yNoI1VW_Ae15XhIo",
            Albums=[
                new Album{ Id=300, BandId=3, Name= "Debut" },
                new Album{ Id=301, BandId=3, Name= "Nothing But the Real Group" }
                ]}

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
