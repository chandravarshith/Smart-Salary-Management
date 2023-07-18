using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Smart_Salary_Management.Models
{
    public class Accounts
    {
        [Key]
        public int? Id { get; set; }

        public string? Name { get; set; }

        public string? Balance { get; set; }

        public IEnumerable<Transactions>? TransactionsList { get; set; }

    }
}
