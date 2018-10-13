using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Talent.Topper.WebAPI.Models;

namespace Talent.Topper.WebAPI.Service
{
    interface IAdminService
    {
        HttpResponseMessage CreateCompany(CompanyEntity companyEntity);
        HttpResponseMessage GetCompany(string id);
        HttpResponseMessage CreateBranch();
        HttpResponseMessage GetBranch(string id);
    }
}
