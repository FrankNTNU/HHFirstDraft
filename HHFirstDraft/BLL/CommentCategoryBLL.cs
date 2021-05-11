using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HHFirstDraft.DAL.DAO;
using HHFirstDraft.DAL.DTO;

namespace HHFirstDraft.BLL
{
    public class CommentCategoryBLL
    {
        CommentCategoryDAO dao = new CommentCategoryDAO();
        public List<CommentCategoryDetailDTO> GetCommentCategories()
        {
            return dao.GetCommentCategories();
        }
    }
}
