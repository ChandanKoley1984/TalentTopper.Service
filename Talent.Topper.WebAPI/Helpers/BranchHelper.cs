using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Talent.Topper.Data;

namespace Talent.Topper.WebAPI.Helpers
{
    public class BranchHelper
    {
        BranchDataAccessLayer _branchDataAccessLayer = new BranchDataAccessLayer();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="companyID"></param>
        /// <returns></returns>
        internal List<BRANCH> GetBranch(int? ID = null)
        {
            return _branchDataAccessLayer.GetBranch(ID).ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_company"></param>
        /// <returns></returns>
        internal Dictionary<string, string> CreateBranch(BRANCH _branch)
        {
            return _branchDataAccessLayer.CreateBranch(_branch);
        }
    }
}