using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApi.Application.Dto.DTO;
using GameApi.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GameApi.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly IApplicationServiceTeam _applicationServiceTeam;

        public TeamController(IApplicationServiceTeam applicationServicePlayer)
        {
            this._applicationServiceTeam = applicationServicePlayer;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TeamDTO>> GetAll()
        {
            return Ok(_applicationServiceTeam.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<TeamDTO> Get(int id)
        {
            return Ok(_applicationServiceTeam.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] TeamDTO teamDTO)
        {
            try
            {
                if (teamDTO == null)
                    return NotFound();

                _applicationServiceTeam.Add(teamDTO);
                return Ok("OK");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] TeamDTO teamDTO)
        {
            try
            {
                if (teamDTO == null)
                    return NotFound();

                _applicationServiceTeam.Update(teamDTO);
                return Ok("Ok");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] TeamDTO teamDTO)
        {
            try
            {
                if (teamDTO == null)
                    return NotFound();

                _applicationServiceTeam.Remove(teamDTO);
                return Ok("OK");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
