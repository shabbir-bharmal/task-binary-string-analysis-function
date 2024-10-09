using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BinaryString.Models
{
    public class BinaryValidator
    {
        [Required]
        [RegularExpression("^[01]+$", ErrorMessage = "Binary string can only contain '0' and '1'.")]
        public string BinaryString { get; set; }

        public bool IsGood { get; set; }

        public bool CheckIfGood()
        {
            int countOfZero = 0;
            int countOfOne = 0;

            foreach (char c in BinaryString)
            {
                if (c == '0')
                {
                    countOfZero++;
                }
                else if (c == '1')
                {
                    countOfOne++;
                }
               
                if (countOfOne < countOfZero)
                {
                    return false; 
                }
            }
            return countOfZero == countOfOne;
        }

    }
}