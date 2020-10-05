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
using System.Linq.Dynamic;
using MDSAppSharedFunction;
namespace MDSapp3
{
    public  class ItemU_M_Helper
    {
        t_ItemU_M model_t_ItemU_M = new t_ItemU_M(); // Kg, gram, etc ..

        public  void addItemU_M(string itemU_M, TextBox textBox_ItemU_M, DataGridView dataGridView_U_M)
        {
            model_t_ItemU_M.ItemU_M = itemU_M;

            using (testDBEntities db = new testDBEntities())
            {

                db.t_ItemU_M.Add(model_t_ItemU_M);
                db.SaveChanges();
                ClearDataGridView_t_ItemU_M(textBox_ItemU_M);
                populateDataGridView_t_ItemU_M(dataGridView_U_M);

            }

        }

        public void ClearDataGridView_t_ItemU_M(TextBox textBox_ItemU_M)
        /* Clear text box in M_u tab  */
        {
            textBox_ItemU_M.Text = "";
        }

        public void populateDataGridView_t_ItemU_M(DataGridView dataGridView_U_M)
        {
            using (testDBEntities db = new testDBEntities())
            {

                //SortableBindingList<t_ItemU_M> va = db.t_ItemU_M.ToList<t_ItemU_M>();

                dataGridView_U_M.DataSource = db.t_ItemU_M.ToList<t_ItemU_M>();

            }
        }


        public void Del_U_M_Record(t_ItemU_M model_t_ItemU_M, TextBox textBox_ItemU_M, DataGridView dataGridView_U_M)
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
                    ClearDataGridView_t_ItemU_M(textBox_ItemU_M);
                    populateDataGridView_t_ItemU_M(dataGridView_U_M);
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }


        public void editItemU_M(string itemU_M, TextBox textBox_ItemU_M, DataGridView dataGridView_U_M)
        {
            
            model_t_ItemU_M.ItemU_M = itemU_M;
            using (testDBEntities db = new testDBEntities())
            {

                db.Entry(model_t_ItemU_M).State = EntityState.Modified;
                db.SaveChanges();
            }
            ClearDataGridView_t_ItemU_M(textBox_ItemU_M);
            populateDataGridView_t_ItemU_M(dataGridView_U_M);
            MessageBox.Show("Submitted Successfully");

        }
    }
}
