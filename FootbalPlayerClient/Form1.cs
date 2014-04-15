using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FootbalPlayerClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceReference1.ServiceClient service = new ServiceReference1.ServiceClient();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewPlayer.DataSource = service.GetAll();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
