using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public IEnumerable<Company> GetCompanies(int? companyid = null)
        {
            if (companyid != null)
            {
                return _dbContext.Companies.Where(m => m.CompanyId == companyid && m.IsActive == true);
            }
            else
            {
                return _dbContext.Companies.Where(m => m.IsActive == true);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_company"></param>
        /// <returns></returns>
        public int CreateCompany(Company _company)
        {            
            _dbContext.Companies.Add(_company);
            if (_company.CompanyId > 0)
                _dbContext.Entry(_company).State = EntityState.Modified;

            int saveStatus = _dbContext.SaveChanges();
            return saveStatus;
        }


    }
}
