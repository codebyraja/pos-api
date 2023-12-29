using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlTypes;
using System.Xml.Resolvers;
using static System.Net.Mime.MediaTypeNames;
using System.Buffers.Text;
using System.Collections;
using Microsoft.Extensions.Logging;
using System.Reflection;
using Test.Services.DBContext;
using ES_POS_BUSY.Services.DBContext;

namespace Test.Services.Services
{
    public class Repository : IRepository
    {

        public readonly TestDBContext _db;

        public readonly BusyDBContext _busyDb;
        public Repository(TestDBContext db, BusyDBContext busyDB)
        {
            this._db = db;
            this._busyDb = busyDB;
        }

        //------------------------ Interface --------------------------------//
        public async Task<dynamic> GetCustomerList()
        {
            List<CustomerDetails> CList = new List<CustomerDetails>();
            try
            {
                string sql = "";
                sql = "select Top 100 Code,Name from Master1";
                CList = await _busyDb.CustomersDetails.FromSqlRaw(sql).ToListAsync();
            }
            catch (Exception ex)
            {
                return new { Status = 0, Msg = ex.Message.ToString() };
            }
            return new { Status = 1, Msg = "Success", Data = CList };
        }
        public async Task<dynamic> ValidateUser(string UName, string PWD)
        {
            UserValidate USData = new UserValidate ();
            int Status = 0;
            string StatusStr = "";
            try
            {
                string sql = "";
                sql = "Select A.[UserId],A.[Usertype],A.[Admin],A.[Name],A.[FName],A.[LName],A.[Email],A.[Mobile],A.[Active],IsNull(B.[Base64], '') as Images From UserMaster A Left Join UserAttachDT B On A.UserId = B.UserId And B.UserType = 1 Where A.[UserName] = '" + UName + "' And A.PWD = '" + PWD + "' ";
               
                var DT = await _db.UserValidates.FromSqlRaw(sql).ToListAsync();

                if(DT.Count > 0)
                {
                    if (DT[0].Active == 1)
                    {
                        Status = 1;
                        StatusStr = "Valid";
                    }
                    else
                    {
                        Status = 0;
                        StatusStr = "Inactive User";
                    }

                    if (DT[0].Active == 1)
                    {
                        USData.Name = DT[0].Name;
                        USData.FName = DT[0].FName;
                        USData.LName = DT[0].LName;
                        USData.Email = DT[0].Email;
                        USData.Mobile = DT[0].Mobile;
                        USData.Admin = DT[0].Admin;
                        USData.UserId = DT[0].UserId;
                        USData.Usertype = DT[0].Usertype;
                        USData.Active = DT[0].Active;
                        USData.Images = DT[0].Images;
                    }
                }
                else
                {
                    Status = 0;
                    StatusStr = "Invalid User";
                }
            }
            catch (Exception ex)
            {
                return new { Status = 0, Msg = ex.Message.ToString() };
            }
            return new { Status = Status, Msg = StatusStr, Data = USData } ;
        }
        public async Task<dynamic> SaveSubProductMaster(SubProductMast obj, int MasterType)
        {

            int Status = 0;
            string StatusStr = "";
            try
            {
                DateTime CDateTime = DateTime.Now;
                string XML = POShelper.CreateXML(obj.ProductImages);

                SqlParameter param0 = new SqlParameter("@p0", obj.Id);
                SqlParameter param1 = new SqlParameter("@p1", obj.Name);
                SqlParameter param2 = new SqlParameter("@p2", obj.Alias);
                SqlParameter param3 = new SqlParameter("@p3", obj.ParentGrp);
                SqlParameter param4 = new SqlParameter("@p4", obj.Desc);
                SqlParameter param5 = new SqlParameter("@p5", obj.Doc);
                SqlParameter param6 = new SqlParameter("@p6", obj.Users);
                SqlParameter param7 = new SqlParameter("@p7", CDateTime);
                SqlParameter param8 = new SqlParameter("@p8", MasterType);
                SqlParameter param9 = new SqlParameter("@p9", XML.ToString());

                var DT = await _db.Responses.FromSqlRaw("EXEC [SP_CreateSubProductMaster] @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9", param0, param1, param2, param3, param4, param5, param6, param7, param8, param9).ToListAsync();

                Status = DT[0].Status;
                StatusStr = DT[0].Msg;
            }
            catch (Exception EX)
            {
                return new { Status = 0, Msg = EX.Message.ToString() };
            }
            return new { Status = Status, Msg = StatusStr };
        }
        public async Task<dynamic> SaveProductMaster(ProductMast obj, int MasterType)
        {
            int Status = 0;
            string StatusStr = "";
            try
            {
                DateTime CurDT = DateTime.Now;
                string XML = POShelper.CreateXML(obj.ProductImages);

                SqlParameter param0 = new SqlParameter("@p0", obj.Id);
                SqlParameter param1 = new SqlParameter("@p1", obj.Name);
                SqlParameter param2 = new SqlParameter("@p2", obj.Category);
                SqlParameter param3 = new SqlParameter("@p3", obj.SubCategory);
                SqlParameter param4 = new SqlParameter("@p4", obj.Brand);
                SqlParameter param5 = new SqlParameter("@p5", obj.Unit);
                SqlParameter param6 = new SqlParameter("@p6", obj.SKU);
                SqlParameter param7 = new SqlParameter("@p7", obj.MinQty);
                SqlParameter param8 = new SqlParameter("@p8", obj.Qty);
                SqlParameter param9 = new SqlParameter("@p9", obj.Price);
                SqlParameter param10 = new SqlParameter("@p10", obj.Desc);
                SqlParameter param11 = new SqlParameter("@p11", obj.Tax);
                SqlParameter param12 = new SqlParameter("@p12", obj.DiscType);
                SqlParameter param13 = new SqlParameter("@p13", obj.Status);
                SqlParameter param14 = new SqlParameter("@p14", obj.Doc);
                SqlParameter param15 = new SqlParameter("@p15", obj.Users);
                SqlParameter param16 = new SqlParameter("@p16", CurDT);
                SqlParameter param17 = new SqlParameter("@P17", MasterType);
                SqlParameter param18 = new SqlParameter("@P18", XML.ToString());


                var DT = await _db.Responses.FromSqlRaw("EXEC [SP_CreateProductMaster] @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13,@p14, @p15, @p16, @p17, @p18", param0, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18).ToListAsync();
                
                Status = DT[0].Status;
                StatusStr = DT[0].Msg;
            }
            catch (Exception ex)
            {
                return new { Status = 0, Msg = ex.Message.ToString() };
            }
            return new { Status = Status, Msg = StatusStr };
        }
        public async Task<dynamic> GetSubProductMasterList(int MasterType, int ProductId)
        {
            List<LoadSubProductMast> PList = new List<LoadSubProductMast>();

            try
            {
                string sql = "";
                if (ProductId == 0)
                {
                    sql = "select A.Id,IsNull(A.[Name], '') as [Name],IsNull(A.[Alias], '') as Alias,IsNull(A.[ParentGrp],0) as PCode,IsNull(C.[Name],'') as PName, IsNull(A.[Desc], '') as [Desc],IsNull(A.[DocAttach], 0) as Doc, IsNull(A.[CreatedBy], '') as Users,IsNull(B.[SrNo],0) as SrNo,IsNull(B.[Name],'') as [IName],IsNull(B.[Base64], '') as [Image],IsNull(B.[FileName],'') as FileName,IsNull(B.[FileExt],'') as FileExt,IsNull(B.[FileSize],0) as FileSize from ProductMaster A Left Join ProductAttachDT B On A.Id = B.ProductId And A.MasterType = B.Rectype left join ProductMaster C On A.ParentGrp = C.Id where A.Mastertype = " + MasterType + "";
                }
                else
                {
                    sql = "select A.Id,IsNull(A.[Name], '') as [Name],IsNull(A.[Alias], '') as Alias,IsNull(A.[ParentGrp],0) as PCode,IsNull(C.[Name],'') as PName, IsNull(A.[Desc], '') as [Desc],IsNull(A.[DocAttach], 0) as Doc, IsNull(A.[CreatedBy], '') as Users,IsNull(B.[SrNo],0) as SrNo,IsNull(B.[Name],'') as [IName],IsNull(B.[Base64], '') as [Image],IsNull(B.[FileName],'') as FileName,IsNull(B.[FileExt],'') as FileExt,IsNull(B.[FileSize],0) as FileSize from ProductMaster A Left Join ProductAttachDT B On A.Id = B.ProductId And A.MasterType = B.Rectype left join ProductMaster C On A.ParentGrp = C.Id where A.Mastertype = " + MasterType + " And A.ID = " + ProductId + "";
                }
                PList = await _db.LoadSubProductMaster.FromSqlRaw(sql).ToListAsync();
            }
            catch (Exception ex)
            {
                return new { Status = 0, Msg = ex.Message.ToString(), Data = PList };
            }
            return new { Status = 1, Msg = "Success", Data = PList };
        }
        public async Task<dynamic> GetProductMasterList(int MasterType, int ProductId, int Category, int SubCategory, int Brand, double Price)
        {
            List<LoadProductMast> PDList = new List<LoadProductMast>();

            try
            {
                string sql = "";
                if (ProductId == 0)
                {
                    sql = "select A.Id,IsNull(A.[Name],'') as Name,A.[PC1],IsNull(C.[Name],'') as Cat,A.[PC2],IsNull(D.[Name],'') as SubCat,A.[PC3],IsNull(E.[Name],'') as Brand,A.[PC4],IsNull(F.[Name],'') as Unit,IsNull(A.[SKU],'') as SKU,A.[Value1] as MinQty,A.[Value2] as Qty,A.[Desc],A.[PC5],IsNull(G.[Name],'') as Tax,A.[PC6],IsNull(H.[Name],'') as DiscType,A.[Value3] as Price,A.[Status],IsNull(A.[DocAttach],0) as Doc,IsNUll(B.[SrNo],0) as SrNo,IsNull(B.[Name],'') as IName,IsNull(B.[Base64],'') as Images,IsNull(B.[FileName],'') as FileName,IsNull(B.[FileExt],'') as FileExt,IsNull(B.[FileSize],0) as FileSize,A.[CreatedBy] as Users from ProductMaster A left join ProductAttachDT B on A.Id = B.ProductId And A.MasterType = B.Rectype left join ProductMaster C On A.PC1 = C.[Id] And C.[MasterType] = 1 left join ProductMaster D On A.PC2 = D.[Id] And D.[MasterType] = 2 left join ProductMaster E On A.PC3 = E.[Id] And E.[MasterType] = 3 left join ProductMaster F On A.PC4 = F.[Id] And F.[MasterType] = 4 left join ProductMaster G On A.PC5 = G.[Id] And G.[MasterType] = 5 left join ProductMaster H On A.PC5 = H.[Id] And H.[MasterType] = 6 where A.MasterType = " + MasterType + " ";
                    
                    sql = Category > 0 ? sql + " And A.[PC1] = " + Category + "" : sql;
                    sql = SubCategory > 0 ? sql + " And A.[PC2] = " + SubCategory + "" : sql;
                    sql = Brand > 0 ? sql + " And A.[PC3] = " + Brand + "" : sql;
                    sql = Price > 0 ? sql + " And A.[Value3] = " + Price + "" : sql;
                }
                else
                {
                    sql = "select A.Id,IsNull(A.[Name],'') as Name,A.[PC1],IsNull(C.[Name],'') as Cat,A.[PC2],IsNull(D.[Name],'') as SubCat,A.[PC3],IsNull(E.[Name],'') as Brand,A.[PC4],IsNull(F.[Name],'') as Unit,IsNull(A.[SKU],'') as SKU,A.[Value1] as MinQty,A.[Value2] as Qty,A.[Desc],A.[PC5],IsNull(G.[Name],'') as Tax,A.[PC6],IsNull(H.[Name],'') as DiscType,A.[Value3] as Price,A.[Status],IsNull(A.[DocAttach],0) as Doc,IsNull(B.[SrNo],0) as SrNo,IsNull(B.[Name],'') as IName,IsNull(B.[Base64],'') as Images,IsNull(B.[FileName],'') as FileName,IsNull(B.[FileExt],'') as FileExt,IsNull(B.[FileSize],0) as FileSize,A.[CreatedBy] as Users from ProductMaster A left join ProductAttachDT B on A.Id = B.ProductId And A.MasterType = B.Rectype left join ProductMaster C On A.PC1 = C.[Id] And C.[MasterType] = 1 left join ProductMaster D On A.PC2 = D.[Id] And D.[MasterType] = 2 left join ProductMaster E On A.PC3 = E.[Id] And E.[MasterType] = 3 left join ProductMaster F On A.PC4 = F.[Id] And F.[MasterType] = 4 left join ProductMaster G On A.PC5 = G.[Id] And G.[MasterType] = 5 left join ProductMaster H On A.PC6 = H.[Id] And H.[MasterType] = 6 where A.MasterType = " + MasterType + " And A.Id = " + ProductId + " ";

                    sql = Category > 0 ? sql + " And A.[PC1] = " + Category + "" : sql;
                    sql = SubCategory > 0 ? sql + " And A.[PC2] = " + SubCategory + "" : sql;
                    sql = Brand > 0 ? sql + " And A.[PC3] = " + Brand + "" : sql;
                    sql = Price > 0 ? sql + " And A.[Value3] = " + Price + "" : sql;
                }

                PDList = await _db.LoadProductMaster.FromSqlRaw(sql).ToListAsync();
            }
            catch (Exception ex)
            {
                return new { status = 0, Msg = ex.Message.ToString(), Data = PDList };
            }
            return new { status = 1, Msg = "Success", Data = PDList };
        }
        public async Task<dynamic> DeleteProdMast(int MasterType, int ProductId)
        {
            int Status = 0;
            string StatusStr = "";

            try
            {
                SqlParameter param0 = new SqlParameter("@p0", MasterType);
                SqlParameter param1 = new SqlParameter("@p1", ProductId);
                var DT = await _db.Responses.FromSqlRaw("Exec [SP_DelProdMaster] @p0, @p1", param0, param1).ToListAsync();

                Status = DT[0].Status;
                StatusStr = DT[0].Msg;
            }
            catch(Exception EX)
            {
                return new { Status = 0, StatusStr = EX.Message.ToString() };
            }
            return new { Status = Status, Msg = StatusStr };
        }
        public async Task<dynamic> SaveUserMaster(SaveUserMast obj)
        {
            int Status = 0;
            string StatusStr = "";

            try
            {
                string XML = POShelper.CreateXML(obj.UserImg);

                SqlParameter param0 = new SqlParameter("@p0", obj.UserId);
                SqlParameter param1 = new SqlParameter("@p1", obj.FName);
                SqlParameter param2 = new SqlParameter("@p2", obj.LName);
                SqlParameter param3 = new SqlParameter("@p3", obj.Username);
                SqlParameter param4 = new SqlParameter("@p4", obj.Pwd);
                SqlParameter param5 = new SqlParameter("@p5", obj.Email);
                SqlParameter param6 = new SqlParameter("@p6", obj.Mobile);
                SqlParameter param7 = new SqlParameter("@p7", obj.Active);
                SqlParameter param8 = new SqlParameter("@p8", obj.Role);
                SqlParameter param9 = new SqlParameter("@p9", obj.Doc);
                SqlParameter param10 = new SqlParameter("@p10", XML);

                var DT = await _db.Responses.FromSqlRaw("EXEC [SP_CreateUserMaster] @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10", param0, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10).ToListAsync();

                Status = DT[0].Status;
                StatusStr = DT[0].Msg; 
            }
            catch (Exception Ex)
            {
                return new { Status = 0, Msg = Ex.Message.ToString() };
            }
            return new {Status = Status, Msg = StatusStr};
        }
        public async Task<dynamic> GetUserMasterList(int UserId)
        {
            List<LoadUserMast> UMList = new List<LoadUserMast>();

            try
            {
                string sql = "";
                if (UserId == 0)
                {
                    sql = "select A.[UserId],A.[Name],A.[FName],A.[LName],A.[UserName],A.[PWD],A.[Email],A.[Mobile],A.[Active],A.[UserType] as [Role],IsNull(A.[DocAttach],0) as Doc,IsNull(B.[SrNo],0) as SrNo,IsNull(B.[Name],'') as [IName],IsNull(B.[Base64], '') as [Image],IsNull(B.[FileName],'') as FileName,IsNull(B.[FileExt],'') as FileExt,IsNull(B.[FileSize],0) as FileSize from UserMaster A left Join UserAttachDT B On A.UserId = B.UserId And B.UserType = 1 ";
                }
                else
                {
                    sql = "select A.[UserId],A.[Name],A.[FName],A.[LName],A.[UserName],A.[PWD],A.[Email],A.[Mobile],A.[Active],A.[UserType] as [Role],IsNull(A.[DocAttach],0) as Doc,IsNull(B.[SrNo],0) as SrNo,IsNull(B.[Name],'') as [IName],IsNull(B.[Base64], '') as [Image],IsNull(B.[FileName],'') as FileName,IsNull(B.[FileExt],'') as FileExt,IsNull(B.[FileSize],0) as FileSize from UserMaster A left Join UserAttachDT B On A.UserId = B.UserId And B.UserType = 1 where A.UserId = " + UserId + " ";
                }

                UMList = await _db.GetUserMaster.FromSqlRaw(sql).ToListAsync();
            }
            catch (Exception ex)
            {
                return new { Status = 0, Msg = ex.Message.ToString(), Data = UMList };
            }
            return new { Status = 1, Msg = "Success", Data = UMList };
        }
        public async Task<dynamic> DeleteUserMaster(int UserId)
        {
            try
            {
                string sql = "";
                sql = "Delete From UserMaster Where UserId = " + UserId + " ";

               int R = await _db.Database.ExecuteSqlRawAsync(sql);

                if (R > 0)
                {
                    return new { Status = 1, Msg = "Success" };
                }
             }
            catch(Exception ex)
            {
                return new { Status = 0, Msg = ex.Message.ToString() };
            }
            return new { Status = 0, Msg = "Success" };
        }
        public async Task<dynamic> SaveCustomerMaster(SaveCustomerMast obj)
        {
            int Status = 0;
            string StatusStr = "";

            try
            {
                string XML = POShelper.CreateXML(obj.CustImg);

                SqlParameter param0 = new SqlParameter("@p0", obj.Id);
                SqlParameter param1 = new SqlParameter("@p1", obj.Name);
                SqlParameter param2 = new SqlParameter("@p2", obj.Alias);
                SqlParameter param3 = new SqlParameter("@p3", obj.Email);
                SqlParameter param4 = new SqlParameter("@p4", obj.Mobile);
                SqlParameter param5 = new SqlParameter("@p5", obj.Gstin);
                SqlParameter param6 = new SqlParameter("@p6", obj.Pan);
                SqlParameter param7 = new SqlParameter("@p7", obj.Country);
                SqlParameter param8 = new SqlParameter("@p8", obj.State);
                SqlParameter param9 = new SqlParameter("@p9", obj.City);
                SqlParameter param10 = new SqlParameter("@p10", obj.Address);
                SqlParameter param11= new SqlParameter("@p11", obj.Desc);
                SqlParameter param12 = new SqlParameter("@p12", obj.Doc);
                SqlParameter param13 = new SqlParameter("@p13", XML.ToString());

                var DT = await _db.Responses.FromSqlRaw("EXEC [SP_CreateCustomerMast] @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13", param0, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13).ToListAsync();

                Status = DT[0].Status;
                StatusStr = DT[0].Msg;

            }
            catch (Exception ex)
            {
                return new { Status = 0, Msg = ex.Message.ToString() };
            }
            return new { Status = Status, Msg = StatusStr };
        }
        public async Task<dynamic> GetCustomerMaster(int CustomerId, string? MobileNo)
        {
            List<LoadCustomerMast> CMList = new List<LoadCustomerMast>();
            try
            {
                string sql = "";

                if (CustomerId == 0)
                {
                    if (MobileNo?.Length > 0)
                    {
                        sql = "select A.[Id],A.[Name],A.[Alias],A.[Email],A.[Mobile],IsNull(A.[Gstin],'') as Gstin,IsNull(A.[Pan],'') as Pan,A.[Country] as CRCode,C.[Name] as CRName,A.[State] as STCode,D.[Name] as STName,A.[City] as CTCode,E.[Name] as CTName,IsNull(A.[Address],'') as Address,IsNull(A.[Description],'') as [Desc],IsNull(A.[DocAttach],0) as Doc,IsNull(B.[SrNo],0) as SrNo,IsNull(B.[Name],'') as [IName],IsNull(B.[Base64], '') as [Image],IsNull(B.[FileName],'') as FileName,IsNull(B.[FileExt],'') as FileExt,IsNull(B.[FileSize],0) as FileSize from CustomerMaster A left Join CustAttachDT B On A.Id = B.CustId And B.RecType = 1 left join MasterAddressInfo C On A.Country = C.Code And C.MasterType = 1 left join MasterAddressInfo D On A.[State] = D.Code And D.MasterType = 2 left join MasterAddressInfo E On A.[City] = E.[Code] And E.MasterType = 3 where  A.[Mobile] = '" + MobileNo + "' " ;
                    }
                    else
                    {
                        sql = "select A.[Id],A.[Name],A.[Alias],A.[Email],A.[Mobile],IsNull(A.[Gstin],'') as Gstin,IsNull(A.[Pan],'') as Pan,A.[Country] as CRCode,C.[Name] as CRName,A.[State] as STCode,D.[Name] as STName,A.[City] as CTCode,E.[Name] as CTName,IsNull(A.[Address],'') as Address,IsNull(A.[Description],'') as [Desc],IsNull(A.[DocAttach],0) as Doc,IsNull(B.[SrNo],0) as SrNo,IsNull(B.[Name],'') as [IName],IsNull(B.[Base64], '') as [Image],IsNull(B.[FileName],'') as FileName,IsNull(B.[FileExt],'') as FileExt,IsNull(B.[FileSize],0) as FileSize from CustomerMaster A left Join CustAttachDT B On A.Id = B.CustId And B.RecType = 1 left join MasterAddressInfo C On A.Country = C.Code And C.MasterType = 1 left join MasterAddressInfo D On A.[State] = D.Code And D.MasterType = 2 left join MasterAddressInfo E On A.[City] = E.[Code] And E.MasterType = 3";
                    }
                }
                else
                {
                    sql = "Select A.[Id],A.[Name],A.[Alias],A.[Email],A.[Mobile],IsNull(A.[Gstin],'') as Gstin,IsNull(A.[Pan],'') as Pan,A.[Country] as CRCode,C.[Name] as CRName,A.[State] as STCode,D.[Name] as STName,A.[City] as CTCode,E.[Name] as CTName,IsNull(A.[Address],'') as Address,IsNull(A.[Description],'') as [Desc],IsNull(A.[DocAttach],0) as Doc,IsNull(B.[SrNo],0) as SrNo,IsNull(B.[Name],'') as [IName],IsNull(B.[Base64], '') as [Image],IsNull(B.[FileName],'') as FileName,IsNull(B.[FileExt],'') as FileExt,IsNull(B.[FileSize],0) as FileSize from CustomerMaster A left Join CustAttachDT B On A.Id = B.CustId And B.RecType = 1 left join MasterAddressInfo C On A.Country = C.Code And C.MasterType = 1 left join MasterAddressInfo D On A.[State] = D.Code And D.MasterType = 2 left join MasterAddressInfo E On A.[City] = E.[Code] And E.MasterType = 3 where A.Id = " + CustomerId + " ";
                }

                CMList = await _db.GetCustomerMaster.FromSqlRaw(sql).ToListAsync();
            }
            catch (Exception ex)
            {
                return new { status = 0, Msg = ex.Message.ToString(), Data = CMList };
            }
            return new { status = 1, Msg = "Success", Data = CMList };
        }
        public async Task<dynamic> DeleteCustMaster(int CustomerId)
        {
            try
            {
                string sql = "";
                sql = "Delete From CustomerMast Where Id = " + CustomerId + " ";

                int Result = await _db.Database.ExecuteSqlRawAsync(sql);

                if (Result > 0)
                {
                    return new { Status = 1, Msg = "Success" };
                }
            }
            catch (Exception ex)
            {
                return new { Status = 0, Msg = ex.Message.ToString() };
            }
            return new { Status = 0, Msg = "Success" };
        }
        public async Task<dynamic> SaveAddressMaster(AddressMast obj, int Mastertype)
        {
            int Status = 0;
            string StatusStr = "";

            try
            {
                SqlParameter param0 = new SqlParameter("@a0", obj.Id);
                SqlParameter param1 = new SqlParameter("@a1", obj.Name);
                SqlParameter param2 = new SqlParameter("@a2", obj.Alias);
                SqlParameter param3 = new SqlParameter("@a3", obj.ParentGrp);
                SqlParameter param4 = new SqlParameter("@a4", obj.SubParentGrp);
                SqlParameter param5 = new SqlParameter("@a5", obj.Desc);
                SqlParameter param6 = new SqlParameter("@a6", Mastertype);
                SqlParameter param7 = new SqlParameter("@a7", obj.Users);

                var DT = await _db.Responses.FromSqlRaw("EXEC [SP_CreateAddressMast] @a0, @a1, @a2, @a3, @a4, @a5, @a6, @a7", param0, param1, param2, param3, param4, param5, param6, param7).ToListAsync();

                Status = DT[0].Status;
                StatusStr = DT[0].Msg;

            }
            catch (Exception ex)
            {
                return new { status = 0, Msg = ex.Message.ToString() };
            }
            return new { status = Status, Msg = StatusStr };
        }
        public async Task<dynamic> GetAddressMaster(int Code, int Mastertype)
        {
            List<LoadAddressMast> ADMAST = new List<LoadAddressMast>();
            try
            {
                string sql = "";
                if(Code == 0)
                {
                    sql = "select A.[Code] as Id,A.[Name],A.[ParentGrp] as CCode,IsNull(B.[Name],'') as CName,A.[SubParentGrp] as SCode,IsNull(C.[Name],'') as SName,A.[Alias],IsNull(A.[Desc],'') as [Desc],IsNull(A.[CreatedBy],'') as Users from MasterAddressInfo A Left Join MasterAddressInfo B On A.ParentGrp = B.Code And B.Mastertype = 1 Left Join MasterAddressInfo C On A.SubParentGrp = C.Code And C.Mastertype = 2 where A.MasterType = " + Mastertype + "";
                }
                else
                {
                    sql = "select A.[Code] as Id,A.[Name],A.[ParentGrp] as CCode,IsNull(B.[Name],'') as CName,A.[SubParentGrp] as SCode,IsNull(C.[Name],'') as SName,A.[Alias],IsNull(A.[Desc],'') as [Desc],IsNull(A.[CreatedBy],'') as Users from MasterAddressInfo A Left Join MasterAddressInfo B On A.ParentGrp = B.Code And B.Mastertype = 1 Left Join MasterAddressInfo C On A.SubParentGrp = C.Code And C.Mastertype = 2 where A.MasterType = " + Mastertype + " And A.Code = " + Code + " ";
                }

                ADMAST = await _db.GetAddressMaster.FromSqlRaw(sql).ToListAsync();

            }
            catch (Exception ex)
            {
                return new { status = 0, Msg = ex.Message.ToString(), Data = ADMAST };
            }
            return new { Statsu = 1, Msg = "Success", Data = ADMAST };
        }
        public async Task<dynamic> DeleteAddressMaster(int MasterType, int Code)
        {
            try
            {
                string sql = "";
                sql = "Delete From [MasterAddressInfo] Where [MasterType] = " + MasterType + " And [Code] = " + Code + " " ;

                int Result = await _db.Database.ExecuteSqlRawAsync(sql);

                if (Result > 0)
                {
                    return new { Status = 1, Msg = "Success" };
                }
            }
            catch (Exception ex)
            {
                return new { Status = 1, Msg = ex.Message.ToString() };
            }
            return new { Status = 0, Msg = "Success" };
        }
        public async Task<dynamic> LoadStateName(int Country)
        {
            List<LoadList> CTList = new List<LoadList>();
            try
            {
                string sql = "";
                sql = "select [Code] as Id,[Name] From Masteraddressinfo where ParentGrp = " + Country + " And MasterType = 2 order by [Name]";

                CTList = await _db.Loadlists.FromSqlRaw(sql).ToListAsync();

                if (CTList.Count > 0)
                {
                    return new { Status = 0, Msg = "Success" , Data = CTList };
                }
            }
            catch (Exception ex)
            {
                return new { Status = 1, Msg = ex.Message.ToString() };
            }

            return new { Status = 0, Msg = "Data Not Found" };
        }
        public async Task<dynamic> LoadCityName(int CountryCode, int StateCode)
        {
            List<LoadList> CTList = new List<LoadList>();
            try
            {
                string sql = "";
                sql = "select [Code] as Id,[Name] from MasterAddressInfo where ParentGrp = " + CountryCode + " and SubParentGrp = " + StateCode + " ";

                CTList = await _db.Loadlists.FromSqlRaw(sql).ToListAsync();

                if (CTList.Count > 0)
                {
                    return new { Status = 1, Msg = "Success", Data = CTList };
                }
            }
            catch (Exception ex)
            {
                return new { Status = 0, Msg = ex.Message.ToString(), Data = CTList };
            }
            return new { Status = 1, Msg = "Data Not Found", Data = CTList };
        }
        public async Task<dynamic> SaveGeneralSetting(GeneratSetting obj, int Mastertype)
        {
            int Status = 0;
            string StatusStr = "";

            try
            {
                SqlParameter param0 = new SqlParameter("@s0", obj.Name);
                SqlParameter param1 = new SqlParameter("@s1", obj.TimeZone);
                SqlParameter param2 = new SqlParameter("@s2", obj.Currency);
                SqlParameter param3 = new SqlParameter("@s3", obj.DateFormat);
                SqlParameter param4 = new SqlParameter("@s4", obj.Email);
                SqlParameter param5 = new SqlParameter("@s5", obj.Mobile);
                SqlParameter param6 = new SqlParameter("@s6", obj.Address);
                SqlParameter param7 = new SqlParameter("@s7", Mastertype);

                var DT = await _db.Responses.FromSqlRaw("EXEC [SP_CreateGeneralSetting] @s0, @s1, @s2, @s3, @s4, @s5, @s6, @s7", param0, param1, param2, param3, param4, param5, param6, param7).ToListAsync();
                
                Status = DT[0].Status;
                StatusStr = DT[0].Msg;
            }
            catch (Exception ex)
            {
                return new { Status = 0, Msg = ex.Message.ToString() };
            }
            return new { Status = Status, Msg = StatusStr };
        }
        public async Task<dynamic> GetGeneralSetting(int Mastertype)
        {
            List<GeneratSetting> GSList = new List<GeneratSetting>();
            try
            {
                string sql = "";
                sql = "select [Name],[TimeZone],[Currency],[DateFormat],IsNull([Email],'') as Email,IsNull([Mobile],'') as Mobile,IsNull([Address],'') Address from [Setting] where Mastertype = " + Mastertype + "";

                GSList = await _db.LoadGeneralSettings.FromSqlRaw(sql).ToListAsync();
            }
            catch (Exception ex)
            {
                return new { Status = 0, Msg = ex.Message.ToString() };
            }
            return new { Status = 1, Msg = "Success", Data = GSList };
        }
        public async Task<dynamic> ImportProductInBusy(int Mastertype)
        {
            List<ImportProduct> IPList = new List<ImportProduct>();
            try
            {
                string sql = "";
                sql = "select A.[Code],A.[Name],IsNull(A.[Alias],'') as Sku,A.[ParentGrp] as CCode,IsNull(E.[Name],'') as CName, 0 as [SCode], ' ' as [SName], 0 as [BCode], ' ' as [BName],IsNull(A.[CM1],0) as UCode,IsNull(B.[Name],'') as UName,IsNull(A.[CM8],0) as TCode, IsNUll(C.[Name],'') as TName,IsNUll(G.CM1,0) as DCode,IsNUll(H.[Name],'') as DName,IsNull(A.[D5],0) as MinQty,IsNUll(D.[D1],0) as Qty,IsNUll(A.[D3],0) as Price,(IsNull(F.[Address1],'') + ' ' + IsNull(F.[Address2],'') + ' ' + IsNull(F.[Address3],'') + ' ' + IsNull(F.[Address4],'')) as [Desc],IsNull(A.[DeactiveMaster],0) as IsActive from Master1 A Left Join Master1 B On A.CM1 = B.Code And B.Mastertype = 8 Left Join Master1 C On A.CM8 = C.Code And C.MasterType = 25 Left Join Folio1 D On A.Code = D.MasterCode And A.MasterType = D.MasterType Left join Master1 E On A.ParentGrp = E.Code And E.MasterType = 5 left join MasterAddressInfo F On A.Code = F.MasterCode left join MasterSupport G On A.Code = G.MasterCode And A.MasterType = G.MasterType And G.I3 = 9 And Rectype = 0 left join Master1 H On G.CM1 = H.Code And H.MasterType = 30 where A.[MasterType] = " + Mastertype + " ";
                IPList = await _busyDb.ImportProducts.FromSqlRaw(sql).ToListAsync();
            }
            catch (Exception ex)
            {
                return new { Status = 0, Msg = ex.Message.ToString() };
            }

            return new { Status = 1, Msg = "Success", Data = IPList };
        }
        public async Task<dynamic> SaveImportBusyProducts(BusyImportProduct obj, int Mastertype, int RecType)
        {
            int Status = 0;
            string StatusStr = "";
            try
            {
                string XML = POShelper.CreateXML(obj.ImportProducts);

                SqlParameter param1 = new SqlParameter("@p1", XML.ToString());
                SqlParameter param2 = new SqlParameter("@p2", Mastertype);
                SqlParameter param3 = new SqlParameter("@p3", RecType);

                var DT = await _db.Responses.FromSqlRaw("EXEC [SP_CreateImportProductMasterInBusy] @p1, @p2, @p3", param1, param2, param3).ToListAsync();

                Status = DT[0].Status;
                StatusStr = DT[0].Msg;
            }
            catch (Exception ex)
            {
                return new { Status = 0, Msg = ex.Message.ToString() };
            }
            return new { Status = 1, Msg = StatusStr };
        }
    }
}
