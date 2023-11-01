using System.ComponentModel.DataAnnotations;

namespace DROPDOWN.Models.Cascade
{
    public class City
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public State State { get; set; }

    }
}
