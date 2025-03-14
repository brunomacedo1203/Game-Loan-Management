using System.Data;
using ClosedXML.Excel;
using Game_Loan_Management.Data;
using Game_Loan_Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace Game_Loan_Management.Controllers
{
    public class LoanController : Controller
    {
        readonly private ApplicationDbContext _db;

        public LoanController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<LoanModel> loans = _db.Loans;

            return View(loans);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
          

            if (id == null || id == 0)
            {
                return NotFound();
            }
            LoanModel loan = _db.Loans.FirstOrDefault(x => x.Id == id);

            if (loan == null)
            {
                return NotFound();
            }
                                                     
            return View(loan);
        }

        [HttpGet] 
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            LoanModel loan = _db.Loans.FirstOrDefault(x => x.Id == id);
            if (loan == null)
            {
                return NotFound();
            }
            return View(loan);
        }

        public IActionResult Export()
        {
            var data = GetData();
            using (XLWorkbook workBook = new XLWorkbook())
            {
                workBook.AddWorksheet(data, "Loan Data");
                using (MemoryStream ms = new MemoryStream())
                {
                    workBook.SaveAs(ms);
                    return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Loan.xlsx");
                }
            }
        }

        private DataTable GetData()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Loan Data";
            dataTable.Columns.Add("Borrower", typeof(string));
            dataTable.Columns.Add("Lender", typeof(string));
            dataTable.Columns.Add("Game", typeof(string));
            dataTable.Columns.Add("Genre", typeof(string));
            dataTable.Columns.Add("Loan Date", typeof(DateTime));
            dataTable.Columns.Add("Return Date", typeof(DateTime));

            var loans = _db.Loans.ToList();
            if (loans.Count > 0)
            {
                loans.ForEach(loan =>
                {
                    dataTable.Rows.Add(loan.Borrower, loan.Lender, loan.Game, loan.Genre, loan.LoanDate, loan.ReturnDate);
                });
            }
            return dataTable;
        }

        [HttpPost]
        public IActionResult Create(LoanModel loan)
        {
            if (ModelState.IsValid)
            {
                loan.LoanDate = DateTime.Now;

                _db.Loans.Add(loan);
                _db.SaveChanges();

                TempData["SuccessMessage"] = "Loan successfully created!";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Edit(LoanModel loan)
        {       

            if (ModelState.IsValid)
            {
                var loanDB = _db.Loans.Find(loan.Id);               
                loanDB.Borrower = loan.Borrower;
                loanDB.Lender = loan.Lender;
                loanDB.Game = loan.Game;
                loanDB.Genre = loan.Genre;
                loanDB.LoanDate = loan.LoanDate;
                loanDB.ReturnDate = loan.ReturnDate;

                _db.Loans.Update(loanDB);
                _db.SaveChanges();

                TempData["SuccessMessage"] = "Loan successfully updated!";
                return RedirectToAction("Index");
            }
            return View(loan);
        }

        [HttpPost]
        public IActionResult Delete(LoanModel loan)
        {
            if (loan == null)
            {
                return NotFound();
            }
            _db.Loans.Remove(loan);
            _db.SaveChanges();

            TempData["SuccessMessage"] = "Loan successfully deleted!";
            return RedirectToAction("Index");
        }
    }
}
