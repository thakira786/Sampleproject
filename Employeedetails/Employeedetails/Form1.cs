using Employeedetails.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employeedetails
{
    public partial class Submit : Form
    {
        public Submit()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidNumber(txtAge.Text))
            {
                if (isValidNumber(txtNum.Text))
                {
                   
                    Employee employee = new Employee();
                    employee.name = txtName.Text;
                    employee.age = Convert.ToInt32(txtAge.Text);
                    employee.mobileno = Convert.ToInt32(txtNum.Text);
                    if (radioButton1.Checked == true)
                    {
                        employee.gender = radioButton1.Text;
                    }
                    else if(radioButton2.Checked == true)
                    {
                        employee.gender = radioButton2.Text;
                    }

                    addemployee(employee);

                }
                

                else
                {
                    MessageBox.Show("The Mobile Number you entered is incorrect");
                }

            }
            else
            {
                MessageBox.Show("The age you entered is incorrect");
            }
        }
            public void addemployee(Employee employee)
            {
                MessageBox.Show("Your form is registered");
            }
            private bool isValidNumber(string value)
            {
                int num;
                bool bResult = int.TryParse(value, out num);
                return bResult;
            }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

