using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Restaurant.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register()
        {
            //var errorMessage = await _authService.Register(model);
            //if (!string.IsNullOrEmpty(errorMessage))
            //{
            //    _response.IsSuccess = false;
            //    _response.Message = errorMessage;
            //    return BadRequest(_response);
            //}
            //await _messageBus.PublishMessage(model.Email, _configuration.GetValue<string>("TopicAndQueueNames:RegisterUserQueue"));
            //return Ok(_response);
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            //var loginResponse = await _authService.Login(model);
            //if (loginResponse.User == null)
            //{
            //    _response.IsSuccess = false;
            //    _response.Message = "Username or password is incorrect";
            //    return BadRequest(_response);
            //}
            //_response.Result = loginResponse;
            //return Ok(_response);
            return Ok();
        }
    }
}
