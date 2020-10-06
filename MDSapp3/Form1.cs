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
using System.Data.SqlClient;

//MDSappSharedFunction; 

namespace MDSapp3
{
    public partial class Form1 : Form
    {
        t_Items model_t_Items = new t_Items(); // unit, price, amount , description
        t_ItemU_M model_t_ItemU_M = new t_ItemU_M(); // Kg, gram, etc ..

        t_Orders model_t_Orders = new t_Orders(); // order

        OrdersItem model_OrdersItem = new OrdersItem(); // order and item  shared table for item in order



        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //populateDataGridView_t_ItemU_M();
            ItemU_M_Helper um = new ItemU_M_Helper();
            um.ClearDataGridView_t_ItemU_M(textBox_ItemU_M);
            um.populateDataGridView_t_ItemU_M(dataGridView_U_M);
            populateDataGridViewItems();
            populateDataGridView_t_Orders();



        }

        //////////////////////
        //   U_M functions tab
        //////////////////////
        /// <summary>
        /// adding measurement unit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_U_M_Add_Click(object sender, EventArgs e)
        {

            ItemU_M_Helper um = new ItemU_M_Helper();
            um.addItemU_M(textBox_ItemU_M.Text.Trim(), textBox_ItemU_M, dataGridView_U_M);
        }

        /// <summary>
        /// del measurement unit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_U_M_Del_Click(object sender, EventArgs e)
        {
            ItemU_M_Helper um = new ItemU_M_Helper();
            um.Del_U_M_Record(model_t_ItemU_M, textBox_ItemU_M, dataGridView_U_M);
            
        }

        /// <summary>
        /// inserting values to textbox by clicking on datagris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// clearing textbox and reloading datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_U_M_Cancel_Click(object sender, EventArgs e)
        {
            ItemU_M_Helper um = new ItemU_M_Helper();
            um.ClearDataGridView_t_ItemU_M(textBox_ItemU_M);
            um.populateDataGridView_t_ItemU_M(dataGridView_U_M);
        }

        /// <summary>
        /// measurement unit editng , need double click on datagrid before to poplate text box's
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_U_M_Edit_Click(object sender, EventArgs e)
        {
            //ItemU_M_Helper um = new ItemU_M_Helper();
            //um.editItemU_M(textBox_ItemU_M.Text.Trim(), textBox_ItemU_M, dataGridView_U_M);

            model_t_ItemU_M.ItemU_M = textBox_ItemU_M.Text.Trim();
            using (testDBEntities db = new testDBEntities())
            {
                
                db.Entry(model_t_ItemU_M).State = EntityState.Modified;
                db.SaveChanges();
            }
            ItemU_M_Helper um = new ItemU_M_Helper();
            um.ClearDataGridView_t_ItemU_M(textBox_ItemU_M);
            um.populateDataGridView_t_ItemU_M(dataGridView_U_M);
            //ClearDataGridView_t_ItemU_M();
            //populateDataGridView_t_ItemU_M();
            MessageBox.Show("Submitted Successfully");
        }

        /// <summary>
        /// search measurement unit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_U_M_Search_Click(object sender, EventArgs e)
        {

            using (testDBEntities db = new testDBEntities())
            {

                dataGridView_U_M.DataSource = db.t_ItemU_M.Where(x => x.ItemU_M.Contains(textBox_ItemU_M.Text)).ToList<t_ItemU_M>();

            }
            
        }

        /// <summary>
        /// asc ordering of  measurement unit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_U_M_Asc_Click(object sender, EventArgs e)
        {
            //dv= "ID  desc";

            //dataGridView_U_M.Sort(dataGridView_U_M.Columns[1], ListSortDirection.Ascending);         putting error  -  why????
            using (testDBEntities db = new testDBEntities())
            {

                dataGridView_U_M.DataSource = db.t_ItemU_M.OrderBy(x => x.ItemU_M).ToList<t_ItemU_M>();

            }


        }

        /// <summary>
        /// desc ordering of  measurement unit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


                comboBoxItemsSorting.Items.Add("Items ID");
                comboBoxItemsSorting.Items.Add("Item Amount");
                comboBoxItemsSorting.Items.Add("Unit");
                comboBoxItemsSorting.Items.Add("Item Description");



            }
        }


        /// <summary>
        /// check if entering value is float
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxItemsAmount_TextChanged(object sender, EventArgs e)
            // check if text box is digit
        {

            //MDSHelperClass.MdsAppisDigit(textBoxItemsAmount);
            MDSHelperClass.MdsAppisFloat(textBoxItemsPrice);
        }

        
        /// <summary>
        /// check if entering value is float
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxItemsPrice_TextChanged(object sender, EventArgs e)
            // check if text box is float
        {
             MDSHelperClass.MdsAppisFloat(textBoxItemsPrice);

        }



        /// <summary>
        /// adding item to items table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItemsAdd_Click(object sender, EventArgs e)
        {
            model_t_Items.ItemAmount = Convert.ToDecimal(textBoxItemsAmount.Text.Trim());
            model_t_Items.ItemPrice = (decimal?)Convert.ToDouble(textBoxItemsPrice.Text.Trim());
            model_t_Items.ItemU_M = comboBoxMeasuremntUnit.Text.Trim();
            model_t_Items.ItemDescription = richTextBoxItemsDesc.Text.Trim();

            long r = MDSHelperClass.LongRandom(10, 100000000000000050, new Random());

            //MessageBox.Show(guid);

            //DbSet
            //DbSet dbs = (DbSet)model_t_Items;


            DbHelper dbh = new DbHelper();
            dbh.insertToDb();

            model_t_Items.ItemID = r;  ;/// Convert.ToInt64(guid.ToString());
            MessageBox.Show(model_t_Items.ItemID.ToString());
            using (testDBEntities db = new testDBEntities())
            {

                db.t_Items.Add(model_t_Items);
                db.SaveChanges();
                ClearDataGridView_t_Items();
                populateDataGridViewItems();

            }

        }

        /// <summary>
        /// clear data from items textbox
        /// </summary>
        void ClearDataGridView_t_Items()
        /* Clear text box in M_u tab  */
        {
            textBoxItemsAmount.Text = textBoxItemsPrice.Text = comboBoxMeasuremntUnit.Text= richTextBoxItemsDesc.Text =  "";
        }

        /// <summary>
        /// insering value to textbos depending on double click on datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// editng item on items  table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// search for items by diffrent fields depend on combobox val
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItemsSearch_Click(object sender, EventArgs e)
        {

          

            if (!String.IsNullOrEmpty(textBoxItemsAmount.Text))
            {
                model_t_Items.ItemAmount = Convert.ToDecimal(textBoxItemsAmount.Text.Trim());
               
            }

            if (!String.IsNullOrEmpty(textBoxItemsPrice.Text))
            {
                model_t_Items.ItemPrice = Convert.ToDecimal(textBoxItemsPrice.Text.Trim());
            }

            using (testDBEntities db = new testDBEntities())
            {
               
                dataGridViewItems.DataSource = db.t_Items
                                .Where(x => x.ItemAmount == model_t_Items.ItemAmount || x.ItemDescription.Contains(richTextBoxItemsDesc.Text.Trim())
                                || x.ItemPrice == model_t_Items.ItemPrice || x.ItemU_M.Equals(comboBoxMeasuremntUnit.Text.Trim()))
                                .ToList<t_Items>();
            }
        }



       
        /// <summary>
        /// clearing textbox;s and reloading datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItemsCancel_Click(object sender, EventArgs e)
        {
            populateDataGridViewItems();
            ClearDataGridView_t_Items();
        }


        /// <summary>
        /// delete item from db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Asc sorting of Items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItemAsc_Click(object sender, EventArgs e)
        {

            using (testDBEntities db = new testDBEntities())
            {


                if (comboBoxItemsSorting.Text == "Items ID")
                {
                    dataGridViewItems.DataSource = db.t_Items.OrderBy(x => x.ItemID).ToList<t_Items>();

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


        /// <summary>
        /// Items Desc by combo box value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItemsDesc_Click(object sender, EventArgs e)
        {
           // model_t_Items.ItemPrice
            using (testDBEntities db = new testDBEntities())
            {

                

                if  (comboBoxItemsSorting.Text == "Items ID")
                {
                    dataGridViewItems.DataSource = db.t_Items.OrderByDescending(x => x.ItemID).ToList<t_Items>();

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

                comboBoxOrdersSorting.Items.Clear();
                comboBoxOrdersSorting.Items.Add("Order Number");
                comboBoxOrdersSorting.Items.Add("Customer Name");
                comboBoxOrdersSorting.Items.Add("Customer Phone");
                comboBoxOrdersSorting.Items.Add("Total Amount");
                comboBoxOrdersSorting.Items.Add("Refaund Amount");
                comboBoxOrdersSorting.Items.Add("Customer City");
                comboBoxOrdersSorting.Items.Add("Customer Adress");
                comboBoxOrdersSorting.Items.Add("Order Date");


                comboBoxOrderItemsInAddOrderTab.Items.Clear();
                List<t_Items> all_t_Items = db.t_Items.ToList<t_Items>();

                foreach (t_Items item in all_t_Items)
                {
                    comboBoxOrderItemsInAddOrderTab.Items.Add(item.ItemDescription.Trim());
                }



                comboBoxOrderitemsInListDel.Items.Clear();
                List<OrdersItem> all_OrdersItems = db.OrdersItems.ToList<OrdersItem>();

                foreach (OrdersItem order_item in all_OrdersItems)
                {
                    comboBoxOrderitemsInListDel.Items.Add(order_item.t_Items.ItemDescription.Trim());
                }


            }
        }

        /// <summary>
        ///  saving new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrdersAdd_Click(object sender, EventArgs e)
        {

            model_t_Orders.OrderDate = Convert.ToDateTime(dateTimePickerOrders.Text.Trim());
            model_t_Orders.CustomerName = textBoxOrders_CustName.Text.Trim();
            model_t_Orders.CustomerAddress = textBoxOrdersCust_Adress.Text.Trim();
            model_t_Orders.CustomerPhone = textBoxCustomerPhone.Text.Trim();
            model_t_Orders.TotalAmount = 0; //Convert.ToDecimal(textBoxOrdersToatl.Text.Trim());
            model_t_Orders.RefaundAmount = Convert.ToDecimal(textBoxRefaundAmount.Text.Trim());

            model_t_Orders.CustomerCity = textBoxOrdersCustomerCity.Text.Trim();

            long r = MDSHelperClass.LongRandom(10, 100000000000000050, new Random());


            //MessageBox.Show(textBoxOrdersCustomerCity.Text.Trim());

            model_t_Orders.OrderNumber = r.ToString(); ;/// Convert.ToInt64(guid.ToString());

            //MessageBox.Show(model_t_Orders.OrderNumber.ToString());

            using (testDBEntities db = new testDBEntities())
            {

                db.t_Orders.Add(model_t_Orders);
                //MessageBox.Show(db.GetValidationErrors().ToString());
                //db.GetValidationErrors();
                //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [test].[dbo].[t_Orders] ON");
                db.SaveChanges();
                ClearDataGridView_t_Orders();
                populateDataGridView_t_Orders();

            }
        }

    /// <summary>
    /// clear textbox's
    /// </summary>
       void ClearDataGridView_t_Orders()
        {
            textBoxRefaundAmount.Text = textBoxOrders_CustName.Text = textBoxOrdersCust_Adress.Text = textBoxCustomerPhone.Text = textBoxOrdersToatl.Text = "";
            textBoxOrdersCustomerCity.Text = "";
        }

        /// <summary>
        /// insert data to textbox's by clicking on row of datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    textBoxOrderNumberInOrderTab.Text = model_t_Orders.OrderNumber;


                }

            }
        }


        /// <summary>
        /// del order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// editing order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrdersEdit_Click(object sender, EventArgs e)
        {
            

            model_t_Orders.OrderDate = Convert.ToDateTime(dateTimePickerOrders.Text.Trim());
            model_t_Orders.CustomerName = textBoxOrders_CustName.Text.Trim();
            model_t_Orders.CustomerAddress = textBoxOrdersCust_Adress.Text.Trim();
            model_t_Orders.CustomerPhone = textBoxCustomerPhone.Text.Trim();
            //model_t_Orders.TotalAmount = Convert.ToDecimal(textBoxOrdersToatl.Text.Trim());
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

        /// <summary>
        /// clearing datagris and text buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrdersCancel_Click(object sender, EventArgs e)
        {
            populateDataGridView_t_Orders();
            ClearDataGridView_t_Orders();
        }

        /// <summary>
        /// asc order by combobox value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// desc order by combobox value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// order search by diffrents fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrdersSearch_Click(object sender, EventArgs e)
        {



            if (!String.IsNullOrEmpty(textBoxRefaundAmount.Text))
            {
                model_t_Orders.RefaundAmount = Convert.ToDecimal(textBoxRefaundAmount.Text.Trim());

            }

            if (!String.IsNullOrEmpty(textBoxOrdersToatl.Text))
            {

                model_t_Orders.TotalAmount = Convert.ToDecimal(textBoxOrdersToatl.Text.Trim());
            }

            using (testDBEntities db = new testDBEntities())
            {
                //model_t_Orders.OrderDate = Convert.ToDateTime(dateTimePickerOrders.Text.Trim());
                model_t_Orders.CustomerName = textBoxOrders_CustName.Text.Trim();
                model_t_Orders.CustomerAddress = textBoxOrdersCust_Adress.Text.Trim();
                model_t_Orders.CustomerPhone = textBoxCustomerPhone.Text.Trim();
                
                model_t_Orders.CustomerCity = textBoxOrdersCustomerCity.Text.Trim();

                dataGridViewItems.DataSource = db.t_Orders
                                .Where(x => x.CustomerName.Contains(model_t_Orders.CustomerName) || x.CustomerAddress.Contains(textBoxOrdersCust_Adress.Text.Trim())
                                || (x.CustomerPhone.Contains(textBoxCustomerPhone.Text.Trim()) ) || (x.TotalAmount == model_t_Orders.TotalAmount)
                                || (x.RefaundAmount == model_t_Orders.RefaundAmount)  || x.CustomerCity.Contains(model_t_Orders.CustomerCity)
                                ).ToList<t_Orders>();
            }
        }

      
        /// <summary>
        /// updating table bu changing tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabPage_Order_Enter(object sender, EventArgs e)
        {
            populateDataGridView_t_Orders();
            ClearDataGridView_t_Orders();
            //MessageBox.Show("hello");
        }


        /// <summary>
        /// adding item to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrderItemsInOrderTab_Click(object sender, EventArgs e)
        {
            if (textBoxOrderNumberInOrderTab.Text == ""  || !(comboBoxOrderItemsInAddOrderTab.SelectedIndex > -1))
            {
                MessageBox.Show("please enter value by double click on the order \n Or choosing product");

            }
            else
            {
                using (testDBEntities db = new testDBEntities())
                {

                    t_Items item = db.t_Items.Where(x => x.ItemDescription.Equals(comboBoxOrderItemsInAddOrderTab.Text)).FirstOrDefault();
                    model_OrdersItem.t_Items = item;
                    t_Orders order= db.t_Orders.Where(x => x.ID == model_t_Orders.ID).FirstOrDefault();

                    long order_id = order.ID;

                    model_OrdersItem.t_Orders = order; 
                    db.OrdersItems.Add(model_OrdersItem);
                    db.SaveChanges();

                    evalTotalAmount(order_id);
                    ClearDataGridView_t_Orders();
                    populateDataGridView_t_Orders();
                    MessageBox.Show("Added Successfully");

                } 
            }
        }

        /// <summary>
        /// del item from order 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrderitemsInListDel_Click(object sender, EventArgs e)
        {
            if (textBoxOrderNumberInOrderTab.Text == "" || !(comboBoxOrderitemsInListDel.SelectedIndex > -1))
            {
                MessageBox.Show("please enter value by double click on the order \n Or choosing product");
                //dataGridViewOrders.DataSource = db.t_Orders.OrderByDescending(x => x.OrderDate).ToList<t_Orders>();

            }
            else
            {

                using (testDBEntities db = new testDBEntities())
                {

                    model_OrdersItem = db.OrdersItems.Where(x => x.t_Items.ItemDescription.Equals(comboBoxOrderitemsInListDel.Text)).FirstOrDefault();

                    long order_id = model_OrdersItem.t_Orders.ID;
                    var entry = db.Entry(model_OrdersItem);

                    if (entry.State == EntityState.Detached)
                        db.OrdersItems.Attach(model_OrdersItem);
                    db.OrdersItems.Remove(model_OrdersItem);
                    db.SaveChanges();

                    evalTotalAmount(order_id);

                    ClearDataGridView_t_Orders();
                    populateDataGridView_t_Orders();
                    MessageBox.Show("Deleted Successfully");


                }
            }
        }


        /// <summary>
        /// evaluting total amount in order after add/del item
        /// </summary>
        /// <param name="order_id"></param>
        private void evalTotalAmount(long order_id)
        {
            using (testDBEntities db = new testDBEntities())
            {
                //MessageBox.Show(m_order_item.t_Orders.ID.ToString());
                List<OrdersItem> all_OrdersItems = db.OrdersItems.Where(x => x.t_Orders.ID== order_id).ToList<OrdersItem>();

                decimal total = 0;
                foreach (OrdersItem order_item in all_OrdersItems)
                {
                    total += (decimal)order_item.t_Items.ItemPrice   ;
                }

                t_Orders order = db.t_Orders.Where(x => x.ID == order_id).FirstOrDefault();
                order.TotalAmount = total;

                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();


            }
        }
    }
}
