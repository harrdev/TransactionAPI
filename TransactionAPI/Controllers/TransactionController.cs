using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TransactionAPI.Models;

namespace TransactionAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {

        [HttpGet("id/{id}")]
        public ActionResult<Transaction> GetTransactionById(string id)
        {
            List<Transaction> list = new();

            try
            {
                StreamReader sr = new("Data\\transactions.json");
                string json = sr.ReadToEnd();

                if (json != null)
                {
                    list = JsonConvert.DeserializeObject<List<Transaction>>(json);
                }
            }
            catch
            {
                // Would create custom exception and logger if time permitted
                string message = "There was an error converting JSON file into list of Transactions";
                Console.WriteLine(message);
            }

            if (list is null || list.Count == 0)
            {
                return NotFound("There are no Transactions available");
            }

            foreach (Transaction t in list)
            {
                if (id.Equals(t.Id))
                {
                    return Ok(t);
                }
            }

            return NotFound("A transaction with that Id is not found");
        }


        [HttpGet("accountNumber/{id}")]
        public ActionResult<List<Transaction>> GetTransactionByAccountNumber(string id)
        {
            List<Transaction> list = new();
            List<Transaction> results = new();

            try
            {
                StreamReader sr = new("Data\\transactions.json");
                string json = sr.ReadToEnd();

                if (json != null)
                {
                    list = JsonConvert.DeserializeObject<List<Transaction>>(json);
                }
                else
                {
                    return new NotFoundResult();
                }
            }
            catch
            {
                string message = "There was an error converting JSON file into list of Transactions";
                Console.WriteLine(message);
            }

            if (list is null || list.Count == 0)
            {
                return NotFound("There are no Transactions available");
            }

            foreach (Transaction t in list)
            {
                if (id.Equals(t.AccountNumber))
                {
                    results.Add(t);
                }
            }

            if (results.Count > 0)
            {
                return Ok(results);
            }

            return NotFound("A transaction with that Account number is not found");
        }

        // DateRange API call not functioning.  Need to do proper conversions before comparison
        [HttpGet("datePicker/{from},{to}")]
        public ActionResult<List<Transaction>> GetTransactionByDateRange(DateTime from, DateTime to)
        {
            List<Transaction> list = new();
            List<Transaction> results = new();

            try
            {
                StreamReader sr = new("Data\\transactions.json");
                string json = sr.ReadToEnd();

                if (json != null)
                {
                    list = JsonConvert.DeserializeObject<List<Transaction>>(json);
                }
                else
                {
                    return new NotFoundResult();
                }
            }
            catch
            {
                string message = "There was an error converting JSON file into list of Transactions";
                Console.WriteLine(message);
            }

            if (list is null || list.Count == 0)
            {
                return NotFound("There are no Transactions available");
            }

            foreach (Transaction t in list)
            {
                t.PostDate.ToShortDateString();
                if (t.PostDate >= from && t.PostDate <= to)
                {
                    results.Add(t);
                }
            }

            if (results.Count > 0)
            {
                return Ok(results);
            }

            return NotFound("No transactions between those dates exist");
        }
    }
}
