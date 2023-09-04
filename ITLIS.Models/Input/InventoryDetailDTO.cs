using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLIS.Models.Input
{
    public class InventoryDetailDTO
    {
        public int DeviceId { get; set; } 
        public string? BrandName { get; set; }
        public string? ModelName { get; set; }
        public string? Ram { get; set; }
        public string? Storage { get; set; }
        public string? OS { get; set; }
        public string? PuechaseDate { get; set; }
        public string? DeviceType { get; set; }
    }
}