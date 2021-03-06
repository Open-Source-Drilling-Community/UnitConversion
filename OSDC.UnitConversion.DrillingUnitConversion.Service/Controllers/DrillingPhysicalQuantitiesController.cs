using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;
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
            logger_ = loggerFactory.CreateLogger<DataUnitConversionSetsController>();
        }

        // GET api/DrillingPhysicalQuantities
        [HttpGet]
        public IEnumerable<Guid> Get(int option)
        {
            if (option == 0)
            {
                List<PhysicalQuantity> quantities = DrillingPhysicalQuantity.AvailableQuantities;
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
            else
            {
                return null;
            }
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
