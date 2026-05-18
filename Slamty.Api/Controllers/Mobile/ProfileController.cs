using Microsoft.AspNetCore.Mvc;
using Slamty.Application.Features.UserProfile.Queries.GetProfile;

namespace Slamty.Api.Controllers.Mobile
{
    public class ProfileController : BaseMobileApiController
    {
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetProfile(string userId)
        {
            var response = await Mediator.Send(new GetProfileQuery(userId));
            return HandleResult(response);
        }
    }
}
