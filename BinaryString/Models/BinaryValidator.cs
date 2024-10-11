using System.ComponentModel.DataAnnotations;

namespace BinaryString.Models
{
    public class BinaryValidator
    {
        [Required]
        [RegularExpression("^[01]+$", ErrorMessage = "Binary string can only contain '0' and '1'.")]
        public string BinaryString { get; set; }

        public bool IsValidString { get; set; } // Checks if the binary string has an equal number of '0's and '1's

        public bool CheckIfValidString() // Validates the binary string
        {
            if (string.IsNullOrEmpty(BinaryString)) return false;

            int countOfZero = 0;
            int countOfOne = 0;

            foreach (char c in BinaryString)
            {
                if (c == '0') countOfZero++;
                else if (c == '1') countOfOne++;
                else return false; // Return false for invalid characters

                if (countOfOne < countOfZero) return false;
            }

            return countOfOne == countOfZero; // Return true if counts are equal
        }
    }
}