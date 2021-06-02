using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiItalika.Model.Context;
using ApiItalika.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiItalika.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private readonly ApiContext _context;

        public SeriesController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Productos/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<mySP>>> GetProductos()
        {
            //return await _context.Producto.ToListAsync();
            //var lis = _context.Producto.FromSqlRaw("EXEC BuscarTodos").ToList().FirstOrDefault();
            return await _context.Series.FromSqlRaw("EXEC BuscarTodos").ToListAsync();
        }
    }
}
