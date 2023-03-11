namespace RandomUser.Models
{
    public class Response
    {
        public List<User> results { get; set; } = new List<User>();

		public Info info { get; set; } = new Info();
	}
}