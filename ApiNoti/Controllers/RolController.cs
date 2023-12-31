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
public class RolController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RolController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<RolDto>>> Get()
    {
        var rol = await _unitOfWork.Roles.GetAllAsync();

        return _mapper.Map<List<RolDto>>(rol);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<RolDto>> Get(int id){
        var rol = await _unitOfWork.Roles.GetByIdAsync(id);
        if (rol == null){
            return NotFound();
        }
        return _mapper.Map<RolDto>(rol);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<RolDto>> Post(RolDto RolDto){
        var rol = _mapper.Map<Rol>(RolDto);
        _unitOfWork.Roles.Add(rol);
        await _unitOfWork.SaveAsync();
        if(rol == null){
            return BadRequest();
        }
        RolDto.Id = rol.Id;
        return CreatedAtAction(nameof(Post), new {id = RolDto.Id}, RolDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<RolDto>> Put(int id, [FromBody]RolDto RolDto){
        if(RolDto.Id == 0){
            RolDto.Id = id;
        }

        if(RolDto.Id != id){
            return BadRequest();
        }

        if(RolDto == null){
            return NotFound();
        }
        var rol = _mapper.Map<Rol>(RolDto);
        _unitOfWork.Roles.Update(rol);
        await _unitOfWork.SaveAsync();
        return RolDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id){
        var rol = await _unitOfWork.Roles.GetByIdAsync(id);
        if(rol == null){
            return NotFound();
        }
        _unitOfWork.Roles.Remove(rol);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}
