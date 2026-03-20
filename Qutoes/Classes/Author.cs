namespace Qutoes.Classes
{
    public class Author
    {
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public DateOnly AuthorBirthDate { get; set; }

        public Author(string authorName, string authorSurname, DateOnly authorBirthDate)
        {
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            AuthorBirthDate = authorBirthDate;
        }

        public override string ToString()
        {
            return $"{AuthorName} - {AuthorSurname} - {AuthorBirthDate}";
        }
    }
}
