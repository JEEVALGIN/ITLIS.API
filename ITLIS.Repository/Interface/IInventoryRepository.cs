using ITLIS.Models.Input;
using ITLIS.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLIS.Repository.Interface
{
    public interface IInventoryRepository
    {
        Task<InventoryDetailResult> GetInventoryDetailsAsync();
        Task<InventoryDetailDTO> GetInventoryDetailsByIdAsync(int Id);
        Task<int> DeleteInventoryDetailsByIdAsync(int Id);
        Task<int> InsertDetailsAsync(InventoryDetailDTO Device);
        Task<int> UpdateDetailsAsync(InventoryDetailDTO Device);
    }

}
