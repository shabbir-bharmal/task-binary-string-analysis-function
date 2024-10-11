using BinaryString.Models;
using System.Linq;
using System.Web.Mvc;

namespace BinaryString.Controllers
{
    public class BinaryController : Controller
    {
        [HttpGet]
        public ActionResult Homepage() // Homepage action to display the main view
        {
            return View(); // Returns the homepage view
        }

        [HttpPost]
        public JsonResult CheckBinaryString(BinaryValidator model) // CheckBinaryString action to validate the binary string
        {
            if (ModelState.IsValid)
            {
                model.IsValidString = model.CheckIfValidString(); // Check if the binary string is valid

                return Json(new
                {
                    status = true,
                    message = model.IsValidString
                        ? "The binary string has been validated successfully."
                        : "Validation failed: The binary string is invalid.",
                    IsValidString = model.IsValidString
                });
            }

            // Using LINQ to create a list of error messages for invalid model state
            var errors = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage)
                .ToList();

            return Json(new
            {
                status = false,
                message = errors.Any()
                    ? string.Join(", ", errors)
                    : "Validation failed: An unknown error occurred.",
                IsValidString = false // Indicate validation failed
            });
        }
    }
}
