using MvvmHelpers;
using MvvmHelpers.Commands;
using RottenUI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RottenUI.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<Movie> movies;

        public ObservableCollection<Movie> Movies { get => movies; set => movies = value; }

        public MainViewModel()
        {
            Movies = new ObservableCollection<Movie>
            {
                new Movie()
                {
                    Id = 1,
                    Title = "Zootopia",
                    ReleaseDate = "2016",
                    AudienceScore = "96%",
                    TomatometerScore = "96%",
                    //PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/hlK0e0wAQ3VLuJcsfIYPvb4JVud.jpg",
                    //BackdropUrl = "https://rukminim1.flixcart.com/image/416/416/jqmnv680/poster/3/t/x/medium-pwl-zootopia-judy-hopps-wall-poster-13-19-inches-matte-original-imaek7mvju7dmy6g.jpeg?q=70",
                    PosterUrl = "zootopia_poster.png",
                    BackdropUrl = "https://rukminim1.flixcart.com/image/416/416/jqmnv680/poster/3/t/x/medium-pwl-zootopia-judy-hopps-wall-poster-13-19-inches-matte-original-imaek7mvju7dmy6g.jpeg?q=70",
                    Info = "Determined to prove herself, Officer Judy Hopps, the first bunny on Zootopia's police force, jumps at the chance to crack her first case - even if it means partnering with scam-artist fox Nick Wilde to solve the mystery.",
                    
                    Cast = new List<CastMember>()
                    {
                        new CastMember() { Name="Ginnifer Goodwin", Role="Judy Hopps (voice)", ImageUrl="https://www.themoviedb.org/t/p/w138_and_h175_face/xOCA2WN5MRfXmJmlzEbFEhIbfIQ.jpg"},
                        new CastMember() { Name="Jason Bateman", Role="Nick Wilde (voice)", ImageUrl="https://www.themoviedb.org/t/p/w138_and_h175_face/8e6mt0vGjPo6eW52gqRuXy5YnfN.jpg"},
                        new CastMember() { Name="Jenny Slate", Role="Asst. Mayor (voice)", ImageUrl="https://www.themoviedb.org/t/p/w138_and_h175_face/iNpXig5Djkh5moYG4TCekIATs5B.jpg"},
                        new CastMember() { Name="Idris Elba", Role="Chief Bogo (voice)", ImageUrl="https://www.themoviedb.org/t/p/w138_and_h175_face/be1bVF7qGX91a6c5WeRPs5pKXln.jpg"},
                    }
                },

                new Movie()
                {
                    Id = 2,
                    Title = "Animal Planet",
                    ReleaseDate = "2016",
                    AudienceScore = "96%",
                    TomatometerScore = "96%",
                    PosterUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/hlK0e0wAQ3VLuJcsfIYPvb4JVud.jpg",
                    BackdropUrl = "https://rukminim1.flixcart.com/image/416/416/jqmnv680/poster/3/t/x/medium-pwl-zootopia-judy-hopps-wall-poster-13-19-inches-matte-original-imaek7mvju7dmy6g.jpeg?q=70",
                    Info = "Determined to prove herself, Officer Judy Hopps, the first bunny on Zootopia's police force, jumps at the chance to crack her first case - even if it means partnering with scam-artist fox Nick Wilde to solve the mystery.",

                    Cast = new List<CastMember>()
                    {
                        new CastMember() { Name="Ginnifer Goodwin", Role="Judy Hopps (voice)", ImageUrl="https://www.themoviedb.org/t/p/w138_and_h175_face/xOCA2WN5MRfXmJmlzEbFEhIbfIQ.jpg"},
                        new CastMember() { Name="Jason Bateman", Role="Nick Wilde (voice)", ImageUrl="https://www.themoviedb.org/t/p/w138_and_h175_face/8e6mt0vGjPo6eW52gqRuXy5YnfN.jpg"},
                        new CastMember() { Name="Jenny Slate", Role="Asst. Mayor (voice)", ImageUrl="https://www.themoviedb.org/t/p/w138_and_h175_face/iNpXig5Djkh5moYG4TCekIATs5B.jpg"},
                        new CastMember() { Name="Idris Elba", Role="Chief Bogo (voice)", ImageUrl="https://www.themoviedb.org/t/p/w138_and_h175_face/be1bVF7qGX91a6c5WeRPs5pKXln.jpg"},
                    }
                }
            };

        }

    }
}
