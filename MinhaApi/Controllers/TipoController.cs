using MinhaApi.Models;
using MinhaApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Reflection.Metadata.Ecma335;

[ApiController]
[Route("api/[controller]")] 
public class TipoCrontoller 
    :  ControllerBase
{
    private readonly ITipoService _service;

    public TipoController(
        ITipoService service)
       => _service = service;

    [HttpGet]
    
    public IActionResult GetAll()
    {
        var tipo = _service.GetAll();
        return Ok(tipo);
    }

    [HttpGet("{id}")]

    public IActionResult GetByid(int id)
    {
        
    }


}    

