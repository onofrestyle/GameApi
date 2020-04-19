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
    public class GameController : ControllerBase
    {
        private readonly IApplicationServiceGame _applicationServiceGame;

        public GameController(IApplicationServiceGame applicationServiceGame)
        {
            this._applicationServiceGame = applicationServiceGame;
        }

        [HttpGet]
        public ActionResult<IEnumerable<GameDTO>> GetAll()
        {
            return Ok(_applicationServiceGame.GetAll());
        }

        [HttpGet("GetUnfinishedGames")]
        public ActionResult<IEnumerable<GameDTO>> GetUnfinishedGames()
        {
            return Ok(_applicationServiceGame.GetAll().Where(x=> x.GameEnd == null));
        }

        [HttpGet("{id}")]
        public ActionResult<GameDTO> Get(int id)
        {
            return Ok(_applicationServiceGame.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] GameDTO gameDTO)
        {
            try
            {
                if (gameDTO == null)
                    return NotFound();

                _applicationServiceGame.Add(gameDTO);
                return Ok("OK");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] GameDTO gameDTO)
        {
            try
            {
                if (gameDTO == null)
                    return NotFound();

                _applicationServiceGame.Update(gameDTO);
                return Ok("Ok");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] GameDTO gameDTO)
        {
            try
            {
                if (gameDTO == null)
                    return NotFound();

                _applicationServiceGame.Remove(gameDTO);
                return Ok("OK");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
