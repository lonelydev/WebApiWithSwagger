using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApiWithSwagger.Controllers
{
  /// <summary>
  /// Awesome value controller!
  /// </summary>
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    /// <summary>
    /// Get all values!
    /// </summary>
    /// <returns></returns>
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "value1", "value2" };
    }

    /// <summary>
    /// Get a specific value
    /// </summary>
    /// <param name="id">id of the value</param>
    /// <returns></returns>
    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return "value";
    }

    /// <summary>
    /// Add new value
    /// </summary>
    /// <param name="value"> value as a string</param>
    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    /// <summary>
    /// update an existing value
    /// </summary>
    /// <param name="id">id of the value</param>
    /// <param name="value">value of the value as a string</param>
    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    /// <summary>
    /// delete an existing value
    /// </summary>
    /// <param name="id">id of the value that you want to delete</param>
    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
