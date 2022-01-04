using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Shop_Management_System
{
    public partial class UserInterface : Form
    {
        ArrayList productList = new ArrayList();
        float inTotalPrice = 0.0f;
        float discount = 0.0f;
        public UserInterface()
        {
            InitializeComponent();
            comboLoad();
            comboLoadQuantity();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Product Name";
            dataGridView1.Columns[1].Name = " Price";
            dataGridView1.Columns[2].Name = "Product Quantity";
            dataGridView1.Columns[3].Name = "Total Price";
        }
        public void comboLoad()
        {
            try
            {
                string query = "select name from product";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-23HKVKR\\SQLEXPRESS;" +
                                           "database = Management;" +
                                             "integrated security = SSPI";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ArrayList arr = new ArrayList();

                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arr.Add(reader.GetString(0));
                    }
                    reader.NextResult();
                }
                cmbProduct.DataSource = arr;
                con.Close();
                cmbPview.DataSource = arr;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error on Combo");
            }


        }
        public void comboLoadQuantity()
        {
            //string product = cmbProduct.Text;
            //int availableQuantity = 0;
            //try
            //{
            //    string query = "select quantity from product where name='" + product + "';";
            //    SqlConnection con = new SqlConnection();
            //    con.ConnectionString = "data source = DESKTOP-BCHDK8B\\SQLEXPRESS;" +
            //                               "database = Management;" +
            //                                 "integrated security = SSPI";
            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = query;
            //    con.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    reader.NextResult();
            //    while (reader.Read())
            //    {
            //        availableQuantity = reader.GetInt32(0);
            //    }
            ArrayList arr = new ArrayList();
            //    Console.WriteLine(availableQuantity);
            for (int i = 1; i <= 10; i++)
            {
                arr.Add(i.ToString());

            }


            cmbQuantity.DataSource = arr;
            //con.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error on Combo");
            //}

        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
            f1.Closed += (s, args) => this.Close();
            f1.Show();
            this.Hide();
        }

        private void btnCreateCAccount_Click(object sender, EventArgs e)
        {
            int cPoint = 0;
            string cName = txtCName.Text;
            string cAddress = txtCAddress.Text;
            string cPhone = txtCPhone.Text;
            string query = "insert into customer(name, address, phone, point) values('" + cName + "','" + cAddress + "','" + cPhone + "'," + cPoint + ")";
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-23HKVKR\\SQLEXPRESS;" +
                                           "database = Management;" +
                                             "integrated security = SSPI";
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                Console.WriteLine("before open");
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customer Account created!");
                txtCName.ResetText();
                txtCAddress.ResetText();
                txtCPhone.ResetText();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create customer account!!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = cmbProduct.Text;
            string q = cmbQuantity.Text;
            int quantity = Convert.ToInt32(q);
            float price = 0.0f;
            float totalPrice = 0.0f;
            if (!updateQuantity(quantity, name))
            {
                //MessageBox.Show("");
            }
            else
            {
                try
                {
                    string query = "select price from product where name='" + name + "'";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-23HKVKR\\SQLEXPRESS;" +
                                               "database = Management;" +

                                               "integrated security = SSPI";
                    con.Open();
                    SqlCommand commmand = new SqlCommand(query, con);
                    SqlDataAdapter sda = new SqlDataAdapter(commmand);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    var dt = ds.Tables[0];
                    price = float.Parse(dt.Rows[0][0].ToString());

                    /*
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.HasRows)
                    {
                        Console.WriteLine("++++++++++++++++++++++++++++++++++");

                        while (reader.Read())
                        {
                            Console.WriteLine("------------");
                            price = float.Parse(reader.GetFloat(0));
                            Console.WriteLine(reader.GetFloat(0));
                        }
                        reader.NextResult();
                    }
                    */

                    totalPrice = price * quantity;
                    inTotalPrice += totalPrice;
                    txtInTotalPrice.Text = inTotalPrice.ToString();
                    Console.WriteLine(totalPrice + "  *********  " + price);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());//"Failed from reciept");
                }
                finally
                {
                    ProductReciept pr = new ProductReciept(name, quantity, price, totalPrice);
                    productList.Add(pr);
                    string[] row = new string[] { name, price.ToString(), q, totalPrice.ToString() };
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        public Boolean updateQuantity(int q,string name)
        {
            string product = name;

            //string product = cmbProduct.Text;
            // string q = cmbQuantity.Text;
            int selectedQuantity = q;//int.Parse(q);
           // int newQuantity = 0;
            int existingQuantity = 0;
            try
            {
                string query = "select quantity from product where name='" + product + "';";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-23HKVKR\\SQLEXPRESS;" +
                                           "database = Management;" +
                                             "integrated security = SSPI";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                var dt = ds.Tables[0];
                existingQuantity = int.Parse(dt.Rows[0][0].ToString());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error from getting existing quantity");
            }
            int totalQuantity = existingQuantity - selectedQuantity;
            if(totalQuantity<0)
            {
                MessageBox.Show("Existing Quantity : " + existingQuantity);
                return false;
            }
            else
            {
                try
                {
                    string query = "update product set quantity=" + totalQuantity + " where name='" + product + "';";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-23HKVKR\\SQLEXPRESS;" +
                                               "database = Management;" +
                                                 "integrated security = SSPI";
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                   // MessageBox.Show("Product Quantity Updated");
                    
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Unsuccessful , Quantity not updated!");
                }
                return true;
            }
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string p = txtPayment.Text;
            int payment = 0;
            if(p.Equals(""))
            {
                MessageBox.Show("Enter the amount");
            }
            else
            {
                try
                {
                    payment = int.Parse(p);
                    float returnAmount = payment - inTotalPrice;
                    if (returnAmount < 0)
                        MessageBox.Show("Enter sufficient amount!");
                    else
                    {
                        txtReturn.Text = (returnAmount).ToString();
                        txtPayment.Text = "";
                    }
                }
                catch(Exception ex)
                {
                    txtPayment.Text = "";
                    txtReturn.Text = "";
                    MessageBox.Show("Invalid amount entered");
                }        

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            inTotalPrice = 0;
            txtInTotalPrice.Text ="";
            txtPayment.Text = "";
            txtReturn.Text = "";
            txtPromo.Text = "";
            discount = 0.0f;

        }

        private void btnApplyPromo_Click(object sender, EventArgs e)
        {
            string promo = txtPromo.Text;
            string p = "";
            string query = "select percentage from promotable where promo='" + promo + "';";
            float percentage = 0.0f;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-23HKVKR\\SQLEXPRESS;" +
                                           "database = Management;" +
                                             "integrated security = SSPI";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        p = reader.GetString(0);
                    }
                    reader.NextResult();
                }
                percentage = (float.Parse(p) / 100.0f);
                discount=inTotalPrice * percentage;
                if (discount > 500)
                    discount = 500.0f;
                else
                {

                }
                con.Close();
                inTotalPrice -= discount;
                txtInTotalPrice.Text = inTotalPrice.ToString();
                query = "delete from promotable where promo='" + promo + "'";
                cmd.CommandText = query;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Promo!");
                txtPromo.Text = "";
            }

        }

        private void btnPView_Click(object sender, EventArgs e)
        {

        }

        private void bntAllpView_Click(object sender, EventArgs e)
        {

        }

        private void btnPView_Click_1(object sender, EventArgs e)
        {
            string product = cmbPview.Text;
            string query = "select name,price,quantity from product where name='" + product + "';";
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-23HKVKR\\SQLEXPRESS;" +
                                           "database = Management;" +
                                             "integrated security = SSPI";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                gridViewProduct.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful operation from view button");
            }
        }

        private void bntAllpView_Click_1(object sender, EventArgs e)
        {
            string query = "select name,price,quantity from product;";
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-23HKVKR\\SQLEXPRESS;" +
                                           "database = Management;" +
                                             "integrated security = SSPI";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                gridViewProduct.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed from All product load");
            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
    
}
