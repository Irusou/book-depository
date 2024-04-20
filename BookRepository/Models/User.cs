namespace BookRepository.Models
{
    public class User
    {
        public int Id {  get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        private string _Password { get; set; }
        public string PasswordHash { get; set; }

        private List<int> books;

        public User(int UserId, List<Object> args) { 
        
            Id = UserId;
            UserName = (string) args[0];
            Email = (string) args[1];
            books = new List<int>();
        }

        public void AddBook(int bookId)
        {
            if(!books.Contains(bookId)) books.Add(bookId);
            else Console.Write("Book already in Collection");
        }

        public void ReadBook(int bookId)
        {
            if (books.Contains(bookId))
            {
                //GetBook
            } else Console.Write("You don't  have this book.");

        }

        public void DownloadBook(int bookId)
        {
            if (books.Contains(bookId))
            {
                //GetBook
            }else Console.Write("You don't  have this book.");

        }
    }
}
