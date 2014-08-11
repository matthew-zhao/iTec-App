using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Test2.Resources
{
    //this class was made to assign items in the xml file for presets to a list
    class XMLClasses
    {
        [XmlRoot("root")]
        public class Items
        {
            [XmlArray("items")]
            [XmlArrayItem("item")]
            public ObservableCollection<Item> Collection { get; set; }
        }
        public class Item
        {
            [XmlElement("name")]
            public string itemName { get; set; }

            [XmlArray("lists")]
            [XmlArrayItem("list")]
            public ObservableCollection<List> listCollection { get; set; }
        }
        public class List
        {
            [XmlElement("listid")]
            public string listId { get; set; }

        }
    }
}
