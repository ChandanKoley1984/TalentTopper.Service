using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Talent.Topper.Data;


namespace Talent.Topper.WebAPI.Service
{
    interface IAdminService
    {
        HttpResponseMessage CreateCompany(COMPANY companyEntity);
        HttpResponseMessage GetCompany(string id);
        HttpResponseMessage CreateBranch(BRANCH companyEntity);
        HttpResponseMessage GetBranch(string id);
    }
}
