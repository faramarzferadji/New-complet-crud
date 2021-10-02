using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Complet.newCrud.DataAccesses;
using Complet.newCrud.Business;
using Complet.newCrud.GUI;

namespace Complet.newCrud.Validations
{
   public class Validation
    {
        public static bool IsValidID(string input)
        {
            int tempID;

            if (input.Length != 5 || (Int32.TryParse(input, out tempID)))
            {
                MessageBox.Show("Invalid ID,Must have 5 digits");
                return false;
            }

            return true;
        }
        public static bool IsValidID(TextBox text) //for validation the text
        {
            int tempID;
            if (text.TextLength != 5 || !(Int32.TryParse(text.Text, out tempID)))
            {
                MessageBox.Show("Invalid ID,Must have 5 digits");
                return false;
            }

            return true;
        }
        public static bool Isunique(List<Customer> listC, int id)
        {
            foreach (Customer customer in listC)
            {
                if (customer.Customerid == id)
                {
                    MessageBox.Show("user ID must be uniq");
                    return false;
                }
            }
            return true;
        }
        public static bool isValidName(TextBox text)
        {
            for (int i = 0; i < text.TextLength; i++)
            {
                if (char.IsDigit(text.Text, i) || (char.IsWhiteSpace(text.Text, i)))
                {
                    MessageBox.Show("invalid name,please enter valid name");
                    text.Clear();
                    text.Focus();
                    return false;
                }

            }
            return true;
        }


    }
}
