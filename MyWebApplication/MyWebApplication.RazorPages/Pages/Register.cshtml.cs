using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApplication.RazorPages.Pages;

public class Register : PageModel
{
    public void OnGet()
    {
        
    }

    public void OnPost()
    {
        string email = Request.Form["email"];
        string password = Request.Form["password"];
        string repeatPassword = Request.Form["password-repeat"];

        Console.WriteLine($"Email: {email}, Password: {password}, Repeat: {repeatPassword}");
        
        Response.Redirect("/");
    }
}