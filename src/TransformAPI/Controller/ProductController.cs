using Microsoft.AspNetCore.Mvc;
using TransformAPI.Model.Entity;

namespace TransformAPI.Controller;

public class ProductController
{
    [Route("Product")]
    [ApiController]
    public class ValidationsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(ProductEntity data)
        {
            return Ok(data);
        }
    }
}