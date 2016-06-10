using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaProjekt
{
    public class Drama : Publication
    {
        public int FirstPlayed { get; set; }
        public Drama(string title, string author, string description, int firstPlayed)
        {
            this.Title = title;
            this.Author = author;
            this.FirstPlayed = firstPlayed;
            this.Description = this.GenerateDescription(description);
        }
        public Drama() {}
        protected override string GenerateDescription(string description)
        {
            string fullDescription = "\nDrama titled: '" + this.Title + "'\nwritten by: " + this.Author;
            fullDescription = fullDescription + "\nFirst played in: " + this.FirstPlayed + "\n\n" + description;
            return fullDescription;
        }
    }
}
