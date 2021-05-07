using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITNMock1.Models
{
    public class ITNStore
    {
        public int Id { get; set; }

        public string StoreName { get; set; }

        public string Location { get; set; }

        public string State { get; set; }

        public string LGA { get; set; }

        public string Address { get; set; }

        public string Latittude { get; set; }

        public string Longitude { get; set; }

        public string WarehouseLength { get; set; }

        public string WarehouseBreadth { get; set; }

        public string WarehouseHeight { get; set; }
    }
}
