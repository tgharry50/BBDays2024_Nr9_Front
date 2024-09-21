using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RegisterModel
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int id { get; set; }
        public string first_name { get; set; } = string.Empty;
        public string last_name { get; set; } = string.Empty;
        public string login {  get; set; } = string.Empty;
        public string password {  get; set; } = string.Empty;
        public int privelage { get; set; } = 0;
        public DateTime Created_At { get; set; } = DateTime.Now;
        public DateTime Updated_At { get; set; } = DateTime.Now;
    }
}
