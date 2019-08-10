using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Talent.Topper.Data;

namespace Talent.Topper.WebAPI.Helpers
{
    public class ContactHelper
    {
        ContactDataAccessLayer _ContactDataAccessLayer = new ContactDataAccessLayer();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="contactID"></param>
        /// <returns></returns>
        internal List<CONTACT> GetContact(int? ID = null)
        {
            return _ContactDataAccessLayer.GetContact(ID).ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_contact"></param>
        /// <returns></returns>
        internal Dictionary<string, string> CreateContact(CONTACT _contact)
        {
            return _ContactDataAccessLayer.CreateContact(_contact);
        }
    }
}