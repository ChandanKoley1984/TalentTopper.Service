using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Talent.Topper.Entity;



namespace Talent.Topper.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            MongoHelper.MongoHelper _mongoHelperobj = new MongoHelper.MongoHelper("TalentTopper");
            List<CompanyMaster> companyMasterList = new List<CompanyMaster>();

            //select Data by Single Field
            FilterDefinition<BsonDocument> filterDefinition = new BsonDocument("Name", "Name 1");
            //var filter = Builders<CompanyMaster>.Filter.Eq(x => x.Name, "Name 1");
            //filter = filter & (Builders<CompanyMaster>.Filter.Eq(x => x.Address, "Address 1") | Builders<CompanyMaster>.Filter.Eq(x => x.Mobile, "454541"));
            companyMasterList = _mongoHelperobj.Select<CompanyMaster>("CompanyMaster", filterDefinition);
            
                
            //Insert Data           
            CompanyMaster _companyMaster = new CompanyMaster();
            companyMasterList = new List<CompanyMaster>();            
            for (int i = 0; i < 10000; i++)
            {
                _companyMaster = new CompanyMaster();
                _companyMaster.ID = ObjectId.GenerateNewId();
                _companyMaster.Name = "Name " + i.ToString();
                _companyMaster.Address = "Address " + i.ToString();
                _companyMaster.Mobile = "45454" + i.ToString();
                companyMasterList.Add(_companyMaster);               
            }            
           // bool status = _mongoHelperobj.InsertMany("BranchMaster", companyMasterList);


            //To do
            //Filter data with More Than One conditions
            //Join two or more collections
            //



            return View();
        }

        public BsonArray ToBsonDocumentArray(List<CompanyMaster> list)
        {
            var array = new BsonArray();
            foreach (var item in list)
            {
                array.Add(item.ToBson());
            }
            return array;
        }


    }
}
