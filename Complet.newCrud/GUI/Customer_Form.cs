using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Complet.newCrud.Business;
using Complet.newCrud.DataAccesses;
using Complet.newCrud.Validations;
using System.Windows.Forms;

namespace Complet.newCrud.GUI
{
    public partial class Customer_Form : Form
    {
        List<Customer> listC = new List<Customer>();

        public Customer_Form()
        {
            InitializeComponent();
           // buttonList.Enabled = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure that you want to leave?",
                "Exit Application",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(answer == DialogResult.Yes)
            {
                Application.Exit();
            }
                
                
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.Customerid = Convert.ToInt32(textBoxCustomerid.Text);
            cus.FirstName = textBoxFirstName.Text;
            cus.LastName = textBoxLastName.Text;
            cus.PhoneNumber = maskedTextBoxphoneNumber.Text;
            listC.Add(cus);

            // buttonList.Enabled = true;

           // ClearAll();



        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCustomerid.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            maskedTextBoxphoneNumber.Clear();
            textBoxCustomerid.Focus();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<Customer> listC = CustomerIO.ListCustomer();
            if (Validation.Isunique(listC,Convert.ToInt32(textBoxCustomerid.Text)) 
                && Validation.IsValidID(textBoxCustomerid )
                 && Validation.isValidName(textBoxFirstName) 
                 && Validation.isValidName(textBoxLastName))
            {
                Customer acustomer = new Customer();
                acustomer.Customerid = Convert.ToInt32(textBoxCustomerid.Text);
                acustomer.FirstName = textBoxFirstName.Text;
                acustomer.LastName = textBoxLastName.Text;
                acustomer.PhoneNumber = maskedTextBoxphoneNumber.Text;

                CustomerIO.SaveRecord(acustomer);


            }

            // ClearAll();
        }
        private void ClearAll()
        {
            textBoxCustomerid.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            maskedTextBoxphoneNumber.Clear();
            textBoxCustomerid.Focus();


        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            CustomerIO.ListCustomers(listView1);
           

        }

        private void buttonUpDate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Customerid = Convert.ToInt32(textBoxCustomerid.Text);
            customer.FirstName = textBoxFirstName.Text;
            customer.LastName = textBoxLastName.Text;
            customer.PhoneNumber = maskedTextBoxphoneNumber.Text;
            DialogResult answer = MessageBox.Show("Do you realy want to update the customer?"
                , "update customer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(answer== DialogResult.Yes)
            {
                CustomerIO.UpDate(customer);
                MessageBox.Show("customer updated");
            }



        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Validation.Isunique(listC, Convert.ToInt32(textBoxCustomerid.Text))
               && Validation.IsValidID(textBoxCustomerid)
                && Validation.isValidName(textBoxFirstName)
                && Validation.isValidName(textBoxLastName)) { 
                CustomerIO.Delete(Convert.ToInt32(textBoxCustomerid.Text));
            MessageBox.Show("Customer successfully Deleted!");
                }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = comboBox.SelectedIndex;
            switch (choice)
            {
                case 0:
                    labelComboBox.Text = "pleas enter the customer id";
                    break;
                case 1:
                    labelComboBox.Text = "pleas enter first name";
                    break;
                case 2:
                    labelComboBox.Text = "pleas enter last name";
                    break;
                case 3:
                    labelComboBox.Text = "please entre phone number";
                    break;
                default:
                    break;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int choice = comboBox.SelectedIndex;
            switch (choice)
            {
                case -1:
                    MessageBox.Show("please enter one option");
                    break;
                case 0:
                    Customer cus = CustomerIO.Search(Convert.ToInt32(textBoxInputinfo.Text));
                    if(cus != null)
                    {
                        textBoxCustomerid.Text = (cus.Customerid).ToString();
                        textBoxFirstName.Text = cus.FirstName;
                        textBoxLastName.Text = cus.LastName;
                        maskedTextBoxphoneNumber.Text = cus.PhoneNumber;
                        
                    }
                    else
                    {
                        MessageBox.Show("customer not fund");
                        textBoxInputinfo.Clear();
                        textBoxInputinfo.Focus();
                    }
                    textBoxInputinfo.Clear();
                   
                    break;
                case 1:
                    Customer cust= CustomerIO.Search(textBoxInputinfo.Text);
                    if (cust != null)
                    {
                        textBoxCustomerid.Text = (cust.Customerid).ToString();
                        textBoxFirstName.Text = cust.FirstName;
                        textBoxLastName.Text = cust.LastName;
                        maskedTextBoxphoneNumber.Text = cust.PhoneNumber;

                    }
                    else
                    {
                        MessageBox.Show("customer not fund");
                        textBoxInputinfo.Clear();
                        textBoxInputinfo.Focus();
                    }
                    textBoxInputinfo.Clear();
                    break;
                case 2:
                    Customer custt = CustomerIO.Search(textBoxInputinfo.Text);
                    if (custt != null)
                    {
                        textBoxCustomerid.Text = (custt.Customerid).ToString();
                        textBoxFirstName.Text = custt.FirstName;
                        textBoxLastName.Text = custt.LastName;
                        maskedTextBoxphoneNumber.Text = custt.PhoneNumber;

                    }
                    else
                    {
                        MessageBox.Show("customer not fund");
                        textBoxInputinfo.Clear();
                        textBoxInputinfo.Focus();
                    }
                    textBoxInputinfo.Clear();
                    break;
                case 3:
                    Customer cusn = CustomerIO.Search(textBoxInputinfo.Text);
                    if (cusn != null)
                    {
                        textBoxCustomerid.Text = (cusn.Customerid).ToString();
                        textBoxFirstName.Text = cusn.FirstName;
                        textBoxLastName.Text = cusn.LastName;
                        maskedTextBoxphoneNumber.Text = cusn.PhoneNumber;

                    }
                    else
                    {
                        MessageBox.Show("customer not fund");
                        textBoxInputinfo.Clear();
                        textBoxInputinfo.Focus();
                    }
                    textBoxInputinfo.Clear();
                    break;
                    textBoxInputinfo.Clear();
                   
                    comboBox.SelectedItem="";


                default:
                    
                    break;


                   


            }
        }

        private void textBoxInputinfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
