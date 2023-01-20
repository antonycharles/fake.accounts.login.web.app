using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Accounts.Login.WebApp.Pages;

public class RecoverPasswordModel : PageModel
{
    private readonly ILogger<RecoverPasswordModel> _logger;

    public RecoverPasswordModel(ILogger<RecoverPasswordModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}