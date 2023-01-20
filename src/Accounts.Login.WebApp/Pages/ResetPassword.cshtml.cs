using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Accounts.Login.WebApp.Pages;

public class ResetPasswordModel : PageModel
{
    private readonly ILogger<ResetPasswordModel> _logger;

    public ResetPasswordModel(ILogger<ResetPasswordModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}