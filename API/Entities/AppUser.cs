namespace API.Entities
{
    public class AppUser
    {   
        public int Id { get; set; } // Keep it Id or ID as it is convention and the program will auto increament it in the database
        public string UserName { get; set; }
    }
}