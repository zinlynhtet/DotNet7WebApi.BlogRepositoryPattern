using DotNet7.WebApi.AppDbContextModels;
using DotNet7.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Serilog;

namespace DotNet7.WebApi.Feature
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepository;
        private readonly ILogger <BlogController> _logger;

        public BlogController(IBlogRepository blogRepository, ILogger<BlogController> logger)
        {
            _blogRepository = blogRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            try
            {
                var lst = await _blogRepository.GetAllBlogs();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.ToString());
                return BadRequest("Something went wrong.");
            }
        }

        //[HttpPost]
        //public async Task<IActionResult> BlogCreate(BlogRequestModel requestModel)
        //{
        //    var result = await _blogRepository.BlogCreate(requestModel);
        //    return Ok(result);
        //}
    }
}