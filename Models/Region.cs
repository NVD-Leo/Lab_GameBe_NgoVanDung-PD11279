using System.ComponentModel.DataAnnotations;

namespace SeverGame106.Models
{
    public class Region
    {
        public int RegionID {  get; set; }
        [Required]
        public string Name { get; set; }
    }
}
