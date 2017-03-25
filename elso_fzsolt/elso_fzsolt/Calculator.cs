using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso_fzsolt
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
                return 0;

            string defaultDelimiter = ",";
            if (numbers.StartsWith("//"))
            {
                defaultDelimiter = numbers[2].ToString();
                numbers = numbers.Substring(3);
            }

            string negativeNumbers = String.Empty;
          
            string[] parameters = numbers.Split(new string[] { defaultDelimiter, "\n" }, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;


            foreach (string item in parameters)
            {
                int actNumber;
                if (int.TryParse(item, out actNumber))
                {
                    if (actNumber < 0)
                        negativeNumbers += actNumber + " ";
                    else
                        sum += actNumber;
                }
                else
                { throw new Exception("Hibás paraméterek!"); }
            }
            if (!String.IsNullOrEmpty(negativeNumbers))
                throw new Exception(String.Format("Negatives not allowed: {0}", negativeNumbers));
            return sum;
        }
    }
}
