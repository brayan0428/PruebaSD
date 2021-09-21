using Backend.Data;
using Backend.Entities;
using Backend.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repository
{
    public class RepositoryUsuarios : IRepository<Usuarios>
    {
        ApplicationDbContext _dbContext;

        public RepositoryUsuarios(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public IEnumerable<Usuarios> getAll()
        {
            try
            {
                return _dbContext.Usuarios.ToList();
            }catch(Exception e)
            {
                throw;
            }
        }
    }
}
