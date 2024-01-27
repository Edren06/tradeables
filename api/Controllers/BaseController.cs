using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

public abstract class BaseController<TEntity, TService> : ControllerBase
    where TEntity : class
    where TService : IService<TEntity>
{
    protected readonly TService _service;

    public BaseController(TService service)
    {
        _service = service ?? throw new ArgumentNullException(nameof(service));
    }

    [HttpGet]
    public IActionResult Get()
    {
        var entities = _service.GetAll();
        return Ok(entities);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var entity = _service.GetById(id);
        if (entity == null)
        {
            return NotFound();
        }

        return Ok(entity);
    }

    [HttpPost]
    public IActionResult Post([FromBody] TEntity entity)
    {
        if (entity == null)
        {
            return BadRequest("Entity cannot be null");
        }

        _service.Add(entity);
        return CreatedAtAction(nameof(GetById), new { id = GetEntityId(entity) }, entity);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] TEntity entity)
    {
        if (entity == null || id != GetEntityId(entity))
        {
            return BadRequest("Invalid request");
        }

        var existingEntity = _service.GetById(id);
        if (existingEntity == null)
        {
            return NotFound();
        }

        _service.Update(entity);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var existingEntity = _service.GetById(id);
        if (existingEntity == null)
        {
            return NotFound();
        }

        _service.Delete(id);
        return NoContent();
    }

    // Abstract method to get the entity id, which should be implemented by derived classes
    protected abstract int GetEntityId(TEntity entity);
}