using System;
using System.Collections.Generic;
using System.Text;

namespace RottenUI.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public string AudienceScore { get; set; }
        public string TomatometerScore { get; set; }
        public string Info { get; set; }
        public List<CastMember> Cast { get; set; }
        public string PosterUrl { get; set; }
        public string BackdropUrl { get; set; }
    }
}
