using Dapper;
using ITLIS.DBEngine;
using ITLIS.FrameWork;
using ITLIS.Models.Input;
using ITLIS.Models.Output;
using ITLIS.Repository.Interface;
using System.Data;

namespace ITLIS.Repository.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        IServerHandler serverHandler;
        public InventoryRepository(IServerHandler serverHandler)
        {
            this.serverHandler = serverHandler;
        }

        public async Task<int> DeleteInventoryDetailsByIdAsync(int Id)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add(DBParameter.InventoryDetails.DeviceId, Id, DbType.Int16);

                response = await serverHandler.ExecuteScalarAsync<int>(StroredProc.InventooryDetail.InventoryDeleteSP, dynamicParameters);

            }
            catch (Exception ex)
            {
            }

            return response;
        }

        public async Task<InventoryDetailResult> GetInventoryDetailsAsync()
        {
            InventoryDetailResult userDetailResult = new InventoryDetailResult();
            try
            {
                using (serverHandler.Connection)
                {
                    userDetailResult.inventoryList = (await serverHandler.QueryAsync<InventoryDetailDTO>(StroredProc.InventooryDetail.InventorySelectSP)).ToList();
                }
            }
            catch (Exception )
            {
            }
            return userDetailResult;
        }

        public async Task<InventoryDetailDTO> GetInventoryDetailsByIdAsync(int Id)
        {
            InventoryDetailDTO userDetail = new InventoryDetailDTO();
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add(DBParameter.InventoryDetails.DeviceId, Id, DbType.Int16);

                using (serverHandler.Connection)
                {
                    userDetail = (await serverHandler.QuerySingleAsync<InventoryDetailDTO>(StroredProc.InventooryDetail.InventorySelectByIdSP, dynamicParameters));
                }
            }
            catch (Exception )
            {
            }
            return userDetail;
        }

        public async Task<int> InsertDetailsAsync(InventoryDetailDTO Device)
        {
            int response = 0;
            {
                try
                {
                    DynamicParameters dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add(DBParameter.InventoryDetails.BrandName, Device.BrandName,DbType.String);
                    dynamicParameters.Add(DBParameter.InventoryDetails.ModelName, Device.ModelName, DbType.String);
                    dynamicParameters.Add(DBParameter.InventoryDetails.Ram, Device.Ram, DbType.String);
                    dynamicParameters.Add(DBParameter.InventoryDetails.Storage, Device.Storage, DbType.String);
                    dynamicParameters.Add(DBParameter.InventoryDetails.OS, Device.OS, DbType.String);
                    dynamicParameters.Add(DBParameter.InventoryDetails.PuechaseDate, Device.PuechaseDate, DbType.String);
                    dynamicParameters.Add(DBParameter.InventoryDetails.DeviceType, Device.DeviceType, DbType.String);
                    response = await serverHandler.ExecuteScalarAsync<int>(StroredProc.InventooryDetail.InventoryInsertSP, dynamicParameters);
                }
                catch(Exception )
                {

                }
            }
            return response;
        }

        public async Task<int> UpdateDetailsAsync(InventoryDetailDTO Device)
        {
            int response = 0;
            {
                try
                {

                    DynamicParameters dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add(DBParameter.InventoryDetails.DeviceId, Device.DeviceId, DbType.Int16);
                    dynamicParameters.Add(DBParameter.InventoryDetails.BrandName, Device.BrandName, DbType.String);
                    dynamicParameters.Add(DBParameter.InventoryDetails.ModelName, Device.ModelName, DbType.String);
                    dynamicParameters.Add(DBParameter.InventoryDetails.Ram, Device.Ram, DbType.String);
                    dynamicParameters.Add(DBParameter.InventoryDetails.Storage, Device.Storage, DbType.String);
                    dynamicParameters.Add(DBParameter.InventoryDetails.OS, Device.OS, DbType.String);
                    dynamicParameters.Add(DBParameter.InventoryDetails.PuechaseDate, Device.PuechaseDate, DbType.String);
                    dynamicParameters.Add(DBParameter.InventoryDetails.DeviceType, Device.DeviceType, DbType.String);
                    response = await serverHandler.ExecuteScalarAsync<int>(StroredProc.InventooryDetail.InventoryUpdateSP, dynamicParameters);
                }
                catch (Exception)
                {

                }
            }
            return response;
        }
    }
}