using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsRevisor.Client
{
    public class ItemClass
    {
        public int _id;
        public string _name;
        public int _count;
        public string _location;
        public ItemClass(int id, string name, int count, string location)
        {
            _id = id;
            _name = name;
            _count = count;
            _location = location;
        }
    }
}
