using ITLIS.FrameWork;
using ITLIS.Models;
using ITLIS.Models.Input;
using ITLIS.Models.Output;
using ITLIS.Repository.Interface;
using ITLIS.Service.Interface;

namespace ITLIS.Service.Service
{
    public class InventoryService: IInventoryService
    {
        IInventoryRepository _Repository;
        public InventoryService(IInventoryRepository inventoryRepository)
        {
            _Repository = inventoryRepository;
        }

        public async Task<ResultArgs> DeleteInventoryDetailsByIdAsync(int Id)
        {
            ResultArgs resultArgs = new ResultArgs();

            int result = await _Repository.DeleteInventoryDetailsByIdAsync(Id);
            if (result == 0)
            {
                
                resultArgs.StatusCode = MessageCatalog.ErrorCodes.Success;
                resultArgs.StatusMessage = MessageCatalog.ErrorMessages.Success;
                resultArgs.MessageTitle = MessageCatalog.MessageTitle.InventoryDetails;
            }
            else
            {

                resultArgs.StatusCode = MessageCatalog.ErrorCodes.BadRequest;
                resultArgs.StatusMessage = MessageCatalog.ErrorMessages.BadRequest;
            }
            return resultArgs;
        }

        public async Task<ResultArgs> GetInventoryDetailsAsync()
        {
            ResultArgs resultArgs = new ResultArgs();
            InventoryDetailResult obj = await _Repository.GetInventoryDetailsAsync();
           


            if (obj != null)
            {
                resultArgs.StatusCode = MessageCatalog.ErrorCodes.Success;
                resultArgs.StatusMessage = MessageCatalog.ErrorMessages.Success;
                resultArgs.MessageTitle = MessageCatalog.MessageTitle.InventoryDetails;
                resultArgs.ResultData = obj.inventoryList;

            }
            else
            {
                resultArgs.StatusCode = MessageCatalog.ErrorCodes.BadRequest;
                resultArgs.StatusMessage = MessageCatalog.ErrorMessages.BadRequest;
            }
            return resultArgs;
        }

        public  async Task<ResultArgs> GetInventoryDetailsByIdAsync(int Id)
        {
            ResultArgs resultArgs = new ResultArgs();

            InventoryDetailDTO obj = await _Repository.GetInventoryDetailsByIdAsync(Id);
            if (obj != null)
            {
                resultArgs.StatusCode = MessageCatalog.ErrorCodes.Success;
                resultArgs.StatusMessage = MessageCatalog.ErrorMessages.Success;
                resultArgs.MessageTitle = MessageCatalog.MessageTitle.InventoryDetails;
                resultArgs.ResultData = obj;


            }
            else
            {
                resultArgs.StatusCode = MessageCatalog.ErrorCodes.BadRequest;
                resultArgs.StatusMessage = MessageCatalog.ErrorMessages.BadRequest;
            }
            return resultArgs;
        }

        public async Task<ResultArgs> InsertInventoryDetailsAsync(InventoryDetailDTO Device)
        {

            ResultArgs resultArgs = new ResultArgs();

            int result = await _Repository.InsertDetailsAsync(Device);
            if (result == 0)
            {
                resultArgs.StatusCode = MessageCatalog.ErrorCodes.Success;
                resultArgs.StatusMessage = MessageCatalog.ErrorMessages.Success;
                resultArgs.MessageTitle = MessageCatalog.MessageTitle.InventoryDetails;
            }
            else
            {
                resultArgs.StatusCode = MessageCatalog.ErrorCodes.BadRequest;
                resultArgs.StatusMessage = MessageCatalog.ErrorMessages.BadRequest;
            }
            return resultArgs;
        }

        public async Task<ResultArgs> UpdateInventoryDetailsAsync(InventoryDetailDTO Device)
        {
            ResultArgs resultArgs = new ResultArgs();

            int result = await _Repository.UpdateDetailsAsync(Device);
            if (result == 0)
            {

                resultArgs.StatusCode = MessageCatalog.ErrorCodes.Success;
                resultArgs.StatusMessage = MessageCatalog.ErrorMessages.Success;
                resultArgs.MessageTitle = MessageCatalog.MessageTitle.InventoryDetails;
            }
            else
            {

                resultArgs.StatusCode = MessageCatalog.ErrorCodes.BadRequest;
                resultArgs.StatusMessage = MessageCatalog.ErrorMessages.BadRequest;
            }
            return resultArgs;
        }
    }
}