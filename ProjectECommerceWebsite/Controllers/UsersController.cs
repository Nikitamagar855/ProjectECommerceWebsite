using Microsoft.AspNetCore.Mvc;
using ProjectECommerceWebsite.Data;
using ProjectECommerceWebsite.Models;
using System;
using System.Linq;

namespace ProjectECommerceWebsite.Controllers
{
    public class UsersController : Controller

    {
        private readonly ApplicationDbContext context;

        public UsersController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Login(Users user)
        {
            var us = context.Users.Where(u => u.EmailId == user.EmailId && u.Password == user.Password).SingleOrDefault();
            if (us != null)
            {
                if (us.RoleId == 1)
                {
                    //ViewBag.popmessage = "<script> alert('LogIn Successfull!') </script>"; 
                    return RedirectToAction("Index", "Customer");
                }
                else
                {
                    ViewBag.popmessage = "<script> alert('LogIn Successfull!') </script>";
                    return RedirectToAction("AllProductList", "Inventry");
                    //return View();
                }
            }
            else
            {
                ViewBag.popmessage = "<script> alert('LogIn Failed!') </script>";
                ModelState.Clear();
                return View();
            }

        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public IActionResult LogOut()
        {
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult Register(Users users)
        {
            try
            {
                users.RoleId = 1;
                context.Add(users);
                int result = context.SaveChanges();
                if (result == 1)
                {
                    ViewBag.Message = "<script> alert('SignUp Successfull!') </script>";
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.Message = "<script> alert('SignUp Failed Please try again!') </script>";
                    ModelState.Clear();
                }

            }
            catch (Exception ex) { }

            return View();
        }
        }
    }