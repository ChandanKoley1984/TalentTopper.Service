using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talent.Topper.Data
{
    public class ContactDataAccessLayer
    {
        TalentTopperEntities _dbContext = new TalentTopperEntities();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<CONTACT> GetContact(int? ID = null)
        {
            if (ID != null)
            {
                return _dbContext.CONTACTs.Where(m => m.ID == ID && m.IsActive == true);
            }
            else
            {
                return _dbContext.CONTACTs.Where(m => m.IsActive == true);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_contact"></param>
        /// <returns></returns>
        public Dictionary<string, string> CreateContact(CONTACT _contact)
        {
            Dictionary<string, string> _ContactOutPut = new Dictionary<string, string>();

            _dbContext.CONTACTs.Add(_contact);
            if (_contact.ID > 0)
                _dbContext.Entry(_contact).State = EntityState.Modified;

            int saveStatus = _dbContext.SaveChanges();
            long OutPut_ID = _contact.ID;

            _ContactOutPut.Add("saveStatus", saveStatus.ToString());
            _ContactOutPut.Add("OutPut", OutPut_ID.ToString());

            return _ContactOutPut;
        }
    }
}
