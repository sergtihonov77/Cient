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

namespace Client
{
    public partial class ClientClass : Form
    {
        static SqlConnection Conn = new SqlConnection(@"Data Source=MYX-PC\SQLEXPRESS;Initial Catalog=Clients_DB;Integrated Security=True");
        string temp, tempName, tempNew;


        public ClientClass()
        {
            InitializeComponent();
        }



        
        //Обновление данных в таблице при нажатии клавиши Refresh Title
        private void Title_Click(object sender, EventArgs e)
        {
            Refresh(this.dataGridView1);
         }

        //Открывает форму создания нового клиента при нажатии клавиши Add new client
        private void ButtonAddClient_Click(object sender, EventArgs e)
        {
            FormUpdate fUp = new FormUpdate();
            fUp.Show();
        }
        
        //Фильтр по имени в таблице при нажатии клавиши Search
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Table_Cl]", Conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataView dv = new DataView(dt);
                dv.RowFilter = "Name LIKE '%"+textBoxSearch.Text+"%'";
                dv.ToTable();
                dataGridView1.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }


        } 

        //Подготовка к редактированию ячейки
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            temp = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            tempName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        //Редактирование ячейки
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tempNew = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                string query = "UPDATE [Table_Cl] SET Name=@NewName WHERE Name=@Name ";
                try
                {
                    Conn.Open();
                    SqlCommand sc = new SqlCommand(query, Conn);
                    sc.Parameters.AddWithValue("@Name", tempName);
                    sc.Parameters.AddWithValue("@NewName", tempNew);
                    sc.ExecuteNonQuery();
                    Conn.Close();
                    MessageBox.Show("Changes saved!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            if (e.ColumnIndex == 1)
            {
                string query = "UPDATE [Table_Cl] SET Address=@Address WHERE Name=@Name ";
                try
                {
                    Conn.Open();
                    SqlCommand sc = new SqlCommand(query, Conn);
                    sc.Parameters.AddWithValue("@Name", tempName);
                    sc.Parameters.AddWithValue("@Address", tempNew);
                    sc.ExecuteNonQuery();
                    Conn.Close();
                    MessageBox.Show("Changes saved!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            if (e.ColumnIndex == 2)
            {
                string query = "UPDATE [Table_Cl] SET Deposit=@Deposit WHERE Name=@Name ";
                try
                {
                    Conn.Open();
                    SqlCommand sc = new SqlCommand(query, Conn);
                    sc.Parameters.AddWithValue("@Name", tempName);
                    sc.Parameters.AddWithValue("@Deposit", tempNew);
                    sc.ExecuteNonQuery();
                    Conn.Close();
                    MessageBox.Show("Changes saved!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //Проверка на корректность ввода значение в поле Deposit
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int newInteger;
                if (!int.TryParse(e.FormattedValue.ToString(),
                    out newInteger) || newInteger < 0)
                {
                    e.Cancel = true;
                }
            }
        }

        //Оповещение удаления ячейки
        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("Client " + temp + " Deleted!");
        }

        //Удаление клиента
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("You realy want to delete this client?", "Important Query", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) 
            {
               e.Cancel = true;
            }
            else if (dr == DialogResult.Yes)
            {
                string query = "DELETE FROM [Table_Cl] WHERE Name=@Name";
                int ind;
                ind = Int32.Parse(e.Row.Index.ToString());
                temp = e.Row.DataGridView.Rows[ind].Cells["Name"].Value.ToString().TrimEnd();
                temp.Trim();
                MessageBox.Show(temp);
                try
                {
                    Conn.Open();
                    SqlCommand sc = new SqlCommand(query, Conn);
                    sc.Parameters.AddWithValue("@Name", temp);
                    sc.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conn.Close();
                }
            }
            
        }





        //Обновление данных в DataGridView
         public void Refresh(DataGridView dgv) {
             try
             {
                 Conn.Open();
                 SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Table_Cl]", Conn);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 dgv.DataSource = dt;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             finally 
             {
                 Conn.Close();
             }

        }

        //Добаление нового клиента в базу данных
         static public void Insert(string value1, string value2, int value3)
        {
            string query = "INSERT INTO [Table_Cl] (Name, Address, Deposit) VALUES (@Name, @Address, @Deposit)";
            try
            {

                Conn.Open();
                SqlCommand sc = new SqlCommand(query, Conn);
                sc.Parameters.AddWithValue("@Name", value1);
                sc.Parameters.AddWithValue("@Address", value2);
                sc.Parameters.AddWithValue("@Deposit", value3);
                sc.ExecuteNonQuery();
                MessageBox.Show("Client added in DataBase");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            
        }

       }
}
