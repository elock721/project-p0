using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PizzaWorld.Domian.Models;

namespace PizzaWorld.Domian.Singletons
{
    public class ClientSingleton 
    {   
        private ClientSingleton _instance;

        public static ClientSingleton Instance 
        {
            get
            {
                if(_instance == null)
                {
                    _isntance = new ClientSingleton(); 
                }
                 return _instance; 
            }
        }

        public List<Store> Stores { get; set; }

        private ClientSingleton()
        {
            Stores = new List<Store>();
        }

        public void GetAllStores()
        {

        }

        public void MakeAStore()
        {
            var s = new Store();
            Stores.Add(s);
            Save();
        }

        private void Save()
        {   
            string path = @"./pizzaworld.xml";
            var file = new StreamWriter(path);
            var xml = new XmlSerializer(typeof(List<Store>));

            xml.Serialize(file, Stores); 
        }
    }
}