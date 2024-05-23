using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace zadanie
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turistyDataSet2.Туристы". При необходимости она может быть перемещена или удалена.
            this.туристыTableAdapter.Fill(this.turistyDataSet2.Туристы);
        }
        private void LoadData()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Turisty.mdb";
            conn.Open();
            OleDbDataAdapter sqlDa = new OleDbDataAdapter("SELECT * FROM Туристы ", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Family = Convert.ToString(this.textBox2.Text);
                int TouristID = int.Parse(this.textBox1.Text);
                conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Turisty.mdb";
                conn.Open();

                OleDbCommand myCommand = conn.CreateCommand();
                myCommand.CommandText =
                "UPDATE Туристы SET Фамилия = @Family WHERE [Код туриста] = @TouristID";
                myCommand.Parameters.Add("@Family", OleDbType.VarChar, 50);
                myCommand.Parameters["@Family"].Value = Family;
                myCommand.Parameters.Add("@TouristID", OleDbType.Integer, 4);
                myCommand.Parameters["@TouristID"].Value = TouristID;
                int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
                if (UspeshnoeIzmenenie != 0)
                {
                    MessageBox.Show("Изменения внесены", "Изменение записи");
                }
                else
                {
                    MessageBox.Show("Не удалось внести изменения", "Изменение записи");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int TouristID = int.Parse(this.tbID.Text);
                string Family = Convert.ToString(this.tbSur.Text);
                string FirstName = Convert.ToString(this.tbName.Text);
                string MiddleName = Convert.ToString(this.tbOtch.Text);
                conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Turisty.mdb";
                conn.Open();
                OleDbCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = "INSERT INTO " +
                "Туристы ([Код туриста], Фамилия, Имя, Отчество) " +
                "VALUES (@TouristID, @Family, @FirstName, @MiddleName)";
                myCommand.Parameters.Add("@TouristID", OleDbType.Integer, 4);
                myCommand.Parameters["@TouristID"].Value = TouristID;
                myCommand.Parameters.Add("@Family", OleDbType.VarChar, 50);
                myCommand.Parameters["@Family"].Value = Family;
                myCommand.Parameters.Add("@FirstName", OleDbType.VarChar, 50);
                myCommand.Parameters["@FirstName"].Value = FirstName;
                myCommand.Parameters.Add("@MiddleName", OleDbType.VarChar, 50);
                myCommand.Parameters["@MiddleName"].Value = MiddleName;
                int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
                if (UspeshnoeIzmenenie != 0)
                {
                    MessageBox.Show("Изменения внесены", "Изменение записи");
                }
                else
                {
MessageBox.Show("Не удалось внести изменения", "Изменение записи");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int TouristID = int.Parse(this.textBox3.Text);
                conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Turisty.mdb";
                conn.Open();
                OleDbCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = "DELETE FROM Туристы " +
                "WHERE [Код туриста] = @TouristID";
                myCommand.Parameters.Add("@TouristID", OleDbType.Integer, 4);
                myCommand.Parameters["@TouristID"].Value = TouristID;
                int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
                if (UspeshnoeIzmenenie != 0)
                {
                    MessageBox.Show("Изменения внесены", "Изменение записи");
                }
                else
                {
                  MessageBox.Show("Не удалось внести изменения", "Изменение записи");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            LoadData();
        }
    }
    
}
