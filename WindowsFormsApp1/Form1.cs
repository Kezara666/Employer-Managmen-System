using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DTFMMF1;Initial Catalog=Login;Integrated Security=True");
        
        
        


        private void button2_Click(object sender, EventArgs e)
        {
            //logon එක
            String query = "SELECT * FROM login_Details WHERE UserName ='" + textBox1.Text.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            string query2= "SELECT * FROM login_Details WHERE Password ='" + textBox2.Text.ToString() + "'";
            SqlDataAdapter adapter_2 = new SqlDataAdapter(query2, conn);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);

            DataTable dtbl2 = new DataTable();
            adapter_2.Fill(dtbl2);
            if (dtbl.Rows.Count > 0)
            {// නම හරි
                Console.WriteLine("username_hari");
                if (dtbl2.Rows.Count > 0)
                {
                    //පාස්වර්ඩ් හරි
                    Console.WriteLine("password_hari");
                    Form2 frm = new Form2();                   
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    this.Close();



                }
                else
                {
                    MessageBox.Show("Invalid Login credentials, please check Username and Password and try again(Special Password)",
                    "Invalid Login Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error); 
                               

                }





            }
            else
            {
                MessageBox.Show("Invalid Login credentials, please check Username and Password and try again(Special User name))",
                "Invalid Login Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error // for Warning  
                           //MessageBoxIcon.Error // for Error 
                           //MessageBoxIcon.Information  // for Information
                           //MessageBoxIcon.Question // for Question
);
            }
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form2());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
             string message = "Are you sure,Do you really want to Exit...?";  
            string title = "Close Window";  
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;  
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);  
            if (result == DialogResult.Yes) {  
                this.Close();  
            }  
              
            else {
                return;
                // Do something  
            } 
             

        }
    }
}
