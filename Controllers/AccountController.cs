
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
            // Perform sign-up logic (e.g., create a new user, save to database)
            // You can access the sign-up data via the `model` parameter

            // Redirect to a success page or perform any other desired action
            return RedirectToAction("SignUpSuccess");
        }

        // If the sign-up form is not valid, return the view with validation errors
        return View(model);
    }

    public ActionResult SignUpSuccess()
    {
        return View(); 

    }
}
