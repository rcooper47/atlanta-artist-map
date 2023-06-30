using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//TODO Change topSong to Array
//TODO Add DTO
namespace atl_artist_api.Models
{
    public class ArtistModel
    {
        public int id { get; set; }
        public String? name { get; set; }
        public String? topSong { get; set; }
        
        public String? neighborhood { get; set; }
        public String? genre { get; set; }
        

    }
}