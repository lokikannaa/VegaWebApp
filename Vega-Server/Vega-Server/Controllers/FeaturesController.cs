using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vega_Server.Controllers.Resources;
using Vega_Server.Models;
using Vega_Server.Persistence;

namespace Vega_Server.Controllers
{
    [Produces("application/json")]
    [Route("api/Features")]
    public class FeaturesController : Controller
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;

        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<KeyValuePairResource> GetFeatures()
        {
            var features = context.Features.ToList();
            return mapper.Map<List<Feature>, List<KeyValuePairResource>>(features);
        }
    }
}