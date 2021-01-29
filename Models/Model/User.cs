using System.ComponentModel.DataAnnotations;

namespace Models.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Deposit { get; set; }
    }
}
