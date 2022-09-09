using Imovel.Application.InputModels;
using Imovel.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Imovel.API.Controllers
{
  
        [Route("api/projects")]
        public class ProjectsController : ControllerBase
        {
            private readonly IProjectService _projectService;
            public ProjectsController(IProjectService projectService)
            {
                _projectService = projectService;
            }

            // api/projects?query=net core
            [HttpGet]
            public IActionResult Get(string query)
            {
                var projects = _projectService.GetAll(query);

                return Ok(projects);
            }

            // api/projects/2
            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                var project = _projectService.GetById(id);

                if (project == null)
                {
                    return NotFound();
                }

                return Ok(project);
            }

            [HttpPost]
            public IActionResult Post([FromBody] CreateProjectInputModel inputModel)
            {
                if (inputModel.Titulo.Length > 50)
                {
                    return BadRequest();
                }

                var id = _projectService.Create(inputModel);

                return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
            }

            // api/projects/2
            [HttpPut("{id}")]
            public IActionResult Put(int id, [FromBody] UpdateProjectInputModel inputModel)
            {
                if (inputModel.Descricao.Length > 200)
                {
                    return BadRequest();
                }

                _projectService.Update(inputModel);

                return NoContent();
            }

            // api/projects/3 DELETE
            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                _projectService.Delete(id);

                return NoContent();
            }

            // api/projects/1/comments POST
            [HttpPost("{id}/comments")]
            public IActionResult PostComment(int id, [FromBody] CreateCommentInputModel inputModel)
            {
                _projectService.CreateComment(inputModel);

                return NoContent();
            }

           
        }
   }


