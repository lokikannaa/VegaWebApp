﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega_Server.Controllers.Resources;
using Vega_Server.Models;

namespace Vega_Server.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            //CreateMap<Feature, KeyValuePairResource>();
        }
    }
}