using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using atl_artist_api.Data;
using atl_artist_api.Models;
//TODO: Update to use DTO


namespace atl_artist_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtistController : ControllerBase
    {
       // public readonly IMapper _mapper;
       private readonly ArtistDbContext _artistDbContext;

        public ArtistController(ArtistDbContext artistDbContext) {
          
            _artistDbContext = artistDbContext;
        }


       [HttpGet]
       [Route("GetArtists")]
        public IActionResult GetArtists() {
            // add try / except
            ArtistDbContext? context = HttpContext.RequestServices.GetService(typeof(atl_artist_api.Data.ArtistDbContext)) as ArtistDbContext;
            //var players = await _playerContext.Players.ToListAsync();
            //var _mappedPlayer = _mapper.Map<Player>(player);
            return Ok(context.GetAllArtists());
}
       [HttpGet]
       [Route("{id:int}")]
        public IActionResult GetArtists(int id) {
            // add try / except
            ArtistDbContext? context = HttpContext.RequestServices.GetService(typeof(atl_artist_api.Data.ArtistDbContext)) as ArtistDbContext;
            //var players = await _playerContext.Players.ToListAsync();
            //var _mappedPlayer = _mapper.Map<Player>(player);
            return Ok(context.GetArtistById(id));
}
[HttpPut]
public void PutArtist(ArtistModel artist) {
        ArtistDbContext? context = HttpContext.RequestServices.GetService(typeof(atl_artist_api.Data.ArtistDbContext)) as ArtistDbContext;
        context.UpdateArtist(artist);
}


    }
}