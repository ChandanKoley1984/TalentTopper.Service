﻿using System;
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
        public IEnumerable<COMPANY> GetCompanies(int? companyid = null)
        {
            if (companyid != null)
            {
                return _dbContext.COMPANies.Where(m => m.ID == companyid && m.IsActive == true);
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
        public int CreateCompany(COMPANY _company)
        {            
            _dbContext.COMPANies.Add(_company);
            if (_company.Contact_Id > 0)
                _dbContext.Entry(_company).State = EntityState.Modified;

            int saveStatus = _dbContext.SaveChanges();
            return saveStatus;
        }


    }
}
