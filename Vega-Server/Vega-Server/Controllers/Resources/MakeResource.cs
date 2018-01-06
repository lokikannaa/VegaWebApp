using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Vega_Server.Controllers.Resources
{
    public class MakeResource
    {
        public ICollection<ModelResource> Models { get; set; }
        public MakeResource()
        {
            this.Models = new Collection<ModelResource>();
        }
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
