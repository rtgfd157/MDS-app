using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDSapp3
{
    public class DbHelper: IDbHelper
    {
        t_Items model_t_Items = new t_Items(); // unit, price, amount , description
        t_ItemU_M model_t_ItemU_M = new t_ItemU_M(); // Kg, gram, etc ..

        t_Orders model_t_Orders = new t_Orders();

        OrdersItem model_OrdersItem = new OrdersItem();


        public DbHelper()
        {
            //t_Items model_t_Items_in
            //this.model_t_Items = model_t_Items_in;
        }

        public void insertToDb()
        {



        }


    }
}
