using AutoMapper;
using Business.Business.BusinessServices;
using Edulms.Business.BusinessServices;
using Edulms.Business.IBusinessServices;
using Edulms.DTO;
using Edulms.Shared.OperationResult;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edulms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssessmentAnswerController : ControllerBase
    {
        private readonly IAssessmentAnswerService  _assessmentAnswer;
        private readonly ILogger<AssessmentAnswerController> _logger;
        private readonly IMapper _mapper;

        public AssessmentAnswerController(IAssessmentAnswerService assessmentAnswer, ILogger<AssessmentAnswerController> logger, IMapper mapper)
        {
            _assessmentAnswer = assessmentAnswer;
            _logger = logger;
            _mapper = mapper;
        }

        [Route("AddAssignmentAnswer")]
        [AllowAnonymous]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddAssignmentAnswer([FromBody] AssessmentAnswerDto answerDto)
        {
            try
            {
                var result = await _assessmentAnswer.Add(answerDto);

                if (result.Result == QueryResult.Succeeded)
                {
                    return Ok();
                }
                else
                {
                    return StatusCode(500, "Failed to add assessment answer");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(AddAssignmentAnswer)}");
                return StatusCode(500, "Internal server Error. Please try later");
            }
        }

    }
}
