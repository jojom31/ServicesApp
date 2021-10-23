using System;

namespace ServicesApp.Core
{
    public class Services
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        //public string Address { get; set; }
        //public string City{ get; set; }
        //public string State { get; set; }
        //public string ZipCode { get; set; }
        //public string Website { get; set;}


        //public Services()


        public Services()
        {
            this.Name = "Default";
            this.Type = "Default";
        }

        public Services(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        
        
    }

    
}
