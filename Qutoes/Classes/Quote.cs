namespace Qutoes.Classes
{
    public class Quote
    {
        public string Text { get; private set; }
        public int Votes { get; set; }
        public Author author { get; private set; }

        private IList<string> tags;
        public Quote(string authorName, string authorSurname, DateOnly authorBirthDate, string text)
        {
            author = new Author(authorName, authorSurname, authorBirthDate);
            Text = text;
            tags = new List<string>();
        }

        public Quote(Author author, string text)
        {
            this.author = author;
            Text = text;
            tags = new List<string>();

        }
        public void Upvote()
        {
            if (Votes < int.MaxValue)
            {
                Votes++;
            }
        }

        public void Downvote()
        {
            if (Votes > 0)
                Votes--;

        }
        public void AddTag(string tag)
        {
            tags.Add(tag.ToLower());
        }
        public IList<string> GetTags()
        {
            return tags.AsReadOnly();
        }
        public override string ToString()
        {
            return $"{Votes} - {author}";
        }

        public static void Run()
        {
            Quote firstQuote = new Quote("Vilim", "Kalan", new DateOnly(2005, 5, 13), "Sun rises so should you");
            Author author = new Author("San", "Tzu", new DateOnly(2000, 2, 13));

            Quote secondQuote = new Quote(author, "Fight, might be your last chance");

            firstQuote.Upvote();
            firstQuote.Upvote();
            firstQuote.Downvote();
            firstQuote.AddTag("firstTag");
            firstQuote.AddTag("secondTag");
            firstQuote.AddTag("thirdTag");

            Console.WriteLine(firstQuote.GetTags());
            Console.WriteLine(firstQuote.ToString());

            secondQuote.Upvote();
            secondQuote.Upvote();
            secondQuote.Upvote();

            secondQuote.AddTag("Love");
            secondQuote.AddTag("Peace");
            secondQuote.AddTag("Suffering");

            Console.WriteLine(secondQuote.ToString());

            foreach (var tag in firstQuote.GetTags())
            {
                Console.WriteLine($"{tag}\n");
            }

            foreach (var tag in secondQuote.GetTags())
            {
                Console.WriteLine($"{tag}\n");
            }
        }
    }

}

