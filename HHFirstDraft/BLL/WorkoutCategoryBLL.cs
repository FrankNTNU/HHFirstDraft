using HHFirstDraft.DAL;
using HHFirstDraft.DAL.DAO;
using HHFirstDraft.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHFirstDraft.BLL
{
    public class WorkoutCategoryBLL
    {
        WorkoutCategoryDAO dao = new WorkoutCategoryDAO();
        public bool Add(WorkoutCategoryDetailDTO entity)
        {
            WorkoutCategory workoutCategory = new WorkoutCategory();
            workoutCategory.Name = entity.Name;
            return dao.Add(workoutCategory);
        }
        public WorkoutCategoryDTO GetCategories()
        {
            WorkoutCategoryDTO dto = new WorkoutCategoryDTO();
            dto.Categories = dao.GetCategories();
            return dto;

        }

        public void Update(WorkoutCategoryDetailDTO entity)
        {
            WorkoutCategory category = new WorkoutCategory();
            category.ID = entity.ID;
            category.Name = entity.Name;
            dao.Update(category);
        }

        public bool IsCategoryExist(string text)
        {
            return dao.IsCategoryExist(text);
        }

        public bool HasWorkouts(int ID)
        {
            return dao.HasWorkouts(ID);
        }

        public void Delete(int ID)
        {
            dao.Delete(ID);
        }
    }
}
