using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PassawordHash { get; set; }
        public byte[] PassawordSalt { get; set; }

        
    }
}