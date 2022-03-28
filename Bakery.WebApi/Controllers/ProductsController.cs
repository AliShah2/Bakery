using Bakery.WebApi.Data;
using Bakery.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections;
using AutoMapper;
using Bakery.WebApi.Dtos;

namespace Bakery.WebApi.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository _productsRepo;
        private readonly IMapper _mapper;

        public ProductsController(IProductsRepository productsRepository, IMapper mapper)
        {
            this._productsRepo = productsRepository;
            this._mapper = mapper;
        }

        //GET api/products
        [HttpGet]
        public ActionResult<List<ProductReadDto>> GetAll()
        {
            var products = _productsRepo.GetAll();
            var productDtos = _mapper.Map<IList<ProductReadDto>>(products);
            
            return Ok(productDtos);
        }

        //GET api/products/{id}
        [HttpGet("{id}")]
        public ActionResult<List<ProductReadDto>> GetById(int id)
        {
            //TODO - add check if exists
            var product = _productsRepo.GetById(id);
            var productDto = _mapper.Map<ProductReadDto>(product);

            return Ok(productDto);
        }

        //POST api/products
        [HttpPost]
        public ActionResult CreateProduct(ProductCreateDto productCreateDto)
        {            
            var product = _mapper.Map<Product>(productCreateDto);

            _productsRepo.Create(product);
            _productsRepo.SaveChanges();

            return NoContent();
        }

        //DELETE api/products/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            //check if exists, if not return notfound
            var productFromDb = _productsRepo.GetById(id);
            if (productFromDb == null)
            {
                return NotFound();
            }

            _productsRepo.Delete(productFromDb);
            _productsRepo.SaveChanges();
            return NoContent();
        }

        //PATCH api/products
        [HttpPatch("{id}")]
        public ActionResult UpdateProduct(int id, ProductUpdateDto productUpdateDto)
        {
            //check if exists, if not return notfound
            var productFromDb = _productsRepo.GetById(id);
            if (productFromDb == null)
            {
                return NotFound();
            }

            _mapper.Map(productUpdateDto, productFromDb);
            _productsRepo.SaveChanges();
            return NoContent();
        }


    }
}
