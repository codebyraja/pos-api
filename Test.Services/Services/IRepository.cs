using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Test.Services.DBContext;
using ES_POS_BUSY.Services.DBContext;

namespace Test.Services.Services
{
    public interface IRepository
    {
        public Task<dynamic> GetCustomerList();
        public Task<dynamic> ValidateUser(string UName, string PWD);
        //public Task<dynamic> ValidateUserName(string UserName);
        public Task<dynamic> SaveSubProductMaster(SubProductMast obj, int MasterType);
        public Task<dynamic> GetSubProductMasterList(int MasterType, int ProductId);
        public Task<dynamic> SaveProductMaster(ProductMast obj, int MasterType);
        public Task<dynamic> GetProductMasterList(int MasterType, int ProductId, int Category, int SubCategory, int Brand, double Price);
        public Task<dynamic> DeleteProdMast(int MasterType, int ProductId);
        public Task<dynamic> SaveUserMaster(SaveUserMast obj);
        public Task<dynamic> GetUserMasterList(int UserId);
        public Task<dynamic> DeleteUserMaster(int UserId);
        public Task<dynamic> SaveCustomerMaster(SaveCustomerMast obj);
        public Task<dynamic> GetCustomerMaster(int CustomerId, string? MobileNo);
        public Task<dynamic> DeleteCustMaster(int CustomerId);
        public Task<dynamic> SaveAddressMaster(AddressMast obj, int Mastertype);
        public Task<dynamic> GetAddressMaster(int Code, int Mastertype);
        public Task<dynamic> DeleteAddressMaster(int MasterType, int Code);
        public Task<dynamic> LoadStateName(int CountryCode);
        public Task<dynamic> LoadCityName(int CountryCode, int StateCode);
        public Task<dynamic> SaveGeneralSetting(GeneratSetting obj, int Mastertype);
        public Task<dynamic> GetGeneralSetting(int Mastertype);
        public Task<dynamic> ImportProductInBusy(int Mastertype);
        public Task<dynamic> SaveImportBusyProducts(BusyImportProduct obj, int Mastertype, int RecType);
    }
}