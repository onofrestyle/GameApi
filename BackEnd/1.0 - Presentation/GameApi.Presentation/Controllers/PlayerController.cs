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
    public class PlayerController : ControllerBase
    {
        private readonly IApplicationServicePlayer _applicationServicePlayer;

        public PlayerController(IApplicationServicePlayer applicationServicePlayer)
        {
            this._applicationServicePlayer = applicationServicePlayer;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PlayerDTO>> GetAll()
        {
            return Ok(_applicationServicePlayer.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<PlayerDTO> Get(int id)
        {
            return Ok(_applicationServicePlayer.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] PlayerDTO playerDTO)
        {
            try
            {
                if (playerDTO == null)
                    return NotFound();

                _applicationServicePlayer.Add(playerDTO);
                return Ok("OK");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] PlayerDTO pLayerDto)
        {
            try
            {
                if (pLayerDto == null)
                    return NotFound();

                _applicationServicePlayer.Update(pLayerDto);
                return Ok("Ok");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] PlayerDTO pLayerDto)
        {
            try
            {
                if (pLayerDto == null)
                    return NotFound();

                _applicationServicePlayer.Remove(pLayerDto);
                return Ok("OK");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
