using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Data;
using TaskManager.Interface;
using TaskManager.Models;

namespace TaskManager.Service
{
    public class MissionService : Imission<Mission>
    {
        private readonly ApplicationDbContext _context;
        public MissionService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Delete(Mission entity)
        {
            if(entity!= null)
            {
                _context.missions.Remove(entity);
                _context.SaveChanges();
            }
        }

        public Mission Finds(int id)
        {
            return _context.missions.Find(id);
        }

        public IEnumerable<Mission> GetList()
        {
            return _context.missions.ToList();
        }

        public void Save(Mission entity)
        {
            if (entity != null)
            {
                _context.missions.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Update(Mission entity)
        {
            if (entity != null)
            {
                Mission old = Finds(entity.Id);
                _context.Entry(old).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
