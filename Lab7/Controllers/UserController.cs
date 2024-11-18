using Lab7.Models;
using Lab7.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab7.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(IUserService historyService) : ControllerBase
{
    private readonly IUserService _historyService = historyService;


    [HttpGet]
    public Task<IEnumerable<User>> Get()
    {
        return _historyService.GetAllAsync();
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetById(Guid id)
    {
        return await _historyService.GetByIdAsync(id) is { } data ? data : NotFound();
    }


    [HttpPost]
    public async Task<ActionResult<User>> Post(User product)
    {
        product = await _historyService.CreateAsync(product);
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    }


    [HttpPut]
    public async Task<IActionResult> Update(User product)
    {
        return await _historyService.UpdateAsync(product) ? NoContent() : NotFound();
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        return await _historyService.DeleteAsync(id) ? NoContent() : NotFound();
    }
}
