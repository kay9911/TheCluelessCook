using System.ComponentModel.DataAnnotations;

namespace TheCluelessCook.Models.Planner
{
    public class DayDetailModel
    {
        [Key]
        public string Id { get; set; }
        public string Day { get; set; }
        public string Date { get; set; }
    }
}
