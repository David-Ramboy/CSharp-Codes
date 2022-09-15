using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Movies
    {
        public string title;
        public string author;
        private string rating;

        public Movies(string atitle, string aauthor, string arating) {
            title = atitle;
            author = aauthor;
            Rating = arating;
        }
        // Getter and Setter
        public string Rating {
            // this get is the displayer of the rating
            get { return rating; }
            // this set is to allowing it to display outside
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else {
                    rating = "NR";
                }
            }
        }
    }
}
