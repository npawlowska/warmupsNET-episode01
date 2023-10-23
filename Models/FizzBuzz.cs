using System.ComponentModel.DataAnnotations;

namespace warmupsNET_episode01.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Wpisz liczbę")]
        [Range(1, 100, ErrorMessage = "Oczekiwana wartość {0} z zakredu {1} i {2}.")]
        [Required(ErrorMessage="Pole jest obowiązkowe (zmienione)")]
        public int? Number { get; set; }
        public string Check()
        {
            string OutputString = "";

            if (Number % 3 == 0)
            {
                OutputString += "Fizz";
            }
            if (Number % 5 == 0)
            {
                OutputString += "Buzz";
            }
            if (OutputString == "")
                return Number.ToString();
            return OutputString;
        }

    }
}

