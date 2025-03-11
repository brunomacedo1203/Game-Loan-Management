using System.ComponentModel.DataAnnotations;

namespace Game_Loan_Management.Models
{
    public class LoanModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name of the Borrower")]
        public string Borrower { get; set; }

        [Required(ErrorMessage = "Please enter the name of the Lender")]
        public string Lender { get; set; }

        [Required(ErrorMessage = "Please enter the name of the Game")]
        public string Game { get; set; }

        [Required(ErrorMessage = "Please select a Genre")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Please enter the Loan Date")]
        public DateTime LoanDate { get; set; }

        [Required(ErrorMessage = "Please enter the Return Date")]
        public DateTime ReturnDate { get; set; }
    }
}
