using System.Net;
using API.Errors;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  public class BugController : BaseApiController
  {
    private readonly StoreContext _context;
    public BugController(StoreContext context)
    {
      _context = context;
    }

    [HttpGet("notfound")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public ActionResult GetNotFoundRequest()
    {
      var thing = _context.Products.Find(42);

      if (thing == null)
      {
        return NotFound(new ApiResponse(404));
      }
      
      return Ok();
    }

    [HttpGet("servererror")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status500InternalServerError)]
    public ActionResult GetServerError()
    {
      var thing = _context.Products.Find(42);

      var thingToReturn = thing.ToString();

      return Ok();
    }

    [HttpGet("badrequest")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public ActionResult GetBadRequest()
    {
      return BadRequest(new ApiResponse(400));
    }

    [HttpGet("badrequest/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public ActionResult GetNotFoundRequest(int id)
    {
      return Ok();
    }
  }
}