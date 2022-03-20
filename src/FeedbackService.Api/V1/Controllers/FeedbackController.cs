using FeedbackService.Core.Models;
using FeedbackService.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackService.Api.V1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {

        private readonly IFeedbackService _feedbackService;
        public FeedbackController(IFeedbackService feedbackService) 
        {
            _feedbackService =feedbackService ?? throw new ArgumentNullException(nameof(feedbackService));  

        }


        [HttpGet]
        [Route("getFeedbacks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Feedback>>> GetFeedbacks()
        {
            var response = await _feedbackService.GetAllFeedbacks();

            if (response == null)
            {
                return NoContent();
            }
            return Ok(response);
        }
    }
}
