using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class RoomInfo
    {
        public int RoomNumber { get; set; }
        public bool IsAvailable { get; set; }
        public string TenantName { get; set; } = "";
        public DateTime? DueDate { get; set; }   // ✅ added
        public bool IsNotified { get; set; }      // ✅ prevent spam alerts
        public int TotalCustomers { get; set; }
        public int Age { get; set; }

        public string ContactNumber { get; set; }

        public string Address { get; set; }

        public string ValidID { get; set; }
        public override string ToString()
        {
            return $"Room {RoomNumber} - {(IsAvailable ? "Available" : "Occupied")}";
        }
    }

}
