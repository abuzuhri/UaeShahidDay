using GoTech.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace UaeShahidDay.Data.Entity
{
    public class Shahid : BaseGoTechEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
