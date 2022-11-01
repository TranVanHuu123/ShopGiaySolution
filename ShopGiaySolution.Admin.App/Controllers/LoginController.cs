using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using ShopGiaySolution.ApiIntegration;
using ShopGiaySolution.Utilities.Constants;
using ShopGiaySolution.ViewModels.System.Users;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ShopGiaySolution.Admin.App.Controllers
{
    public class LoginController : Controller
    {
        public readonly IUserApiClient _userApiClient;
        public readonly IConfiguration _configuration;

        public LoginController(IUserApiClient userApiClient, IConfiguration configuration)
        {
            _userApiClient = userApiClient;
            _configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            //HttpContext.Session.Remove("Token");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginRequest request)
        {
            if (!ModelState.IsValid)
                return View(ModelState);

            var result = await _userApiClient.Authenticate(request);
            if (result.ResultObj == null)
            {
                ModelState.AddModelError("", result.Message!);
                return View();
            }

            var userPrincipal = this.ValidateToken(result.ResultObj!);
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                IsPersistent = false
            };
            HttpContext.Session.SetString(SystemConstants.AppSettings.DefaultLanguageId, _configuration[SystemConstants.AppSettings.DefaultLanguageId]);
            HttpContext.Session.SetString(SystemConstants.AppSettings.Token, result.ResultObj!);
            await HttpContext.SignInAsync(
                 CookieAuthenticationDefaults.AuthenticationScheme,
                 userPrincipal,
                 authProperties);

            return RedirectToAction("Index", "Home");

        }
        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;

            SecurityToken validatedToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters();

            validationParameters.ValidateLifetime = true;

            validationParameters.ValidAudience = _configuration["Tokens:Issuer"];
            validationParameters.ValidIssuer = _configuration["Tokens:Issuer"];
            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));

            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

            return principal;
        }
    }
}
