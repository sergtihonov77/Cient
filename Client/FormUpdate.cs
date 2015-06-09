using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        //Добавление нового клиента при нажатии клавиши Add new client
        private void buttonAddCl_Click(object sender, EventArgs e)
        {
            int dep;
            if (textBoxNewName.Text != string.Empty && textBoxNewDep.Text != string.Empty && textBoxNewAddr.Text != string.Empty)
            {
                try
                {
                    dep = Int32.Parse(textBoxNewDep.Text);
                    ClientClass.Insert(textBoxNewName.Text.ToString(), textBoxNewAddr.Text.ToString(), dep);
                }
                catch
                {
                    MessageBox.Show("Input digit in field 'Client $' please!");
                }
                textBoxNewName.Text = "";
                textBoxNewAddr.Text = "";
                textBoxNewDep.Text = "";
            }
            else 
            {
                MessageBox.Show("Please fill in all the fields!");
            }

        }

        //Отмена добавления клиента при нажати клавиши Cancel
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
