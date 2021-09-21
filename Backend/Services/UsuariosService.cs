using Backend.Entities;
using Backend.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class UsuariosService
    {
        private readonly IRepository<Usuarios> _usuarios;

        public UsuariosService(IRepository<Usuarios> usuarios)
        {
            _usuarios = usuarios;
        }

        public IEnumerable<Usuarios> GetAllUsuarios()
        {
            return _usuarios.getAll().ToList();
        }
    }
}
