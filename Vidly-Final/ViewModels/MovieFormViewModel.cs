using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_Final.Models;

namespace Vidly_Final.ViewModels
{
    public class MovieFormViewModel
    {
        public List<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";

                return "New Movie";
            }
        }
    }
}