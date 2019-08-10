using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Net;
using System.Net.Http;
namespace Talent.Topper.Data
{
    public class CompanyDataAccessLayer
    {
        TalentTopperEntities _dbContext = new TalentTopperEntities();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="companyid"></param>
        /// <returns></returns>
        public IEnumerable<COMPANY> GetCompanies(int? ID = null)
        {
            if (ID != null)
            {
                return _dbContext.COMPANies.Where(m => m.ID == ID && m.IsActive == true);
            }
            else
            {
                return _dbContext.COMPANies.Where(m => m.IsActive == true);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_company"></param>
        /// <returns></returns>
        public Dictionary<string, string> CreateCompany(COMPANY _company)
        {
            Dictionary<string, string> _CompanyOutPut = new Dictionary<string, string>();

            //var returnValue = new Data_Return();
            _dbContext.COMPANies.Add(_company);
            if (_company.ID > 0)
                _dbContext.Entry(_company).State = EntityState.Modified;

            int saveStatus = _dbContext.SaveChanges();
            long OutPut_ID = _company.ID;

            _CompanyOutPut.Add("saveStatus", saveStatus.ToString());
            _CompanyOutPut.Add("OutPut", OutPut_ID.ToString());


            return _CompanyOutPut;
        }


    }
   
}
