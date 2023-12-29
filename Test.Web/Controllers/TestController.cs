using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Test.Services.DBContext;
using Test.Services.Services;
using System.Security.Cryptography.Xml;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Busy2184;
using ES_POS_BUSY.Services.DBContext;

namespace Test.Web.Controllers
{
    //https://localhost:1234/api/test
    [EnableCors("CorsPolicy")]
    [Route("api/[action]")]
    [ApiController]

    public class TestController : ControllerBase
    {
        public readonly IRepository _service;

        public TestController(IRepository service)
        {

            this._service = service;
        }

        [HttpGet("{Username}/{Password}")]
        public async Task<IActionResult> ValidateUser(string Username, string Password)
        {
            return Ok(await _service.ValidateUser(Username, Password));
        }

        [HttpPost]
        public async Task<IActionResult> SaveSubProductMaster(SubProductMast obj, int MasterType)
        {
            return Ok(await _service.SaveSubProductMaster(obj, MasterType));
        }

        [HttpGet]
        public async Task<IActionResult> GetSubProductMasterList(int MasterType, int ProductId)
        {
            return Ok(await _service.GetSubProductMasterList(MasterType, ProductId));
        }

        [HttpPost]
        public async Task<IActionResult> SaveProductMaster(ProductMast obj, int MasterType)
        {
            return Ok(await _service.SaveProductMaster(obj, MasterType));
        }

        [HttpGet]
        public async Task<IActionResult> GetProductMasterList(int MasterType, int ProductId, int Category, int SubCategory, int Brand, double Price)
        {
            return Ok(await _service.GetProductMasterList(MasterType, ProductId, Category, SubCategory, Brand, Price));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductMast(int MasterType, int ProductId)
        {
            return Ok(await _service.DeleteProdMast(MasterType, ProductId));
        }

        [HttpPost]
        public async Task<IActionResult> SaveUserMaster(SaveUserMast obj)
        {
            return Ok(await _service.SaveUserMaster(obj));
        }

        [HttpGet]
        public async Task<IActionResult> GetUserMasterList(int UserId)
        {
            return Ok(await _service.GetUserMasterList(UserId));
        }

        [HttpDelete("{UserId:int}")]
        public async Task<IActionResult> DeleteUserMast(int UserId)
        {
            return Ok(await _service.DeleteUserMaster(UserId));
        }

        [HttpPost]
        public async Task<IActionResult> SaveCustomerMast(SaveCustomerMast obj)
        {
            return Ok(await _service.SaveCustomerMaster(obj));
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomerMast(int CustomerId, string? MobileNo)
        {
            return Ok(await _service.GetCustomerMaster(CustomerId, MobileNo));
        }

        [HttpDelete("{CustId:int}")]
        public async Task<IActionResult> DeleteCustomerMast(int CustId)
        {
            return Ok(await _service.DeleteCustMaster(CustId));
        }

        [HttpPost("{MasterType:int}")]
        public async Task<IActionResult> SaveAddressMast(AddressMast obj, int MasterType)
        {
            return Ok(await _service.SaveAddressMaster(obj, MasterType));
        }

        [HttpGet("{MasterType:int}")]
        public async Task<IActionResult> GetAddressMast(int Code, int MasterType)
        {
            return Ok(await _service.GetAddressMaster(Code, MasterType));
        }

        [HttpDelete("{Code:int}")]
        public async Task<IActionResult> DeleteAddreddMast(int MasterType, int Code)
        {
            return Ok(await _service.DeleteAddressMaster(MasterType, Code));
        }

        [HttpGet("{CountryCode:int}")]
        public async Task<IActionResult> GetStateName(int CountryCode)
        {
            return Ok(await _service.LoadStateName(CountryCode));
        }

        [HttpGet("{Country:int}/{State:int}")]
        public async Task<IActionResult> GetCityName(int Country, int State)
        {
            return Ok(await _service.LoadCityName(Country, State));
        }

        [HttpPost("{Mastertype:int}")]
        public async Task<IActionResult> SaveGeneralSetting(GeneratSetting obj, int Mastertype)
        {
            return Ok(await _service.SaveGeneralSetting(obj, Mastertype));
        }

        [HttpGet("{Mastertype:int}")]
        public async Task<IActionResult> GetGeneralSetting(int Mastertype)
        {
            return Ok( await _service.GetGeneralSetting(Mastertype));
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomerName()
        {
            return Ok(await _service.GetCustomerList());
        }

        [HttpGet("{Mastertype:int}")]
        public async Task<IActionResult> ImportProductInBusy(int Mastertype)
        {
            return Ok(await _service.ImportProductInBusy(Mastertype));
        }

        [HttpPost("{MasterType:int}/{RecType:int}")]
        public async Task<IActionResult> SaveImportProductInBusy(BusyImportProduct obj, int MasterType, int RecType)
        {
            return Ok( await _service.SaveImportBusyProducts(obj, MasterType, RecType));
        }
    }
}
