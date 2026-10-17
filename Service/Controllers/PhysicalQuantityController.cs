using OSDC.UnitConversion.Service;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;
using OSDC.UnitConversion.Model;

namespace OSDC.UnitConversion.Service.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class PhysicalQuantityController : ControllerBase
    {
        /// <summary>Discover PhysicalQuantity resources as bounded light records; retrieve selected full records by ID.</summary>
        [HttpGet("LightData", Name = "DiscoverPhysicalQuantity")]
        public ActionResult<OSDC.UnitConversion.Model.PhysicalQuantityDiscoveryPage> DiscoverPhysicalQuantity([FromQuery] int offset = 0, [FromQuery] int limit = 50, [FromQuery] string? name = null)
        {
            UsageStatistics.Instance.IncrementDiscoveryRequestsPerDay();
            if (offset < 0 || limit < 1 || limit > 200 || name?.Length > 200)
                return BadRequest(new { error = "invalid_discovery_query", message = "Offset must be non-negative, limit 1–200, name at most 200 characters, and UUID filters non-empty." });
            var source = GetAllPhysicalQuantity();
            if (source.Result is Microsoft.AspNetCore.Mvc.ObjectResult result && result.StatusCode is >= 400)
                return StatusCode(result.StatusCode.Value, result.Value);
            var values = source.Value ?? (source.Result as Microsoft.AspNetCore.Mvc.ObjectResult)?.Value as System.Collections.Generic.IEnumerable<DrillingPhysicalQuantity>;
            if (values == null) return StatusCode(500, new { error = "discovery_failed" });
            var records = DiscoveryRecords.Page<OSDC.UnitConversion.Model.PhysicalQuantityLight>(values, offset, limit, name,
                new System.Collections.Generic.Dictionary<string, object?> {  }, out int total);
            return Ok(new OSDC.UnitConversion.Model.PhysicalQuantityDiscoveryPage { Items = records, Offset = offset, Limit = limit, TotalCount = total,
                NextOffset = offset < total && records.Count < total - offset ? offset + records.Count : null });
        }

        private readonly ILogger _logger;

        public PhysicalQuantityController(ILogger<PhysicalQuantityController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Returns the list of Guid of all PhysicalQuantity present in the microservice database at endpoint UnitConversion/api/PhysicalQuantity
        /// </summary>
        /// <returns>the list of Guid of all PhysicalQuantity present in the microservice database at endpoint UnitConversion/api/PhysicalQuantity</returns>
        [HttpGet(Name = "GetAllPhysicalQuantityId")]
        public ActionResult<IEnumerable<Guid>> GetAllPhysicalQuantityId()
        {
            UsageStatistics.Instance.IncrementPhysicalQuantityControllerGetAllIDPerDay();
            List<Guid> ids = [];
            try
            {
                HashSet<BasePhysicalQuantity> quantityHashSet = [];
                quantityHashSet.UnionWith(BasePhysicalQuantity.AvailableBasePhysicalQuantities);
                quantityHashSet.UnionWith(DrillingPhysicalQuantity.AvailablePhysicalQuantities);
                foreach (BasePhysicalQuantity qty in quantityHashSet)
                {
                    ids.Add(qty.ID);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Problem while getting available physical quantities");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(ids);
        }

        /// <summary>
        /// Returns the PhysicalQuantity identified by its Guid, at endpoint UnitConversion/api/PhysicalQuantity/id
        /// </summary>
        /// <param name="guid"></param>
        /// <returns>the PhysicalQuantity identified by its Guid, at endpoint UnitConversion/api/PhysicalQuantity/id</returns>
        [HttpGet("{id}", Name = "GetPhysicalQuantityById")]
        public ActionResult<DrillingPhysicalQuantity> GetPhysicalQuantityById(Guid id)
        {
            UsageStatistics.Instance.IncrementPhysicalQuantityControllerGetByIDPerDay();
            if (!id.Equals(Guid.Empty))
            {
                BasePhysicalQuantity qty = DrillingPhysicalQuantity.GetQuantity(id);
                if (qty != null)
                {
                    return Ok(qty);
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
        /// Returns the list of all PhysicalQuantity present in the microservice database, at endpoint UnitConversion/api/PhysicalQuantity/HeavyData
        /// </summary>
        /// <returns>the list of all PhysicalQuantity present in the microservice database, at endpoint UnitConversion/api/PhysicalQuantity/HeavyData</returns>
        [NonAction]
        public ActionResult<IEnumerable<DrillingPhysicalQuantity>> GetAllPhysicalQuantity()
        {
            UsageStatistics.Instance.IncrementPhysicalQuantityControllerGetAllPerDay();
            try
            {
                HashSet<BasePhysicalQuantity> quantityHashSet = [];
                quantityHashSet.UnionWith(BasePhysicalQuantity.AvailableBasePhysicalQuantities);
                quantityHashSet.UnionWith(DrillingPhysicalQuantity.AvailablePhysicalQuantities);
                return Ok(quantityHashSet);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Problem while getting available physical quantities");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
