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
//MDSappSharedFunction; 

namespace MDSapp3
{
    public partial class Form1 : Form
    {
        t_Items model_t_Items = new t_Items(); // unit, price, amount , description
        t_ItemU_M model_t_ItemU_M = new t_ItemU_M(); // Kg, gram, etc ..

        t_Orders model_t_Orders = new t_Orders();


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
            populateDataGridViewItems();
            populateDataGridView_t_Orders();



        }


       //   U_M functions tab
       
        
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



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //  items  functions
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        void populateDataGridViewItems()
        {
            using (testDBEntities db = new testDBEntities())
            {

                //SortableBindingList<t_ItemU_M> va = db.t_ItemU_M.ToList<t_ItemU_M>();

                dataGridViewItems.DataSource = db.t_Items.ToList<t_Items>();
                List <t_ItemU_M> items_u_m = db.t_ItemU_M.ToList<t_ItemU_M>();
                comboBoxMeasuremntUnit.DataSource = items_u_m;
                comboBoxMeasuremntUnit.ValueMember = "ID";
                comboBoxMeasuremntUnit.DisplayMember = "ItemU_M";


                comboBoxItemsSorting.Items.Add("Order ID");
                comboBoxItemsSorting.Items.Add("Item Amount");
                comboBoxItemsSorting.Items.Add("Unit");
                comboBoxItemsSorting.Items.Add("Item Description");



            }
        }

        

        private void textBoxItemsAmount_TextChanged(object sender, EventArgs e)
            // check if text box is digit
        {

            //MDSHelperClass.MdsAppisDigit(textBoxItemsAmount);
            MDSHelperClass.MdsAppisFloat(textBoxItemsPrice);
        }

        

        private void textBoxItemsPrice_TextChanged(object sender, EventArgs e)
            // check if text box is float
        {
             MDSHelperClass.MdsAppisFloat(textBoxItemsPrice);

        }

        private void buttonItemsAdd_Click(object sender, EventArgs e)
        {
            model_t_Items.ItemAmount = Convert.ToDecimal(textBoxItemsAmount.Text.Trim());
            model_t_Items.ItemPrice = (decimal?)Convert.ToDouble(textBoxItemsPrice.Text.Trim());
            model_t_Items.ItemU_M = comboBoxMeasuremntUnit.Text.Trim();
            model_t_Items.ItemDescription = richTextBoxItemsDesc.Text.Trim();

            long r = MDSHelperClass.LongRandom(10, 100000000000000050, new Random());
            

            //MessageBox.Show(guid);

            model_t_Items.OrderID = r;  ;/// Convert.ToInt64(guid.ToString());

            using (testDBEntities db = new testDBEntities())
            {

                db.t_Items.Add(model_t_Items);
                db.SaveChanges();
                ClearDataGridView_t_ItemU_M();
                populateDataGridViewItems();

            }

        }

        void ClearDataGridView_t_Items()
        /* Clear text box in M_u tab  */
        {
            textBoxItemsAmount.Text = textBoxItemsPrice.Text = comboBoxMeasuremntUnit.Text= richTextBoxItemsDesc.Text =  "";
        }

        private void dataGridViewItems_DoubleClick(object sender, EventArgs e)
        // poplate text box when data grid being pressed
        {
            if (dataGridViewItems.CurrentRow.Index != -1)
            {
                model_t_Items.ID = Convert.ToInt32(dataGridViewItems.CurrentRow.Cells["ID"].Value);
                using (testDBEntities db = new testDBEntities())
                {
                    model_t_Items = db.t_Items.Where(x => x.ID == model_t_Items.ID).FirstOrDefault();
                    
                    textBoxItemsAmount.Text = model_t_Items.ItemAmount.ToString();
                    textBoxItemsPrice.Text = model_t_Items.ItemPrice.ToString();
                    comboBoxMeasuremntUnit.Text = model_t_Items.ItemU_M.ToString();
                    richTextBoxItemsDesc.Text = model_t_Items.ItemDescription.ToString();
                }

            }
        }

        private void buttonItemsEdit_Click(object sender, EventArgs e)
        {
            model_t_Items.ItemAmount = Convert.ToDecimal(textBoxItemsAmount.Text.Trim()) ;
            model_t_Items.ItemPrice= Convert.ToDecimal(textBoxItemsPrice.Text.Trim()); 
            model_t_Items.ItemU_M = comboBoxMeasuremntUnit.Text.Trim();
            model_t_Items.ItemDescription = richTextBoxItemsDesc.Text.Trim();

            using (testDBEntities db = new testDBEntities())
            {

                db.Entry(model_t_Items).State = EntityState.Modified;
                db.SaveChanges();
            }
            ClearDataGridView_t_Items();
            populateDataGridViewItems();
            MessageBox.Show("Submitted Successfully");
        }

        private void buttonIndexSearch_Click(object sender, EventArgs e)
        {

            //var ItemsAmount = Convert.ToDecimal(textBoxItemsAmount.Text.Trim()) ;
            //model_t_Items.ItemAmount = Convert.ToDecimal(textBoxItemsAmount.Text.Trim());

            // decimal va = (decimal)(decimal?)Convert.ToDouble(textBoxItemsAmount.Text.Trim());

            Boolean amoumt_empty = true;

            if (String.IsNullOrEmpty(textBoxItemsAmount.Text))
            {

            }
            else
            {
                model_t_Items.ItemAmount = Convert.ToDecimal(textBoxItemsAmount.Text.Trim());
                amoumt_empty = false;
                MessageBox.Show(model_t_Items.ItemAmount.ToString());


            }

            using (testDBEntities db = new testDBEntities())
            {
                //  dataGridViewItems.DataSource = db.t_Items.Where(x => x.ItemDescription.Contains(richTextBoxItemsDesc.Text.Trim()) &&
                //                                                  x.ItemAmount == 324).ToList<t_Items>(); 

                dataGridViewItems.DataSource = db.t_Items.Where(x => x.ItemDescription.Contains(richTextBoxItemsDesc.Text.Trim() )).ToList<t_Items>(); 

                // dgvFiltered.DataSource = gf.GroupTs.Where(x => x.G_Platform.Equals(platformCombo.Text) &&
                // x.G_Type.Equals(typeCombo.Text) && x.fieldNameCombo.Text <= how to do this

            }
        }



       

        private void buttonItemsCancel_Click(object sender, EventArgs e)
        {
            populateDataGridViewItems();
            ClearDataGridView_t_Items();
        }

        private void buttonItemsDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (testDBEntities db = new testDBEntities())
                {
                    var entry = db.Entry(model_t_ItemU_M);

                    if (entry.State == EntityState.Detached)
                        db.t_Items.Attach(model_t_Items);
                    db.t_Items.Remove(model_t_Items);
                    db.SaveChanges();
                    populateDataGridViewItems();
                    ClearDataGridView_t_Items();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void buttonItemAsc_Click(object sender, EventArgs e)
        {
            //model_t_Items. comboBoxItemsSorting.Text;
            using (testDBEntities db = new testDBEntities())
            {


                if (comboBoxItemsSorting.Text == "Order ID")
                {
                    dataGridViewItems.DataSource = db.t_Items.OrderBy(x => x.OrderID).ToList<t_Items>();

                }
                else if (comboBoxItemsSorting.Text == "Item Amount")
                {
                    dataGridViewItems.DataSource = db.t_Items.OrderBy(x => x.ItemAmount).ToList<t_Items>();
                }
                else if (comboBoxItemsSorting.Text == "Unit")
                {
                    dataGridViewItems.DataSource = db.t_Items.OrderBy(x => x.ItemU_M).ToList<t_Items>();
                }
                else if (comboBoxItemsSorting.Text == "Item Description")
                {
                    dataGridViewItems.DataSource = db.t_Items.OrderBy(x => x.ItemDescription).ToList<t_Items>();
                }
                else
                {
                    MessageBox.Show("choose Column to filter");
                }

            }
        }

        private void buttonItemsDesc_Click(object sender, EventArgs e)
        {
           // model_t_Items.ItemPrice
            using (testDBEntities db = new testDBEntities())
            {

                

                if  (comboBoxItemsSorting.Text == "Order ID")
                {
                    dataGridViewItems.DataSource = db.t_Items.OrderByDescending(x => x.OrderID).ToList<t_Items>();

                }else if(comboBoxItemsSorting.Text == "Item Amount")
                {
                    dataGridViewItems.DataSource = db.t_Items.OrderByDescending(x => x.ItemAmount).ToList<t_Items>();
                }
                else if (comboBoxItemsSorting.Text == "Unit")
                {
                    dataGridViewItems.DataSource = db.t_Items.OrderByDescending(x => x.ItemU_M).ToList<t_Items>();
                }
                else if (comboBoxItemsSorting.Text == "Item Description")
                {
                    dataGridViewItems.DataSource = db.t_Items.OrderByDescending(x => x.ItemDescription).ToList<t_Items>();
                }
                else
                {
                    MessageBox.Show("choose Column to filter");
                }

            }


        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //  orders  functions
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        void populateDataGridView_t_Orders()
        {
            using (testDBEntities db = new testDBEntities())
            {

                //SortableBindingList<t_ItemU_M> va = db.t_ItemU_M.ToList<t_ItemU_M>();

                dataGridViewOrders.DataSource = db.t_Orders.ToList<t_Orders>();


                comboBoxOrdersSorting.Items.Add("Order Number");
                comboBoxOrdersSorting.Items.Add("Customer Name");
                comboBoxOrdersSorting.Items.Add("Customer Phone");
                comboBoxOrdersSorting.Items.Add("Total Amount");
                comboBoxOrdersSorting.Items.Add("Refaund Amount");
                comboBoxOrdersSorting.Items.Add("Customer City");
                comboBoxOrdersSorting.Items.Add("Customer Adress");
                comboBoxOrdersSorting.Items.Add("Order Date");
                


            }
        }

        private void buttonOrdersAdd_Click(object sender, EventArgs e)
        {

            model_t_Orders.OrderDate = Convert.ToDateTime(dateTimePickerOrders.Text.Trim());
            model_t_Orders.CustomerName = textBoxOrders_CustName.Text.Trim();
            model_t_Orders.CustomerAddress = textBoxOrdersCust_Adress.Text.Trim();
            model_t_Orders.CustomerPhone = textBoxCustomerPhone.Text.Trim();
            model_t_Orders.TotalAmount = Convert.ToDecimal(textBoxOrdersToatl.Text.Trim());
            model_t_Orders.RefaundAmount = Convert.ToDecimal(textBoxRefaundAmount.Text.Trim());

            model_t_Orders.CustomerCity = textBoxOrdersCustomerCity.Text.Trim();

            long r = MDSHelperClass.LongRandom(10, 100000000000000050, new Random());


            //MessageBox.Show(textBoxOrdersCustomerCity.Text.Trim());

            model_t_Orders.OrderNumber = r.ToString(); ;/// Convert.ToInt64(guid.ToString());

            MessageBox.Show(model_t_Orders.OrderNumber.ToString());

            using (testDBEntities db = new testDBEntities())
            {

                db.t_Orders.Add(model_t_Orders);
                db.SaveChanges();
                ClearDataGridView_t_Orders();
                populateDataGridView_t_Orders();

            }
        }

       void ClearDataGridView_t_Orders()
        {
            textBoxRefaundAmount.Text = textBoxOrders_CustName.Text = textBoxOrdersCust_Adress.Text = textBoxCustomerPhone.Text = textBoxOrdersToatl.Text = "";
            textBoxOrdersCustomerCity.Text = "";
        }

        private void dataGridViewOrders_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow.Index != -1)
            {
                model_t_Orders.ID = Convert.ToInt32(dataGridViewOrders.CurrentRow.Cells["_ID"].Value);
                using (testDBEntities db = new testDBEntities())
                {
                    model_t_Orders = db.t_Orders.Where(x => x.ID == model_t_Orders.ID).FirstOrDefault();

                    textBoxRefaundAmount.Text = model_t_Orders.RefaundAmount.ToString(); 
                        textBoxOrders_CustName.Text = model_t_Orders.CustomerName;
                    textBoxOrdersCust_Adress.Text = model_t_Orders.CustomerAddress;
                    textBoxCustomerPhone.Text = model_t_Orders.CustomerPhone;
                        textBoxOrdersToatl.Text = model_t_Orders.TotalAmount.ToString();

                    dateTimePickerOrders.Text = model_t_Orders.OrderDate.ToString();
                    textBoxOrdersCustomerCity.Text = model_t_Orders.CustomerCity;




                }

            }
        }

        private void buttonOrdersDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (testDBEntities db = new testDBEntities())
                {
                    var entry = db.Entry(model_t_Orders);

                    if (entry.State == EntityState.Detached)
                        db.t_Orders.Attach(model_t_Orders);
                    db.t_Orders.Remove(model_t_Orders);
                    db.SaveChanges();
                    populateDataGridView_t_Orders();
                    ClearDataGridView_t_Orders();
                    MessageBox.Show("Deleted Successfully");
                }
            }


        }

        private void buttonOrdersEdit_Click(object sender, EventArgs e)
        {
            

            model_t_Orders.OrderDate = Convert.ToDateTime(dateTimePickerOrders.Text.Trim());
            model_t_Orders.CustomerName = textBoxOrders_CustName.Text.Trim();
            model_t_Orders.CustomerAddress = textBoxOrdersCust_Adress.Text.Trim();
            model_t_Orders.CustomerPhone = textBoxCustomerPhone.Text.Trim();
            model_t_Orders.TotalAmount = Convert.ToDecimal(textBoxOrdersToatl.Text.Trim());
            model_t_Orders.RefaundAmount = Convert.ToDecimal(textBoxRefaundAmount.Text.Trim());
            model_t_Orders.CustomerCity = textBoxOrdersCustomerCity.Text.Trim();

            using (testDBEntities db = new testDBEntities())
            {

                db.Entry(model_t_Orders).State = EntityState.Modified;
                db.SaveChanges();
            }
            populateDataGridView_t_Orders();
            ClearDataGridView_t_Orders();
            MessageBox.Show("Submitted Successfully");
        }

        private void buttonOrdersCancel_Click(object sender, EventArgs e)
        {
            populateDataGridView_t_Orders();
            ClearDataGridView_t_Orders();
        }

        private void buttonOrderAsc_Click(object sender, EventArgs e)
        {
            using (testDBEntities db = new testDBEntities())
            {
                if (comboBoxOrdersSorting.Text == "Order Date")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderBy(x => x.OrderDate).ToList<t_Orders>();

                }
                else if (comboBoxOrdersSorting.Text == "Customer Name")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderBy(x => x.CustomerName).ToList<t_Orders>();
                }
                else if (comboBoxOrdersSorting.Text == "Customer Adress")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderBy(x => x.CustomerAddress).ToList<t_Orders>();
                }
                else if (comboBoxOrdersSorting.Text == "Customer Phone")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderBy(x => x.CustomerPhone).ToList<t_Orders>();
                }
                else if (comboBoxOrdersSorting.Text == "Total Amount")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderBy(x => x.TotalAmount).ToList<t_Orders>();
                }
                else if (comboBoxOrdersSorting.Text == "Refaund Amount")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderBy(x => x.RefaundAmount).ToList<t_Orders>();
                }
                else if (comboBoxOrdersSorting.Text == "Customer City")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderBy(x => x.CustomerCity).ToList<t_Orders>();
                }
                else if (comboBoxOrdersSorting.Text == "Order Number")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderBy(x => x.OrderNumber).ToList<t_Orders>();
                }
                else
                {
                    MessageBox.Show("choose Column to filter");
                }

            }
        }

        private void buttonOrderDesc_Click(object sender, EventArgs e)
        {
            using (testDBEntities db = new testDBEntities())
            {
                if (comboBoxOrdersSorting.Text == "Order Date")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderByDescending(x => x.OrderDate).ToList<t_Orders>();

                }
                else if (comboBoxOrdersSorting.Text == "Customer Name")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderByDescending(x => x.CustomerName).ToList<t_Orders>();
                }
                else if (comboBoxOrdersSorting.Text == "Customer Adress")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderByDescending(x => x.CustomerAddress).ToList<t_Orders>();
                }
                else if (comboBoxOrdersSorting.Text == "Customer Phone")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderByDescending(x => x.CustomerPhone).ToList<t_Orders>();
                }
                else if (comboBoxOrdersSorting.Text == "Total Amount")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderByDescending(x => x.TotalAmount).ToList<t_Orders>();
                }
                else if (comboBoxOrdersSorting.Text == "Refaund Amount")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderByDescending(x => x.RefaundAmount).ToList<t_Orders>();
                }
                else if (comboBoxOrdersSorting.Text == "Customer City")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderByDescending(x => x.CustomerCity).ToList<t_Orders>();
                }
                else if (comboBoxOrdersSorting.Text == "Order Number")
                {
                    dataGridViewOrders.DataSource = db.t_Orders.OrderByDescending(x => x.OrderNumber).ToList<t_Orders>();
                }

                
                else
                {
                    MessageBox.Show("choose Column to filter");
                }

            }
        }
    }
}
