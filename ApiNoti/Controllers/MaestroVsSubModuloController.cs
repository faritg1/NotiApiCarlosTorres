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
public class MaestroVsSubModuloController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public MaestroVsSubModuloController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<MestroVsSubModuloDto>>> Get()
    {
        var maestro = await _unitOfWork.MaestrosVsSubModulos.GetAllAsync();

        return _mapper.Map<List<MestroVsSubModuloDto>>(maestro);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<MestroVsSubModuloDto>> Get(int id){
        var maestro = await _unitOfWork.MaestrosVsSubModulos.GetByIdAsync(id);
        if (maestro == null){
            return NotFound();
        }
        return _mapper.Map<MestroVsSubModuloDto>(maestro);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<MestroVsSubModuloDto>> Post(MestroVsSubModuloDto MestroVsSubModuloDto){
        var maestro = _mapper.Map<MaestroVsSubModulo>(MestroVsSubModuloDto);
        _unitOfWork.MaestrosVsSubModulos.Add(maestro);
        await _unitOfWork.SaveAsync();
        if(maestro == null){
            return BadRequest();
        }
        MestroVsSubModuloDto.Id = maestro.Id;
        return CreatedAtAction(nameof(Post), new {id = MestroVsSubModuloDto.Id}, MestroVsSubModuloDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<MestroVsSubModuloDto>> Put(int id, [FromBody]MestroVsSubModuloDto MestroVsSubModuloDto){
        if(MestroVsSubModuloDto.Id == 0){
            MestroVsSubModuloDto.Id = id;
        }

        if(MestroVsSubModuloDto.Id != id){
            return BadRequest();
        }

        if(MestroVsSubModuloDto == null){
            return NotFound();
        }
        var maestro = _mapper.Map<MaestroVsSubModulo>(MestroVsSubModuloDto);
        _unitOfWork.MaestrosVsSubModulos.Update(maestro);
        await _unitOfWork.SaveAsync();
        return MestroVsSubModuloDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var maestro = await _unitOfWork.MaestrosVsSubModulos.GetByIdAsync(id);
        if(maestro == null){
            return NotFound();
        }
        _unitOfWork.MaestrosVsSubModulos.Remove(maestro);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}
