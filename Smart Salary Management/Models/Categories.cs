using System.ComponentModel.DataAnnotations;

namespace Smart_Salary_Management.Models
{
    public class Categories
    {
        [Key]
        public int? Id { get; set; }

        public string? Name { get; set; }

        public string? Balance { get; set; }

        public string? Quota { get; set; }

        public IEnumerable<Transactions>? TransactionsList { get; set; }

    }
}
