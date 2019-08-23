using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeltExam.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BeltExam.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(RegWLog newUser)
        {
            UserReg submittedUser = newUser.UserReg;
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == submittedUser.Email))
                {
                    ModelState.AddModelError("UserReg.Email", "Email already in use!");
                    return View("Index");
                };

                PasswordHasher<UserReg> Hasher = new PasswordHasher<UserReg>();
                submittedUser.Password = Hasher.HashPassword(submittedUser, submittedUser.Password);
                dbContext.Add(submittedUser);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserId", submittedUser.UserId);
                return RedirectToAction("Dashboard", new {id = submittedUser.UserId});
            }
            else
            {

                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(RegWLog LogForm)
        {
            UserLog loggedUser = LogForm.UserLog;
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == loggedUser.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("UserLog.Email", "Invalid login");
                    return View("Index");
                }
                var hasher = new PasswordHasher<UserLog>();
                var result = hasher.VerifyHashedPassword(loggedUser, userInDb.Password, loggedUser.Password);
                if (result ==0)
                {
                    ModelState.AddModelError("UserLog.Password", "Invalid Login");
                    return View("Index");
                }

                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Dashboard", new {id = userInDb.UserId});

            }
            else{
                return View("Index");
            }
        }

        [HttpGet("home/{id}")]
        public IActionResult Dashboard(int id)
        {
            int? UserSess = HttpContext.Session.GetInt32("UserId");
            if(UserSess == 0 || UserSess == null || UserSess != id)
            {
                return View("Index");
            }
            var activityInfo = dbContext.Activities
                                .Include(a => a.Guests)
                                .Where(a => a.Date > DateTime.Now)
                                .OrderBy(a => a.Date)
                                .ToList();
            var userinfo = dbContext.Users.FirstOrDefault(u => u.UserId==UserSess);
            ViewBag.id = UserSess;
            ViewBag.name = userinfo.FirstName;
            return View(activityInfo);
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            int? UserSess = HttpContext.Session.GetInt32("UserId");
            if(UserSess == 0 || UserSess == null)
            {
                return View("Index");
            }
            return View();
        } 

        [HttpPost("newAct")]
        public IActionResult newAct(Activities newAct)
        {
            if(ModelState.IsValid)
            {
                int? creatorid = HttpContext.Session.GetInt32("UserId");
                newAct.UserId = (int)creatorid;
                dbContext.Activities.Add(newAct);
                dbContext.SaveChanges();
                return RedirectToAction("ActInfo", new {id = newAct.ActivityId});
            }
            else{
                return View("New");
            }
        }

        [HttpGet("activity/{id}")]
        public IActionResult ActInfo(int id)
        {
            int? UserSess = HttpContext.Session.GetInt32("UserId");
            if(UserSess == 0 || UserSess == null)
            {
                return View("Index");
            }
            var actinfo = dbContext.Activities
                            .Include(a =>a.Guests)
                            .ThenInclude(a => a.Attendee)
                            .FirstOrDefault(a => a.ActivityId == id);
            ViewBag.id = UserSess;
            var coord = dbContext.Users.FirstOrDefault(u => u.UserId == actinfo.UserId);
            ViewBag.coord = coord;
            return View(actinfo);
        }

        [HttpGet("join/{id}")]
        public IActionResult Join(int id)
        {
            int? UserSess = HttpContext.Session.GetInt32("UserId");
            Response joining = dbContext.Responses
                            .Include(r => r.Attendee)
                            .FirstOrDefault(r => r.ActivityId == id);
            // UserReg active = dbContext.Users
            //                     .Include(a => a.Activities).FirstOrDefault(a => a.UserId == UserSess);
            if(joining == null || joining.UserId != UserSess)
            {
                Response rsvp = new Response();
                rsvp.ActivityId = id;
                rsvp.UserId = (int)UserSess;
                dbContext.Responses.Add(rsvp);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard", new {id = UserSess});
            }
            return RedirectToAction("Dashboard", new {id = UserSess});
        }

        [HttpGet("leave/{id}")]
        public IActionResult Leave(int id)
        {
            int? UserSess = HttpContext.Session.GetInt32("UserId");
            var leaving = dbContext.Responses.FirstOrDefault(w => w.UserId == UserSess && w.ActivityId == id);
            dbContext.Responses.Remove(leaving);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard", new {id = UserSess});
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            int? UserSess = HttpContext.Session.GetInt32("UserId");
            Activities toBeDel = dbContext
                                .Activities
                                .SingleOrDefault(a => a.ActivityId == id);
            dbContext.Activities.Remove(toBeDel);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard", new {id = UserSess});
        }

        [HttpGet("logout")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
