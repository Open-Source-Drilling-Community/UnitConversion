using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OSDC.DotnetLibraries.General.DataManagement;

namespace OSDC.UnitConversion.Service.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class UnitConversionSetController : ControllerBase
    {
        private readonly ILogger logger_;
        private readonly UnitConversionSetManager unitConversionSetManager_;

        public UnitConversionSetController(ILoggerFactory loggerFactory)
        {
            logger_ = loggerFactory.CreateLogger<UnitConversionSetController>();
            unitConversionSetManager_ = UnitConversionSetManager.GetInstance(logger_);
            DatabaseCleaner.Instance.Activate(); // activates the singleton DatabaseCleaner that deletes records older than a predefined time (default 1000h) from the microservice database
        }

        /// <summary>
        /// Returns the list of Guid of all UnitConversionSet present in the microservice database at endpoint TplProjectName/api/UnitConversionSet
        /// </summary>
        /// <returns>the list of Guid of all UnitConversionSet present in the microservice database at endpoint TplProjectName/api/UnitConversionSet</returns>
        [HttpGet(Name = "GetAllUnitConversionSetId")]
        public ActionResult<IEnumerable<Guid>> GetAllUnitConversionSetId()
        {
            var ids = unitConversionSetManager_.GetAllUnitConversionSetId();
            if (ids != null)
            {
                return Ok(ids);
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Returns the list of MetaInfo of all UnitConversionSet present in the microservice database, at endpoint TplProjectName/api/UnitConversionSet/MetaInfo
        /// </summary>
        /// <returns>the list of MetaInfo of all UnitConversionSet present in the microservice database, at endpoint TplProjectName/api/UnitConversionSet/MetaInfo</returns>
        [HttpGet("MetaInfo", Name = "GetAllUnitConversionSetMetaInfo")]
        public ActionResult<IEnumerable<MetaInfo>> GetAllUnitConversionSetMetaInfo()
        {
            var vals = unitConversionSetManager_.GetAllUnitConversionSetMetaInfo();
            if (vals != null)
            {
                return Ok(vals);
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Returns the UnitConversionSet identified by its Guid from the microservice database, at endpoint TplProjectName/api/UnitConversionSet/MetaInfo/id
        /// </summary>
        /// <param name="guid"></param>
        /// <returns>the UnitConversionSet identified by its Guid from the microservice database, at endpoint TplProjectName/api/UnitConversionSet/MetaInfo/id</returns>
        [HttpGet("{id}", Name = "GetUnitConversionSetById")]
        public ActionResult<Model.UnitConversionSet> GetUnitConversionSetById(Guid id)
        {
            if (!id.Equals(Guid.Empty))
            {
                var val = unitConversionSetManager_.GetUnitConversionSetById(id);
                if (val != null)
                {
                    return Ok(val);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Returns the list of all UnitConversionSet present in the microservice database, at endpoint TplProjectName/api/UnitConversionSet/HeavyData
        /// </summary>
        /// <returns>the list of all UnitConversionSet present in the microservice database, at endpoint TplProjectName/api/UnitConversionSet/HeavyData</returns>
        [HttpGet("HeavyData", Name = "GetAllUnitConversionSet")]
        public ActionResult<IEnumerable<Model.UnitConversionSet>> GetAllUnitConversionSet()
        {
            var vals = unitConversionSetManager_.GetAllUnitConversionSet();
            if (vals != null)
            {
                return Ok(vals);
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        /// Performs calculation on the given UnitConversionSet and adds it to the microservice database, at the endpoint TplProjectName/api/UnitConversionSet
        /// </summary>
        /// <param name="unitConversionSet"></param>
        /// <returns>true if the given UnitConversionSet has been added successfully to the microservice database, at the endpoint TplProjectName/api/UnitConversionSet</returns>
        [HttpPost(Name = "PostUnitConversionSet")]
        public ActionResult PostUnitConversionSet([FromBody] Model.UnitConversionSet value)
        {
            if (value != null && value.MetaInfo != null && value.MetaInfo.ID != Guid.Empty)
            {
                Model.UnitConversionSet unitConversionSet = unitConversionSetManager_.GetUnitConversionSetById(value.MetaInfo.ID);
                if (unitConversionSet == null)
                {
                    if (unitConversionSetManager_.AddUnitConversionSet(value))
                    {
                        return Ok(); // status=OK is used rather than status=Created because NSwag auto-generated controllers use 200 (OK) rather than 201 (Created) as return codes
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status500InternalServerError);
                    }
                }
                else
                {
                    logger_.LogWarning("The given UnitConversionSet already exists and will not be added");
                    return StatusCode(StatusCodes.Status409Conflict);
                }
            }
            else
            {
                logger_.LogWarning("The given UnitConversionSet is null or its ID is empty");
                return BadRequest();
            }
        }

        /// <summary>
        /// Performs calculation on the given UnitConversionSet and updates it in the microservice database, at the endpoint TplProjectName/api/UnitConversionSet/id
        /// </summary>
        /// <param name="unitConversionSet"></param>
        /// <returns>true if the given UnitConversionSet has been updated successfully to the microservice database, at the endpoint TplProjectName/api/UnitConversionSet/id</returns>
        [HttpPut("{id}", Name = "PutUnitConversionSetById")]
        public ActionResult PutUnitConversionSetById(Guid id, [FromBody] Model.UnitConversionSet value)
        {
            if (value != null && value.MetaInfo != null && value.MetaInfo.ID.Equals(id))
            {
                Model.UnitConversionSet unitConversionSet = unitConversionSetManager_.GetUnitConversionSetById(id);
                if (unitConversionSet != null)
                {
                    if (unitConversionSetManager_.UpdateUnitConversionSetById(id, value))
                    {
                        return Ok();
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status500InternalServerError);
                    }
                }
                else
                {
                    logger_.LogWarning("The given UnitConversionSet has not been found in the database");
                    return NotFound();
                }
            }
            else
            {
                logger_.LogWarning("The given UnitConversionSet is null or its does not match the ID to update");
                return BadRequest();
            }
        }

        /// <summary>
        /// Deletes the UnitConversionSet of given ID from the microservice database, at the endpoint TplProjectName/api/UnitConversionSet/id
        /// </summary>
        /// <param name="guid"></param>
        /// <returns>true if the UnitConversionSet was deleted from the microservice database, at the endpoint TplProjectName/api/UnitConversionSet/id</returns>
        [HttpDelete("{id}", Name = "DeleteUnitConversionSetById")]
        public ActionResult DeleteUnitConversionSetById(Guid id)
        {
            if (unitConversionSetManager_.GetUnitConversionSetById(id) != null)
            {
                if (unitConversionSetManager_.DeleteUnitConversionSetById(id))
                {
                    return Ok();
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            else
            {
                logger_.LogWarning("The UnitConversionSet of given ID does not exist");
                return NotFound();
            }
        }
    }
}
