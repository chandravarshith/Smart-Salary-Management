using System.ComponentModel.DataAnnotations;

namespace Smart_Salary_Management.Models
{
    public class Transactions
    {
        [Key]
        public int? Id { get; set; }

        public string? Account { get; set; }

        public string? Category { get; set; }

        public string? Date { get; set; }

        public string? Time { get; set; }

        public string? Description { get; set; }
    }
}
