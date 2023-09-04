using ITLIS.Models.Input;

namespace ITLIS.Models.Output
{
    public class InventoryDetailResult
    {
        public InventoryDetailDTO? inventoryDetail { get; set; }

        public List<InventoryDetailDTO>? inventoryList { get; set; }
    }
}