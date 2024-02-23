using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNet7WebApi.BlogRepositoryPattern.AppDbContextModels;

namespace DotNet7WebApi.BlogRepositoryPattern.Feature
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly IBlogRepository _blogRepository;
        private readonly ILogger<BlogController> _logger;

        public BlogController(IBlogRepository blogRepository, ILogger<BlogController> logger)
        {
            _blogRepository = blogRepository ?? throw new ArgumentNullException(nameof(blogRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            try
            {
                var blogs = await _blogRepository.GetAllBlogs();
                return Ok(blogs);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching blog list");
                return BadRequest("Something went wrong.");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogById(string id)
        {
            try
            {
                var blog = await _blogRepository.GetBlogById(id);

                if (blog == null)
                    return NotFound();

                return Ok(blog);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching blog by Id");
                return BadRequest("Something went wrong.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> BlogCreate([FromBody] BlogRequestModel requestModel)
        {
            try
            {
                var createdBlog = await _blogRepository.BlogCreate(requestModel);
                return Ok(createdBlog);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating a new blog");
                return BadRequest("Something went wrong.");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBlog(string id, BlogRequestModel requestModel)
        {
            try
            {
                var updatedBlog = await _blogRepository.UpdateBlog(id, requestModel);

                if (updatedBlog is null) return NotFound();
                return Ok(updatedBlog);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating the blog");
                return BadRequest("Something went wrong.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog(string id)
        {
            try
            {
                var deletedBlog = await _blogRepository.DeleteBlog(id);
                if (deletedBlog == null) return NotFound();
                return Ok(deletedBlog);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting the blog");
                return BadRequest("Something went wrong.");
            }
        }
    }
}
