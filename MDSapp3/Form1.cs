using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDSapp3
{
    public partial class Form1 : Form
    {
        t_Items model_t_Items = new t_Items();
        t_ItemU_M model_t_ItemU_M = new t_ItemU_M(); // Kg, gram, etc ..


        public Form1()
        {
            InitializeComponent();
        }

        void populateDataGridView_t_ItemU_M()
        {
            using (testDBEntities db = new testDBEntities() )
            {
                dataGridView_U_M.DataSource = db.t_ItemU_M.ToList<t_ItemU_M>();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateDataGridView_t_ItemU_M();

        }
    }
}
