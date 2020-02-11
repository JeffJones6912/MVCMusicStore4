using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStore4.Models
{
    public class MusicStoreDbInitializer
        : System.Data.Entity.DropCreateDatabaseAlways<MVCMusicStoreDB>
    {
        protected override void Seed(MVCMusicStoreDB context)
        {
            context.Artists.Add(new Artist { Name = "Al di Meola" });
            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Albums.Add(new Album {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Price = 9.99m,
                Title = "Caravan" });

            base.Seed(context);
        }
    }
}