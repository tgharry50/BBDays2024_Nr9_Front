using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class MedkitModel
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int id {  get; set; }
        public string ip_address { get; set; } = string.Empty;
        public int bandage { get; set; } = 0;
        public int elastric { get; set; } = 0;
        public int splint { get; set; } = 0;
        public int plaster_mark { get; set; } = 0;
        public int plaster {  get; set; } = 0;
        public int plaster_mark_2 { get; set; } = 0;
        public int spirit { get; set; } = 0;
        public int foil_nrc { get; set; } = 0;
        public int mask {  get; set; } = 0;
        public int bloodsucker { get; set; } = 0;
        public int latex { get; set; } = 0;
        public int dust_wound { get; set; } = 0;
        public int medpack { get; set; } = 0;
        public string uwaga { get; set; } = string.Empty;
        public double cord_x {  get; set; } = 0;
        public double cord_y { get; set; } = 0;
        public DateTime Created_At {  get; set; } = DateTime.Now;
        public DateTime Updated_At { get;set; } = DateTime.Now;
    }
}
