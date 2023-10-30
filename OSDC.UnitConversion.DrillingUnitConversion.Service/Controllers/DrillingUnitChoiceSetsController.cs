using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OSDC.DrillingContextualData.ModelShared;
using OSDC.UnitConversion.Conversion.DrillingEngineering;
using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.DrillingUnitConversion.Service.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class DrillingUnitChoiceSetsController : ControllerBase
    {
        private readonly ILogger logger_;
        private readonly DrillingUnitChoiceSetManager drillingUnitChoiceSetManager_;

        public DrillingUnitChoiceSetsController(ILoggerFactory loggerFactory)
        {
            logger_ = loggerFactory.CreateLogger<DrillingUnitChoiceSetsController>();
            drillingUnitChoiceSetManager_ = new DrillingUnitChoiceSetManager(loggerFactory);
        }

        // GET api/DrillingUnitChoiceSets
        [HttpGet]
        public IEnumerable<Guid> Get()
        {
            var ids = drillingUnitChoiceSetManager_.Get();
            return ids;
        }

        // GET api/DrillingUnitChoiceSets/MetaInfos
        [HttpGet("MetaInfos")]
        public IEnumerable<MetaInfo> GetMetaInfos()
        {
            var ids = drillingUnitChoiceSetManager_.GetMetaInfos();
            return ids;
        }

        // GET api/DrillingUnitChoiceSets/7f70fe4f-f4a4-4fdf-a95d-241b0a6f4a4e
        [HttpGet("{id}")]
        public DrillingUnitChoiceSet Get(Guid id)
        {
            return drillingUnitChoiceSetManager_.Get(id);
        }

        // POST api/DrillingUnitChoiceSets
        [HttpPost]
        public void Post([FromBody] DrillingUnitChoiceSet value)
        {
            if (value != null && value.ID != Guid.Empty)
            {
                DrillingUnitChoiceSet baseData1 = drillingUnitChoiceSetManager_.Get(value.ID);
                if (baseData1 == null)
                {
                    drillingUnitChoiceSetManager_.Add(value);
                }
                else
                {
                    logger_.LogWarning("The given DrillingUnitChoiceSet already exists and will not be updated");
                }
            }
            else
            {
                logger_.LogWarning("The given DrillingUnitChoiceSet is null or its ID is null or empty");
            }
        }

        // PUT api/DrillingUnitChoiceSets/7f70fe4f-f4a4-4fdf-a95d-241b0a6f4a4e
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] DrillingUnitChoiceSet value)
        {
            if (value != null && value.ID != Guid.Empty)
            {
                DrillingUnitChoiceSet baseData1 = drillingUnitChoiceSetManager_.Get(id);
                if (baseData1 != null)
                {
                    drillingUnitChoiceSetManager_.Update(id, value);
                }
                else
                {
                    logger_.LogWarning("The given DrillingUnitChoiceSet cannot be retrieved from the database");
                }
            }
            else
            {
                logger_.LogWarning("The given DrillingUnitChoiceSet is null or its ID is null or empty");
            }
        }

        // DELETE api/DrillingUnitChoiceSets/7f70fe4f-f4a4-4fdf-a95d-241b0a6f4a4e
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            if (!id.Equals(Guid.Empty))
            {
                drillingUnitChoiceSetManager_.Remove(id);
            }
            else
            {
                logger_.LogWarning("The given DrillingUnitChoiceSet ID is null or empty");
            }
        }
    }
}
