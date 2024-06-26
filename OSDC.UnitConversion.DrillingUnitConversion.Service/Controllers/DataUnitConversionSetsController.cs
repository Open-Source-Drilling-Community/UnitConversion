﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OSDC.UnitConversion.DrillingUnitConversion.Model;
using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.DrillingUnitConversion.Service.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class DataUnitConversionSetsController : ControllerBase
    {
        private readonly ILogger logger_;
        private readonly DataUnitConversionSetManager dataUnitConversionSetManager_;

        public DataUnitConversionSetsController(ILoggerFactory loggerFactory)
        {
            logger_ = loggerFactory.CreateLogger<DataUnitConversionSetsController>();
            dataUnitConversionSetManager_ = new DataUnitConversionSetManager(loggerFactory);
        }

        // GET api/DataUnitConversionSets
        [HttpGet(Name = "GetAllDataUnitConversionSet")]
        public IEnumerable<Guid> Get()
        {
            var ids = dataUnitConversionSetManager_.GetIDs();
            return ids;
        }

        // GET api/DataUnitConversionSets/f8338e35-c548-4284-a2e7-61b94a7b4769
        [HttpGet("{id}", Name = "GetDataUnitConversionSetById")]
        public DataUnitConversionSet Get(Guid id)
        {
            return dataUnitConversionSetManager_.Get(id);
        }

        // POST api/DataUnitConversionSets
        [HttpPost(Name = "PostDataUnitConversionSet")]
        public void Post([FromBody] DataUnitConversionSet value)
        {
            if (value != null && !value.ID.Equals(Guid.Empty))
            {
                DataUnitConversionSet dataUnitConversionSet = dataUnitConversionSetManager_.Get(value.ID);
                if (dataUnitConversionSet == null)
                {
                    dataUnitConversionSetManager_.Add(value);
                }
                else
                {
                    logger_.LogWarning("The given DataUnitConversionSet already exists and will not be updated");
                }
            }
            else
            {
                logger_.LogWarning("The given DataUnitConversionSet is null or its ID is null or empty");
            }
        }

        // PUT api/DataUnitConversionSets/f29b357f-8b76-4abe-ad84-4ccd5ccef77e
        [HttpPut("{id}", Name = "PutDataUnitConversionSetById")]
        public void Put(Guid id, [FromBody] DataUnitConversionSet value)
        {
            if (value != null && !value.ID.Equals(Guid.Empty))
            {
                DataUnitConversionSet calculationData = dataUnitConversionSetManager_.Get(id);
                if (calculationData != null)
                {
                    dataUnitConversionSetManager_.Update(id, value);
                }
                else
                {
                    logger_.LogWarning("The given DataUnitConversionSet cannot be retrieved from the database");
                }
            }
            else
            {
                logger_.LogWarning("The given DataUnitConversionSet is null or its ID is null or empty");
            }
        }

        // DELETE api/DataUnitConversionSets/f29b357f-8b76-4abe-ad84-4ccd5ccef77e
        [HttpDelete("{id}", Name = "DeleteDataUnitConversionSetById")]
        public void Delete(Guid id)
        {
            if (!id.Equals(Guid.Empty))
            {
                dataUnitConversionSetManager_.Remove(id);
            }
            else
            {
                logger_.LogWarning("The given DataUnitConversionSet ID is null or empty");
            }
        }
    }
}
