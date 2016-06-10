using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AkademiaProjekt
{
    public enum Genres { Fantasy, Criminal, Horror, Romance, Comedy, Poetry, Other, Undefined};
    [XmlInclude(typeof(Novel))]
    [XmlInclude(typeof(Drama))]
    public abstract class Publication
    {
        public string Title { get; set; }
        public string Author { get; set; }
        private string description;
        public string Description {
            get { return description; }
            set { if (value.Length < 800) description = value;
                else throw new FormatException(); }
        }
        
        public Publication()
        {
            this.Title = "";
            this.Author = "";
            this.Description = "";
        }

        public override string ToString()
        {
            return this.Title;
        }
        protected abstract string GenerateDescription(string description);
    }
}
