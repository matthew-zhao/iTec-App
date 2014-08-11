using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Xml.Serialization; //add referance
using System.Xml.Linq;//add referance

namespace Test2.Resources
{
    class XMLParser
    {
        private string _dataToParse;
        private static XMLParser _instance;
 
        private ObservableCollection<Item> _itemCollection;
 
        private XMLParser()
        {
 
        }
 
        public static XMLParser Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new XMLParser();
                }
                return _instance;
            }
        }
 
 
        public string DataToParse
        {
            get
            {
                return _dataToParse;
            }
            set
            {
                this._dataToParse = value;
            }
        }
 
        public ObservableCollection<Item> ItemCollection
        {
            get
            {
                return _itemCollection;
            }
            set
            {
                _itemCollection = value;
            }
        }
 
 
        public ObservableCollection<Item> ParseStateData()
        {
            try
            {
                XmlSerializer serlizer = new XmlSerializer(typeof(Item));
                XDocument document = XDocument.Parse(this._dataToParse);
 
                Item rootXML = (Item) serlizer.Deserialize(document.CreateReader());
 
                this._itemCollection = rootXML.Collection;
 
                return rootXML.Collection;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("ParseStateData()::" + ex.Message);
            }
 
            return null;
        }
    }
}

