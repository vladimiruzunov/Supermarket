using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Supermarket.BL.Interfaces;
using Supermarket.Models.DTO;
using Supermarket.Models.Request;
using Supermarket.Models.Response;

namespace Supermarket1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(IProductService productService, IMapper mapper)
        {

            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();


            return Ok(result);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            if (id <= 0) return BadRequest();

            var result = _productService.GetById(id);

            if (result == null) return NotFound(id);

            var response = _mapper.Map<ProductResponse>(result);

            return Ok(response);
        }
        [HttpPost("Create")]
        public IActionResult CreateEmployee([FromBody] ProductRequest carRequest)
        {
            if (carRequest == null) return BadRequest();

            var car = _mapper.Map<Product>(carRequest);
            var result = _productService.Create(car);

            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0) return BadRequest(id);

            var result = _productService.Delete(id);

            if (result == null) return NotFound(id);

            return Ok(result);
        }

        [HttpPost("Update")]
        public IActionResult Update([FromBody] ProductUpdateRequest productRequest)
        {
            if (productRequest == null) return BadRequest();

            var searchProduct = _productService.GetById(productRequest.Id);

            if (searchProduct == null) return NotFound(productRequest.Id);

            searchProduct.Name = productRequest.Name;
            searchProduct.Price = productRequest.Price;
            var result = _productService.Update(searchProduct);

            return Ok(result);
        }

    }
}
