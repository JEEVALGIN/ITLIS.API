using ITLIS.Models;
using ITLIS.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLIS.Service.Interface
{
    public interface IInventoryService
    {
        Task<ResultArgs> GetInventoryDetailsAsync();
        Task<ResultArgs> GetInventoryDetailsByIdAsync(int Id);
        Task<ResultArgs> DeleteInventoryDetailsByIdAsync(int Id);
        Task<ResultArgs> InsertInventoryDetailsAsync(InventoryDetailDTO Device);
        Task<ResultArgs> UpdateInventoryDetailsAsync(InventoryDetailDTO Device);
    }
}
