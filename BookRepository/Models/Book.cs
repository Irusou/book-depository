namespace BookRepository.Models
{
    public class Book
    {

        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string AuthorId { get; set; }
        public float priceHard {  get; set; }
        public float priceDigital { get; set; }
        //digital version to implement
        public List<Tags> tags;


        public Book(int id, List<Object> info) {

            if (info.Count > 0 && info != null)
            {
                Title = (string)info[0];
                Description = (string)info[1];
                Author = (string)info[2];
                AuthorId = (string)info[3];
                priceHard = (float)info[4];
                priceDigital = (float)info[5];

                tags = new List<Tags>((List<Tags>)info[6]);

            }
            else Console.Write("Error in Creating Book");

        }

        public void AddTag(Tags tag)
        {
            if (tag != null && !tags.Contains(tag))
            {
                tags.Add(tag);
            }
            else Console.Write("Can't add Tag");
        }

        public void RemoveTag(Tags tag)
        {
            if (tag != null && tags.Contains(tag))
            {
                tags.Remove(tag);
            }
            else Console.Write("Can't remove Tag");

        }

        public void EditBook(List<Object> info)
        {
            if (info.Count > 0 && info != null)
            {

                if ((string)info[0] != null) Title = (string)info[0];
                if ((string)info[1] != null) Description = (string)info[1];
                if ((string)info[2] != null) Author = (string)info[2];
                if ((string)info[3] != null) AuthorId = (string)info[3];
                if ((string)info[4] != null) priceHard = (float)info[4];
                if ((string)info[5] != null) priceDigital = (float)info[5];
                if ((string)info[6] != null) tags.AddRange((List<Tags>)info[6]);

            }
        }
    }
}
