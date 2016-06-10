namespace AkademiaProjekt
{
    public class Novel : Publication
    {
        public int YearOfRelease { get; set; }
        public Genres Genre { get; set; }

        public Novel (string title, string author, string description, Genres genre, int year)
        {
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.YearOfRelease = year;
            this.Description = this.GenerateDescription(description);
        }

        public Novel(){}

        protected override string GenerateDescription(string description)
        {
            string fullDescription = "\nNovel titled: '" + this.Title + "'\nwritten by: " + this.Author + " in " + this.YearOfRelease;
            fullDescription = fullDescription + "\nGenre: " + this.Genre + "\n\n" + description;
            return fullDescription;
        }
    }
}
