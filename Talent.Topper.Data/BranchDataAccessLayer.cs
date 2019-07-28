using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talent.Topper.Data
{
    public class BranchDataAccessLayer
    {
        TalentTopperEntities _dbContext = new TalentTopperEntities();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="companyid"></param>
        /// <returns></returns>
        public IEnumerable<BRANCH> GetBranch(int? ID = null)
        {
            if (ID != null)
            {
                return _dbContext.BRANCHes.Where(m => m.ID == ID && m.IsActive == true);
            }
            else
            {
                return _dbContext.BRANCHes.Where(m => m.IsActive == true);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_company"></param>
        /// <returns></returns>
        public int CreateBranch(BRANCH _branch)
        {
            _dbContext.BRANCHes.Add(_branch);
            if (_branch.ID > 0)
                _dbContext.Entry(_branch).State = EntityState.Modified;

            int saveStatus = _dbContext.SaveChanges();
            long OutPut_ID = _branch.ID;

            return saveStatus;
        }
    }
}
