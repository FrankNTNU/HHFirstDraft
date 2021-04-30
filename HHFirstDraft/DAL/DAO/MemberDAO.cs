using HHFirstDraft.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHFirstDraft.DAL.DAO
{
    public class MemberDAO : HHContext
    {
        public List<MemberDetailDTO> GetMembers()
        {
            List<MemberDetailDTO> Members = new List<MemberDetailDTO>();
            var list = db.Members.ToList();
            foreach (Member item in list)
            {
                MemberDetailDTO dto = new MemberDetailDTO();
                dto.ID = item.ID;
                dto.Name = item.Name;
                dto.Email = item.Email;
                dto.Phone = item.Phone;
                dto.StatusID = item.StatusID;
                dto.Status = item.Status.Name;
                dto.IsAdmin = item.IsAdmin;
                dto.TaiwanID = item.TaiwanID;
                dto.ActivityLevel = item.ActivityLevel.Description;
                dto.Birthdate = item.Birthdate;
                dto.JoinDate = item.JoinDate;
                if (item.Gender)
                {
                    dto.Gender = true;
                    dto.GenderString = "男";
                }
                else
                {
                    dto.Gender = false;
                    dto.GenderString = "女";
                }
                Members.Add(dto);
            }
            return Members;
        }

        public void Update(Member entity)
        {
            try
            {
                Member member = db.Members.First(x => x.ID == entity.ID);
                member.Name = entity.Name;
                member.Phone = entity.Phone;
                member.Email = entity.Email;
                member.Gender = entity.Gender;
                member.StatusID = entity.StatusID;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(Member entity)
        {
            try
            {
                Member member = db.Members.First(x => x.ID == entity.ID);
                db.Members.Remove(member);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Add(Member member)
        {
            try
            {
                db.Members.Add(member);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<MemberDetailDTO> GetMembers(string keyword)
        {
            List<MemberDetailDTO> Members = new List<MemberDetailDTO>();
            var list = db.Members.Where(x => x.Name.Contains(keyword) 
            || x.Email.Contains(keyword) 
            || x.TaiwanID.Contains(keyword)
            || x.Phone.Contains(keyword)).ToList();
            foreach (Member item in list)
            {
                MemberDetailDTO dto = new MemberDetailDTO();
                dto.ID = item.ID;
                dto.Name = item.Name;
                dto.Email = item.Email;
                dto.Phone = item.Phone;
                dto.StatusID = item.StatusID;
                dto.Status = item.Status.Name;
                dto.Birthdate = item.Birthdate;
                dto.JoinDate = item.JoinDate;
                dto.IsAdmin = item.IsAdmin;
                dto.TaiwanID = item.TaiwanID;
                dto.ActivityLevel = item.ActivityLevel.Description;
                if (item.Gender)
                {
                    dto.Gender = true;
                    dto.GenderString = "男";
                }
                else
                {
                    dto.Gender = false;
                    dto.GenderString = "女";
                }

                Members.Add(dto);
            }
            return Members;
        }
    }
}
