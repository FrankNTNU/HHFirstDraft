﻿using HHFirstDraft.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHFirstDraft.DAL.DAO
{
    public class WorkoutCategoryDAO : HHContext
    {
        public List<WorkoutCategoryDetailDTO> GetCategories()
        {
            List<WorkoutCategory> categories = db.WorkoutCategories.ToList();
            List<WorkoutCategoryDetailDTO> dtoList = new List<WorkoutCategoryDetailDTO>();
            foreach (var item in categories)
            {
                WorkoutCategoryDetailDTO dto = new WorkoutCategoryDetailDTO();
                dto.ID = item.ID;
                dto.Name = item.Name;
                dtoList.Add(dto);
            }
            return dtoList;
        }

        public bool Add(WorkoutCategory entity)
        {
            try
            {
                db.WorkoutCategories.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(WorkoutCategory entity)
        {
            try
            {
                WorkoutCategory category = db.WorkoutCategories.First(x => x.ID == entity.ID);
                category.Name = entity.Name;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(int ID)
        {
            WorkoutCategory category = db.WorkoutCategories.First(x => x.ID == ID);
            db.WorkoutCategories.Remove(category);
            db.SaveChanges();
        }

        public bool HasWorkouts(int ID)
        {
            Workout workout = db.Workouts.FirstOrDefault(x => x.WorkoutCategoryID == ID);
            if (workout != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal List<WorkoutCategoryDetailDTO> GetCategories(string text)
        {
            List<WorkoutCategory> categories = db.WorkoutCategories.Where(x => x.Name.Contains(text)) .ToList();
            List<WorkoutCategoryDetailDTO> dtoList = new List<WorkoutCategoryDetailDTO>();
            foreach (var item in categories)
            {
                WorkoutCategoryDetailDTO dto = new WorkoutCategoryDetailDTO();
                dto.ID = item.ID;
                dto.Name = item.Name;
                dtoList.Add(dto);
            }
            return dtoList;
        }

        public bool IsCategoryExist(string text)
        {
            try
            {
                WorkoutCategory category = db.WorkoutCategories.FirstOrDefault(x => x.Name == text);
                if (category != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
