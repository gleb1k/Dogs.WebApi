using Dogs.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dogs.WebApi.Controllers;


[Route("[controller]")]
[ApiController]
public class EmailController : ControllerBase
{
    private readonly IEmailService _emailService;

    public EmailController(IEmailService emailService)
    {
        _emailService = emailService;
    }

    //post mail
    [HttpPost]
    public IActionResult SendEmailMessage([FromForm] string email, [FromForm] string comment, [FromForm] string tel)
    {
        _emailService.SendEmailAsync(email, "TEST", comment + $"телефон: {tel}");
        return Ok();
    }
}

