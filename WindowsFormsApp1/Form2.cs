using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            fillcombo();
        }



        
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DTFMMF1;Initial Catalog=Student;Integrated Security=True");
        int reg_no;
        int mob_numb;
        int home_numb;
        int cantact_numb;

        void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Checked = false;



        }


        void insert()
        {
            //reg no ගැනීම

            try
            {

                reg_no = int.Parse(comboBox1.Text);


            }
            catch
            {
                MessageBox.Show("Input Not Valid for RegNO try again only numbers",
                    "Invalid Reg No",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            Console.WriteLine("methana" + reg_no);


            //fist name ,last name
            String fist_name = textBox1.Text;
            String last_name = textBox2.Text;

            //date of birth
            DateTime D_O_B = dateTimePicker1.Value;

            //gender
            String gen;
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                gen = "Male";
            else
                gen = "Female";

            //addres

            string adrress = textBox3.Text;

            //email
            string email = textBox4.Text;

            //mobile phone
            try
            {

                mob_numb = int.Parse(textBox5.Text);


            }
            catch
            {
                MessageBox.Show("Input Not Valid Mobile Number try again only numbers",
                    "Invalid Mobile No",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

            Console.WriteLine(mob_numb);

            //home number

            try
            {

                home_numb = int.Parse(textBox6.Text);


            }
            catch
            {
                MessageBox.Show("Input Not Valid Home Number try again only numbers",
                    "Invalid Home No",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

            //parent name
            string parent_name = textBox9.Text;

            //nic
            string nic = textBox8.Text;

            //cantact number

            try
            {

                cantact_numb = int.Parse(textBox7.Text);


            }
            catch
            {
                MessageBox.Show("Input Not Valid Cantact Number try again only numbers",
                    "Invalid Cantact No",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            //ඉවරයි

            //empty value check

            if (fist_name.Length > 0 && last_name.Length > 0 && gen.Length > 0 && adrress.Length > 0 && email.Length > 0 && parent_name.Length > 0 && nic.Length > 0)
            {
                conn.Open();
                SqlCommand cmnd = new SqlCommand("insert into Registration values('" + reg_no + "','" + fist_name + "','" + last_name + "','" + D_O_B + "','" + gen + "','" + adrress + "','" + email + "','" + mob_numb + "','" + home_numb + "','" + parent_name + "','" + nic + "','" + cantact_numb + "');", conn);
                object o = cmnd.ExecuteNonQuery();

                conn.Close();


                MessageBox.Show("Recode Update Successfully",
                    "Register Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);



            }
            else
            {
                MessageBox.Show("Input Not Valid.Please fill all",
                    "Empty Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        void fillcombo()
        {
            String query = "SELECT regNo FROM Registration ; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                int row_numb = 0;
                string registerno = "05654";
                for(int i = 0; i < dtbl.Rows.Count; i++)
                {
                    registerno = dtbl.Rows[row_numb][0].ToString();
                    comboBox1.Items.Add(registerno);
                    row_numb++;
                }


                


            }



        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reg no ගැනීම
            
            try
            {
              
                reg_no = int.Parse(comboBox1.Text);
                

            }
            catch
            {
                MessageBox.Show("Input Not Valid for RegNO try again only numbers",
                    "Invalid Reg No",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            Console.WriteLine("methana"+reg_no);


            //fist name ,last name
            String fist_name = textBox1.Text;
            String last_name = textBox2.Text;
            
            //date of birth
            DateTime D_O_B=  dateTimePicker1.Value;
            
            //gender
            String gen;
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                gen = "Male";
            else
                gen = "Female";

            //addres

            string adrress = textBox3.Text;

            //email
            string email=textBox4.Text;

            //mobile phone
            try
            {

                mob_numb = int.Parse(textBox5.Text);


            }
            catch
            {
                MessageBox.Show("Input Not Valid Mobile Number try again only numbers",
                    "Invalid Mobile No",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

            Console.WriteLine(mob_numb);

            //home number

            try
            {

                home_numb = int.Parse(textBox6.Text);


            }
            catch
            {
                MessageBox.Show("Input Not Valid Home Number try again only numbers",
                    "Invalid Home No",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

            //parent name
            string parent_name=textBox9.Text;

            //nic
            string nic=textBox8.Text;

            //cantact number

            try
            {

                cantact_numb = int.Parse(textBox7.Text);


            }
            catch
            {
                MessageBox.Show("Input Not Valid Cantact Number try again only numbers",
                    "Invalid Cantact No",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            //ඉවරයි

            //empty value check

            if (fist_name.Length > 0 && last_name.Length > 0 && gen.Length > 0 && adrress.Length > 0 && email.Length > 0 && parent_name.Length > 0 && nic.Length > 0 )
            {
                conn.Open();
                SqlCommand cmnd = new SqlCommand("insert into Registration values('" + reg_no + "','" + fist_name + "','" + last_name + "','" + D_O_B + "','" + gen + "','" + adrress + "','" + email + "','" + mob_numb + "','" + home_numb + "','" + parent_name + "','" + nic + "','" + cantact_numb + "');", conn);
                object o = cmnd.ExecuteNonQuery();
                
                conn.Close();
                

                MessageBox.Show("Recode Added Successfully",
                    "Register Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                clear();



            }
            else
            {
                MessageBox.Show("Input Not Valid.Please fill all",
                    "Empty Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int reg = int.Parse(comboBox1.Text);

            String query = "SELECT * FROM Registration WHERE regNo ='" + reg + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                textBox1.Text=dtbl.Rows[0][1].ToString();
                textBox2.Text=dtbl.Rows[0][2].ToString();
                textBox3.Text=dtbl.Rows[0][5].ToString();
                textBox4.Text=dtbl.Rows[0][6].ToString();
                textBox5.Text = dtbl.Rows[0][7].ToString();
                textBox6.Text = dtbl.Rows[0][8].ToString();
                textBox9.Text = dtbl.Rows[0][9].ToString();
                textBox8.Text = dtbl.Rows[0][10].ToString();
                textBox7.Text = dtbl.Rows[0][11].ToString();

                //කැලැන්ඩරේ දින

                String date_Value = dtbl.Rows[0][3].ToString();
                CultureInfo culture = new CultureInfo("en-US");
                DateTime tempDate = Convert.ToDateTime(date_Value, culture);
                dateTimePicker1.Value = tempDate;

                //වර්ගෙ තේරුව

                string gender = dtbl.Rows[0][4].ToString();
                
                if (gender == "Male")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete all from
            int Registration_Number;
            Registration_Number = int.Parse(comboBox1.Text);
            string query_del = "DELETE FROM Registration WHERE regNo ='" + Registration_Number + "' ";
            SqlCommand command = new SqlCommand(query_del, conn);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            //add all

            insert();
            comboBox1.Items.Clear();
            fillcombo();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //delete all with delete button

           

            string message = "Are you sure, Do you really want to Delete this Recod...? ";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int Registration_Number;
                Registration_Number = int.Parse(comboBox1.Text);
                string query_del = "DELETE FROM Registration WHERE regNo ='" + Registration_Number + "' ";
                SqlCommand command = new SqlCommand(query_del, conn);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
                comboBox1.Items.Clear();
                fillcombo();

                string message2 = "You have to fill all informations ";
                string title2 = "Close Window";
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                DialogResult result2 = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);



            }

            else
            {
                //

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Application.Restart();
        }
    }
}
