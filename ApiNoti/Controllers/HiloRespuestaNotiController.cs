using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNoti.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiNoti.Controllers;
public class HiloRespuestaNotiController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public HiloRespuestaNotiController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<HiloRespuestaNotDto>>> Get()
    {
        var hilo = await _unitOfWork.HilosRespuestasNotis.GetAllAsync();

        return _mapper.Map<List<HiloRespuestaNotDto>>(hilo);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<HiloRespuestaNotDto>> Get(int id){
        var hilo = await _unitOfWork.HilosRespuestasNotis.GetByIdAsync(id);
        if (hilo == null){
            return NotFound();
        }
        return _mapper.Map<HiloRespuestaNotDto>(hilo);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<HiloRespuestaNotDto>> Post(HiloRespuestaNotDto hiloRespuestaNotDto){
        var hilo = _mapper.Map<HiloRespuestaNotificacion>(hiloRespuestaNotDto);
        _unitOfWork.HilosRespuestasNotis.Add(hilo);
        await _unitOfWork.SaveAsync();
        if(hilo == null){
            return BadRequest();
        }
        hiloRespuestaNotDto.Id = hilo.Id;
        return CreatedAtAction(nameof(Post), new {id = hiloRespuestaNotDto.Id}, hiloRespuestaNotDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<HiloRespuestaNotDto>> Put(int id, [FromBody]HiloRespuestaNotDto hiloRespuestaNotDto){
        if(hiloRespuestaNotDto.Id == 0){
            hiloRespuestaNotDto.Id = id;
        }

        if(hiloRespuestaNotDto.Id != id){
            return BadRequest();
        }

        if(hiloRespuestaNotDto == null){
            return NotFound();
        }
        var hilo = _mapper.Map<HiloRespuestaNotificacion>(hiloRespuestaNotDto);
        _unitOfWork.HilosRespuestasNotis.Update(hilo);
        await _unitOfWork.SaveAsync();
        return hiloRespuestaNotDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var hilo = await _unitOfWork.HilosRespuestasNotis.GetByIdAsync(id);
        if(hilo == null){
            return NotFound();
        }
        _unitOfWork.HilosRespuestasNotis.Remove(hilo);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}
