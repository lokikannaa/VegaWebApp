using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega_Server.Controllers.Resources;
using Vega_Server.Models;
using Vega_Server.Persistence;

namespace Vega_Server.Controllers
{
    [Produces("application/json")]
    [Route("api/Makes")]
    public class MakesController : Controller
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;

        public MakesController(VegaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<MakeResource> GetMakes()
        {
            var makes = context.Makes.Include(m => m.Models).ToList();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}