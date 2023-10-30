using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;
using OSDC.DrillingContextualData.ModelShared;
using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.DrillingUnitConversion.Service.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class DrillingPhysicalQuantitiesController : ControllerBase
    {
        private readonly ILogger logger_;

        public DrillingPhysicalQuantitiesController(ILoggerFactory loggerFactory)
        {
            logger_ = loggerFactory.CreateLogger<DrillingPhysicalQuantitiesController>();
        }

        // GET api/DrillingPhysicalQuantities
        [HttpGet]
        public IEnumerable<Guid> Get()
        {
            List<PhysicalQuantity> quantities = new List<PhysicalQuantity>();
            // Adding base Conversion quantities
            quantities.AddRange(PhysicalQuantity.AvailableQuantities);
            // and quantities specific to Conversion.DrillingEngineering
            quantities.AddRange(DrillingPhysicalQuantity.AvailableQuantities);
            List<Guid> ids = new List<Guid>();
            if (quantities != null)
            {
                foreach (PhysicalQuantity quantity in quantities)
                {
                    ids.Add(quantity.ID);
                }
            }
            return ids;
        }

        // GET api/DrillingPhysicalQuantities/MetaInfos
        [HttpGet("MetaInfos")]
        public IEnumerable<MetaInfo> GetMetaInfos()
        {
            List<PhysicalQuantity> quantities = new List<PhysicalQuantity>();
            // Adding base Conversion quantities
            quantities.AddRange(PhysicalQuantity.AvailableQuantities);
            // and quantities specific to Conversion.DrillingEngineering
            quantities.AddRange(DrillingPhysicalQuantity.AvailableQuantities);
            List<MetaInfo> ids = new List<MetaInfo>();
            if (quantities != null)
            {
                foreach (PhysicalQuantity quantity in quantities)
                {
                    MetaInfo metaInfo = new MetaInfo
                    {
                        ID = quantity.ID,
                        Name = quantity.Name
                    };
                    ids.Add(metaInfo);
                }
            }
            return ids;
        }

        // GET api/DrillingPhysicalQuantities/c0d965b2-a153-420a-9d03-7a2a272d619e
        [HttpGet("{id}")]
        public PhysicalQuantity Get(Guid id)
        {
            PhysicalQuantity quantity = DrillingPhysicalQuantity.GetQuantity(id);
            return quantity;
        }

    }
}
