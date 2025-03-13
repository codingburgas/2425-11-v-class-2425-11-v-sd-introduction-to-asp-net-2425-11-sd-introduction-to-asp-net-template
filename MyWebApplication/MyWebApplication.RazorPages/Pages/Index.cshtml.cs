using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApplication.RazorPages.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public static List<UserModel> Users { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        Users = new List<UserModel>();
    }

    // HTTP GET
    public void OnGet()
    {
        for (int i = 0; i <= new Random().Next(1,1000); i++)
        {
            Users.Add(new UserModel());
        }
    }
}