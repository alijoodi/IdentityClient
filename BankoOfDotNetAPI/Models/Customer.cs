using BankoOfDotNetAPI.Data;
using Microsoft.EntityFrameworkCore;
namespace BankoOfDotNetAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
