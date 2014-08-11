using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Item
    {
        private int itemID;
        private String itemName;
        private String itemLoc;
        private double quantity;
        private DateTime timeSinceOrigin; //maybe use DateTimeOffset?
        private double price;
        private String status; //make this a boolean?
        private List<int> listNums;
        //private double bought; -> do we require this?

        public Item()
        {
            
        }
        public Item(int itemID, String itemName, String itemLoc, double quantity, DateTime timeSinceOrigin, double price, String status)
        {
            itemID = this.itemID;
            itemName = this.itemName;
            itemLoc = this.itemLoc;
            quantity = this.quantity;
            timeSinceOrigin = this.timeSinceOrigin;
            price = this.price;
            status = this.status;
        }

        public Item(int itemID, String itemName, List<int> listNums)
        {
            itemID = this.itemID;
            itemName = this.itemName;
            listNums = this.listNums;  
        }
        public ObservableCollection<Item> Collection { get; set; }
        public int ItemID
        {
            get { return itemID; }
            set
            {
                if (itemID != value)
                {
                    itemID = value;
                }
            }
        }
        public String ItemName
        {
            get { return itemName; }
            set
            {
                if (itemName != value)
                {
                    itemName = value;
                }
            }
        }

        public String ItemLoc
        {
            get { return itemLoc; }
            set
            {
                if (itemLoc != value)
                {
                    itemLoc = value;
                }
            }
        }

        public double Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                }
            }
        }

        public DateTime TimeSinceOrigin
        {
            get { return timeSinceOrigin; }
            set
            {
                if (timeSinceOrigin != value) //correct boolean operator?
                {
                    timeSinceOrigin= value;
                }
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                }
            }
        }

        public String Status
        {
            get { return status; }
            set
            {
                if (status != value)
                {
                    status = value;
                }
            }
        }
    }
}
