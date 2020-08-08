using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Controllers
{
    [ApiController]
    [Route("api/auth/login")]
    public class LoginController : ControllerBase
    {

        private readonly HttpClient _client;
        public LoginController(HttpClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {

            var tokenResponse = await _client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = "http://localhost:44306/connect/token",
                ClientId = "clientId",
                ClientSecret = "clientsecret",
                Scope = "microservice"
            });

            return Ok(tokenResponse.Json);
        }
    }
}