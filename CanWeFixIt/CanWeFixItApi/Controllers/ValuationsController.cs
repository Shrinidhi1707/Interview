using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CanWeFixItService;

namespace CanWeFixItApi.Controllers
{
    [ApiController]
    [Route("v1/valuations")]
    public class ValuationsController : ControllerBase
    {
        private readonly IDatabaseService _database;
        
        public ValuationsController(IDatabaseService database)
        {
            _database = database;
        }
        
        // GET
        public async Task<ActionResult<IEnumerable<MarketValuation>>> Get()
        {   
            return Ok(_database.Valuations().Result);
        }
    }
}