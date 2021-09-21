using Backend.Entities;
using Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuariosService _usuarioService;
        //private readonly IRepository<Usuarios> _usuarios;

        public UsuariosController(UsuariosService usuariosService)
        {
            _usuarioService = usuariosService;
        }
        [HttpGet("GetAllUsuarios")]
        public IEnumerable<Usuarios> GetAllUsuarios()
        {
            var data = _usuarioService.GetAllUsuarios();
            return data;
        }
    }
}
