
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DoodleGram.Models;

namespace DoodleGram.Controllers;

public class AccountController : Controller
{
    public ActionResult SignUp(SignUpModel model)
    {
        if (ModelState.IsValid)
        {
            SaveAccountToFile(model);
            // Perform sign-up logic (e.g., create a new user, save to database)
            // You can access the sign-up data via the `model` parameter

            // Redirect to a success page or perform any other desired action
            return RedirectToAction("SignUpSuccess");
        }

        // If the sign-up form is not valid, return the view with validation errors
        return View(model);
    }

    private void SaveAccountToFile(SignUpModel model)
    {
        string filepath = @"C:DoodleGram\Models\UserInfo.txt";
        // Create a new file or append to an existing file
        using (StreamWriter sw = new StreamWriter(filepath, true))
        {
            // Write the account data to the file
            sw.WriteLine($"Email: {model.email}, Password: {model.password}");
        }
    }

    /*
    private void ReadFile()
    {
        string filepath = @"C:DoodleGram\Models\UserInfo.txt";

        using (StreamReader sr = new StreamReader(filepath))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

        }
    }
    */

    public ActionResult SignUpSuccess()
    {
        string filePath = @"C:DoodleGram\Models\UserInfo.txt";
        string fileContent = System.IO.File.ReadAllText(filePath);
        return View((object)fileContent); 

    }
}
