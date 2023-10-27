using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OSDC.UnitConversion.DrillingUnitConversion.Model;
using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.DrillingUnitConversion.Service.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class QuantityDataConversionsController : ControllerBase
    {
        private readonly ILogger logger_;
        private readonly QuantityDataConversionManager quantityDataConversionManager_;

        public QuantityDataConversionsController(ILoggerFactory loggerFactory)
        {
            logger_ = loggerFactory.CreateLogger<QuantityDataConversionsController>();
            quantityDataConversionManager_ = new QuantityDataConversionManager(loggerFactory);
        }

        // GET api/QuantityDataConversions
        [HttpGet]
        public IEnumerable<Guid> Get()
        {
            var ids = quantityDataConversionManager_.GetIDs();
            return ids;
        }

        // GET api/QuantityDataConversions/f8338e35-c548-4284-a2e7-61b94a7b4769
        [HttpGet("{id}")]
        public QuantityDataConversion Get(Guid id)
        {
            return quantityDataConversionManager_.Get(id);
        }

        // POST api/QuantityDataConversions
        [HttpPost]
        public void Post([FromBody] QuantityDataConversion value)
        {
            if (value != null && !value.ID.Equals(Guid.Empty))
            {
                QuantityDataConversion dataUnitConversionSet = quantityDataConversionManager_.Get(value.ID);
                if (dataUnitConversionSet == null)
                {
                    quantityDataConversionManager_.Add(value);
                }
                else
                {
                    logger_.LogWarning("The given QuantityDataConversion already exists and will not be updated");
                }
            }
            else
            {
                logger_.LogWarning("The given QuantityDataConversion is null or its ID is null or empty");
            }
        }

        // PUT api/QuantityDataConversions/f29b357f-8b76-4abe-ad84-4ccd5ccef77e
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] QuantityDataConversion value)
        {
            if (value != null && !value.ID.Equals(Guid.Empty))
            {
                QuantityDataConversion calculationData = quantityDataConversionManager_.Get(id);
                if (calculationData != null)
                {
                    quantityDataConversionManager_.Update(id, value);
                }
                else
                {
                    logger_.LogWarning("The given QuantityDataConversion cannot be retrieved from the database");
                }
            }
            else
            {
                logger_.LogWarning("The given QuantityDataConversion is null or its ID is null or empty");
            }
        }

        // DELETE api/QuantityDataConversions/f29b357f-8b76-4abe-ad84-4ccd5ccef77e
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            if (!id.Equals(Guid.Empty))
            {
                quantityDataConversionManager_.Remove(id);
            }
            else
            {
                logger_.LogWarning("The given QuantityDataConversion ID is null or empty");
            }
        }
    }
}
