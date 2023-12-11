using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace examtask.MVC.Models
{
    public class Team:BaseEntity
    {
        public string Name { get; set; }
        public string position { get; set; }


        public string? Imageurl { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public string RedirectUrl1 { get; set; }
        public string RedirectUrl2 { get; set; }
        public string RedirectUrl3 { get; set; }
        public string RedirectUrl4 { get; set; }
        public List<Profession>? Professions { get; set; }

    }
}
