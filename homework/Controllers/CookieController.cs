using System;
using Microsoft.AspNetCore.Mvc;

namespace homework.Controllers;

public class CookieController : Controller
{
    public IActionResult Index(){
        var cookies = Request.Cookies;
        return View(cookies);
    }

    public IActionResult AddCookie(string name, string info){
        if(name!=null && info!=null && Request.Cookies.Where(x => x.Key == name).ToList().Count() == 0){
            Response.Cookies.Append(name, info);
        }
        return RedirectToAction("Index");
    }

    public IActionResult EditCookie(string name, string info){
        if(Request.Cookies.Where(x => x.Key == name).ToList().Count() > 0){
            Response.Cookies.Delete(name);
            Response.Cookies.Append(name, info);
        }

        return RedirectToAction("Index");
    }

    public IActionResult DeleteCookie(string name){
        if(Request.Cookies.Where(x => x.Key == name).ToList().Count() > 0){
            Response.Cookies.Delete(name);
        }

        return RedirectToAction("Index");
    }
}
