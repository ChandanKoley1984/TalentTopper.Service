using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Talent.Topper.Data;


namespace Talent.Topper.WebAPI.Helpers
{
    public class AdminServiceHelper
    {
        CompanyDataAccessLayer _companyDataAccessLayer = new CompanyDataAccessLayer();
        internal List<COMPANY> GetCompanies(int? companyID = null)
        {
            return _companyDataAccessLayer.GetCompanies(companyID).ToList();           
        }

        //internal static List<BranchEntity> GetBranchList(string id = "")
        //{
        //    //call Database
        //    MongoHelper.MongoHelper _mongoHelperobj = new MongoHelper.MongoHelper("TalentTopper");
        //    List<BranchEntity> branchMasterList = new List<BranchEntity>();
        //    List<BranchEntity> branchMasterFinalList = new List<BranchEntity>();
        //    BranchEntity _branchEntity = new BranchEntity();
        //    branchMasterList = _mongoHelperobj.SelectAll<BranchEntity>("BranchMaster");
        //    if (!id.Equals("GetAll"))
        //    {
        //        branchMasterList = branchMasterList.Where(a => a.BsonId.ToString() == id).ToList();
        //    }
        //    foreach (BranchEntity be in branchMasterList)
        //    {
        //        be.id = be.BsonId.ToString();
        //        branchMasterFinalList.Add(be);
        //    }

        //    return branchMasterList;
        //}
        //internal static List<GeneratedIDEntity> GetGeneratedIDsList(int companyID = 0)
        //{
        //    //call Database
        //    MongoHelper.MongoHelper _mongoHelperobj = new MongoHelper.MongoHelper("TalentTopper");
        //    List<GeneratedIDEntity> IDMasterList = _mongoHelperobj.SelectAll<GeneratedIDEntity>("IDMaster");
        //    return IDMasterList;
        //}
        //internal static List<CountryEntity> GetCountryList(int CountryID = 0)
        //{
        //    //call Database
        //    MongoHelper.MongoHelper _mongoHelperobj = new MongoHelper.MongoHelper("TalentTopper");
        //    List<CountryEntity> CountryMasterList = _mongoHelperobj.SelectAll<CountryEntity>("CountryMaster").Where(x => x.IsActive == 1).ToList();
        //    return CountryMasterList;
        //}
        //internal static List<StateByCountryEntity> GetStateByCountryList(string CountryID)
        //{
        //    //call Database
        //    MongoHelper.MongoHelper _mongoHelperobj = new MongoHelper.MongoHelper("TalentTopper");
        //    List<StateByCountryEntity> StateMasterList = _mongoHelperobj.SelectAll<StateByCountryEntity>("StateMaster").Where(x => x.CountryId == CountryID).ToList();
        //    return StateMasterList;
        //}
        //internal static List<CompanyEntity> SearchCompanyList(string name)
        //{
        //    //call Database
        //    MongoHelper.MongoHelper _mongoHelperobj = new MongoHelper.MongoHelper("TalentTopper");
        //    if (name != "")
        //    {
        //        List<CompanyEntity> StateMasterList = _mongoHelperobj.SelectAll<CompanyEntity>("CompanyMaster").Where(x => (x.CompanayName == name) || (x.Email == name) || (x.WebsiteURL == name)).ToList();
        //        return StateMasterList;
        //    }
        //    else
        //    {
        //        List<CompanyEntity> StateMasterList = _mongoHelperobj.SelectAll<CompanyEntity>("CompanyMaster").ToList();
        //        return StateMasterList;
        //    }
        //}
    }
}