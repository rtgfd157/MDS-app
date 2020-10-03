using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

                //SortableBindingList<t_ItemU_M> va = db.t_ItemU_M.ToList<t_ItemU_M>();
                
                
                 dataGridView_U_M.DataSource = db.t_ItemU_M.ToList<t_ItemU_M>();

                

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateDataGridView_t_ItemU_M();

        }

        private void button_U_M_Add_Click(object sender, EventArgs e)
        {
            model_t_ItemU_M.ItemU_M = textBox_ItemU_M.Text.Trim();

            using (testDBEntities db = new testDBEntities())
            {
                
                db.t_ItemU_M.Add(model_t_ItemU_M);
                
                db.SaveChanges();
                ClearDataGridView_t_ItemU_M();
                populateDataGridView_t_ItemU_M();

            }

        }

        void ClearDataGridView_t_ItemU_M()
            /* Clear text box in M_u tab  */
        {
            textBox_ItemU_M.Text = "";
        }

        private void button_U_M_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (testDBEntities db = new testDBEntities())
                {
                    var entry = db.Entry(model_t_ItemU_M);

                    if (entry.State == EntityState.Detached)
                        db.t_ItemU_M.Attach(model_t_ItemU_M);
                    db.t_ItemU_M.Remove(model_t_ItemU_M);
                    db.SaveChanges();
                    populateDataGridView_t_ItemU_M();
                    ClearDataGridView_t_ItemU_M();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void dataGridView_U_M_DoubleClick(object sender, EventArgs e)
            // poplate text box when data grid being pressed
        {
            if (dataGridView_U_M.CurrentRow.Index != -1)
            {
                model_t_ItemU_M.ID = Convert.ToInt32(dataGridView_U_M.CurrentRow.Cells["M_U_ID"].Value);
                using (testDBEntities db = new testDBEntities())
                {
                    model_t_ItemU_M = db.t_ItemU_M.Where(x => x.ID == model_t_ItemU_M.ID).FirstOrDefault();
                    textBox_ItemU_M.Text = model_t_ItemU_M.ItemU_M;
                    
                }
                
            }
        }

        private void button_U_M_Cancel_Click(object sender, EventArgs e)
        {
            ClearDataGridView_t_ItemU_M();
            populateDataGridView_t_ItemU_M();

        }

        private void button_U_M_Edit_Click(object sender, EventArgs e)
        {
            model_t_ItemU_M.ItemU_M = textBox_ItemU_M.Text.Trim();
            using (testDBEntities db = new testDBEntities())
            {
                
                db.Entry(model_t_ItemU_M).State = EntityState.Modified;
                db.SaveChanges();
            }
            ClearDataGridView_t_ItemU_M();
            populateDataGridView_t_ItemU_M();
            MessageBox.Show("Submitted Successfully");
        }

        private void button_U_M_Search_Click(object sender, EventArgs e)
        {

            using (testDBEntities db = new testDBEntities())
            {

                dataGridView_U_M.DataSource = db.t_ItemU_M.Where(x => x.ItemU_M.Contains(textBox_ItemU_M.Text)).ToList<t_ItemU_M>();

            }
            
        }

        private void button_U_M_Asc_Click(object sender, EventArgs e)
        {
            //dv= "ID  desc";

            //dataGridView_U_M.Sort(dataGridView_U_M.Columns[1], ListSortDirection.Ascending);         putting error  -  why????
            using (testDBEntities db = new testDBEntities())
            {

                dataGridView_U_M.DataSource = db.t_ItemU_M.OrderBy(x => x.ItemU_M).ToList<t_ItemU_M>();

            }


        }

        private void button_U_M_Desc_Click(object sender, EventArgs e)
        {
            using (testDBEntities db = new testDBEntities())
            {
                dataGridView_U_M.DataSource = db.t_ItemU_M.OrderByDescending(x => x.ItemU_M).ToList<t_ItemU_M>();

            }
        }
    }
}
