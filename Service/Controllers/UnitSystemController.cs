using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OSDC.UnitConversion.Conversion.DrillingEngineering;
using OSDC.UnitConversion.Conversion.UnitSystem.DrillingEngineering;

namespace OSDC.UnitConversion.Service.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class UnitSystemController : ControllerBase
    {
        private readonly ILogger<UnitSystemManager> _logger;
        private readonly UnitSystemManager _unitSystemManager;

        public UnitSystemController(ILogger<UnitSystemManager> logger, SqlConnectionManager connectionManager)
        {
            _logger = logger;
            _unitSystemManager = UnitSystemManager.GetInstance(_logger, connectionManager);
        }

        /// <summary>
        /// Returns the list of Guid of all UnitSystem present in the microservice database at endpoint UnitConversion/api/UnitSystem
        /// </summary>
        /// <returns>the list of Guid of all UnitSystem present in the microservice database at endpoint UnitConversion/api/UnitSystem</returns>
        [HttpGet(Name = "GetAllUnitSystemId")]
        public ActionResult<IEnumerable<Guid>> GetAllUnitSystemId()
        {
            var ids = _unitSystemManager.GetAllUnitSystemId();
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
        /// Returns the UnitSystem identified by its Guid from the microservice database, at endpoint UnitConversion/api/UnitSystem/MetaInfo/id
        /// </summary>
        /// <param name="guid"></param>
        /// <returns>the UnitSystem identified by its Guid from the microservice database, at endpoint UnitConversion/api/UnitSystem/MetaInfo/id</returns>
        [HttpGet("{id}", Name = "GetUnitSystemById")]
        public ActionResult<UnitSystem> GetUnitSystemById(Guid id)
        {
            if (!id.Equals(Guid.Empty))
            {
                var val = _unitSystemManager.GetUnitSystemById(id);
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
        /// Returns the list of all UnitSystemLight present in the microservice database, at endpoint UnitConversion/api/UnitSystem/LightData
        /// </summary>
        /// <returns>the list of all UnitSystem present in the microservice database, at endpoint UnitConversion/api/UnitSystem/LightData</returns>
        [HttpGet("LightData", Name = "GetAllUnitSystemLight")]
        public ActionResult<IEnumerable<UnitSystemLight>> GetAllUnitSystemLight()
        {
            var vals = _unitSystemManager.GetAllUnitSystemLight();
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
        /// Returns the list of all UnitSystem present in the microservice database, at endpoint UnitConversion/api/UnitSystem/HeavyData
        /// </summary>
        /// <returns>the list of all UnitSystem present in the microservice database, at endpoint UnitConversion/api/UnitSystem/HeavyData</returns>
        [HttpGet("HeavyData", Name = "GetAllUnitSystem")]
        public ActionResult<IEnumerable<UnitSystem>> GetAllUnitSystem()
        {
            var vals = _unitSystemManager.GetAllUnitSystem();
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
        /// Performs calculation on the given UnitSystem and adds it to the microservice database, at the endpoint UnitConversion/api/UnitSystem
        /// </summary>
        /// <param name="unitSystem"></param>
        /// <returns>true if the given UnitSystem has been added successfully to the microservice database, at the endpoint UnitConversion/api/UnitSystem</returns>
        [HttpPost(Name = "PostUnitSystem")]
        public ActionResult PostUnitSystem([FromBody] UnitSystem value)
        {
            if (value != null && value.ID != Guid.Empty)
            {
                UnitSystem? unitSystem = _unitSystemManager.GetUnitSystemById(value.ID);
                if (unitSystem == null)
                {
                    if (_unitSystemManager.AddUnitSystem(value))
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
                    _logger.LogWarning("The given UnitSystem already exists and will not be added");
                    return StatusCode(StatusCodes.Status409Conflict);
                }
            }
            else
            {
                _logger.LogWarning("The given UnitSystem is null or its ID is empty");
                return BadRequest();
            }
        }

        /// <summary>
        /// Performs calculation on the given UnitSystem and updates it in the microservice database, at the endpoint UnitConversion/api/UnitSystem/id
        /// </summary>
        /// <param name="unitSystem"></param>
        /// <returns>true if the given UnitSystem has been updated successfully to the microservice database, at the endpoint UnitConversion/api/UnitSystem/id</returns>
        [HttpPut("{id}", Name = "PutUnitSystemById")]
        public ActionResult PutUnitSystemById(Guid id, [FromBody] UnitSystem value)
        {
            if (value != null && value.ID.Equals(id))
            {
                UnitSystem? unitSystem = _unitSystemManager.GetUnitSystemById(id);
                if (unitSystem != null)
                {
                    if (_unitSystemManager.UpdateUnitSystemById(id, value))
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
                    _logger.LogWarning("The given UnitSystem has not been found in the database");
                    return NotFound();
                }
            }
            else
            {
                _logger.LogWarning("The given UnitSystem is null or its does not match the ID to update");
                return BadRequest();
            }
        }

        /// <summary>
        /// Deletes the UnitSystem of given ID from the microservice database, at the endpoint UnitConversion/api/UnitSystem/id
        /// </summary>
        /// <param name="guid"></param>
        /// <returns>true if the UnitSystem was deleted from the microservice database, at the endpoint UnitConversion/api/UnitSystem/id</returns>
        [HttpDelete("{id}", Name = "DeleteUnitSystemById")]
        public ActionResult DeleteUnitSystemById(Guid id)
        {
            if (_unitSystemManager.GetUnitSystemById(id) != null)
            {
                if (_unitSystemManager.DeleteUnitSystemById(id))
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
                _logger.LogWarning("The UnitSystem of given ID does not exist");
                return NotFound();
            }
        }
    }
}
