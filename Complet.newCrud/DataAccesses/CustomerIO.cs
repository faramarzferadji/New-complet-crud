using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Complet.newCrud.Business;

namespace Complet.newCrud.DataAccesses
{
   public static class CustomerIO
    {
        private static string filePath = Application.StartupPath + @"\Customers.dat";
        private static string filetemp = Application.StartupPath + @"\Temp.dat";

        public static void SaveRecord(Customer cust)
        {
            StreamWriter streamWriter = new StreamWriter(filePath, true);
            streamWriter.WriteLine(cust.Customerid + "," + cust.FirstName + "," + cust.LastName
                + "," + cust.PhoneNumber);
            streamWriter.Close();
            MessageBox.Show("Customer data has been saved !");
           
        }
        public static void ListCustomers(ListView listViewCustomer)
        {
            StreamReader streamReader = new StreamReader(filePath);
            listViewCustomer.Items.Clear();//it is for clear the line for reading next line!***
            string line = streamReader.ReadLine();
            while(line != null)
            {
                string[] fields = line.Split(",");
                ListViewItem item = new ListViewItem(fields[0]);
                item.SubItems.Add(fields[1]);
                item.SubItems.Add(fields[2]);
                item.SubItems.Add(fields[3]);
                listViewCustomer.Items.Add(item);
                line = streamReader.ReadLine();//now rea next line
            }
            streamReader.Close();
        }
        public static List<Customer> ListCustomer()
        {
            List<Customer> listc = new List<Customer>();
            StreamReader streamReader = new StreamReader(filePath);
            string line = streamReader.ReadLine();
            while(line != null)
            {
                string[] fields = line.Split(",");
                Customer cust = new Customer();
                cust.Customerid = Convert.ToInt32(fields[0]);
                cust.FirstName = fields[1];
                cust.LastName = fields[2];
                cust.PhoneNumber = fields[3];
                listc.Add(cust);
                line = streamReader.ReadLine();//read next line
                
            }

            streamReader.Close();

            return listc;
        }
        public static Customer Search(int custID)
        {
            Customer cusT = new Customer();
            StreamReader streamReader = new StreamReader(filePath);
            string line = streamReader.ReadLine();
            while(line != null)

            {
                string[] fields = line.Split(",");
                if (custID == Convert.ToInt32(fields[0]))
                {
                    cusT.Customerid = Convert.ToInt32(fields[0]);
                    cusT.FirstName = fields[1];
                    cusT.LastName = fields[2];
                    cusT.PhoneNumber = fields[3];
                    return cusT;
                }

                line = streamReader.ReadLine();              
            }
            streamReader.Close();
            return null;
        }
        public static Customer Search(string otherinfo)
        {
            Customer cust = new Customer();
            StreamReader streamReader = new StreamReader(filePath);
            string line = streamReader.ReadLine();
            while(line != null)
            {
                string[] fields = line.Split(",");
                if(otherinfo == fields[1] || otherinfo == fields[2] || otherinfo == fields[3]){
                    cust.Customerid = Convert.ToInt32(fields[0]);
                    cust.FirstName = fields[1];
                    cust.LastName = fields[2];
                    cust.PhoneNumber = fields[3];
                    streamReader.Close();
                    return cust;
                }
                line = streamReader.ReadLine();

            }
            streamReader.Close();
            return null;
        }
        public static void Delete(int custid)
        {
            StreamReader streamReader = new StreamReader(filePath);
            StreamWriter streamWriter = new StreamWriter(filetemp);
            string line = streamReader.ReadLine();
            while(line != null)
            {
                string[] fields = line.Split(",");
                if(custid != Convert.ToInt32(fields[0]))
                {
                    streamWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3]);

                }
                line = streamReader.ReadLine();


            }
            streamReader.Close();
            streamWriter.Close();
            File.Delete(filePath);
            File.Move(filetemp, filePath);
        }
        public static void UpDate(Customer cust)
        {
            StreamReader streamReader = new StreamReader(filePath);
            StreamWriter streamWriter = new StreamWriter(filetemp);
            string line = streamReader.ReadLine();

            while (line != null)
            {
                string[] fields = line.Split(",");
                if (Convert.ToInt32(fields[0]) != cust.Customerid)
                {
                    streamWriter.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3]);

                }
                line = streamReader.ReadLine();

            }
            streamWriter.WriteLine(cust.Customerid + "," + cust.FirstName 
                + "," + cust.LastName + "," + cust.PhoneNumber);
            streamReader.Close();
            streamWriter.Close();
            File.Delete(filePath);
            File.Move(filetemp, filePath);



        }
    }
    
}
