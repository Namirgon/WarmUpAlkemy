using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;
using System.Web;
using Microsoft.EntityFrameworkCore;
using EntityFramework.DynamicFilters;

namespace MyBlog.Controllers
{
    public class BlogsDetailsController : Controller
    {

        private DataBaseBlog _context;

        public BlogsDetailsController(DataBaseBlog context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
          

            IEnumerable<BlogDetails> listBlogs = _context.BlogDetails.Where(b => b.IsDeleted == false).OrderByDescending(b => b.CreationDate) ;

           

            return View(listBlogs);
        }

        public ActionResult Picture(int id)
        {
            var post = _context.BlogDetails.Find(id);
            var fileToRetrieve = post.Picture;
            if (fileToRetrieve is null)
            {
                return Ok();
            }
            return File(fileToRetrieve, "image/jpeg");
        }

        public IActionResult Details(int Id)
        {
            var detalle = _context.BlogDetails.Find(Id);

            return View(detalle);
        }

        public IActionResult Edit(int? Id)
        {
            if(Id == null || Id == 0)
            {

                return NotFound();
            }

            var blog = _context.BlogDetails.Find(Id);

            if (blog == null)
            {

                return NotFound();
            }
          
            return View(blog);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BlogDetails unBlog, List<IFormFile> Picture)
        {

            foreach (var item in Picture)
            {

                if (item.Length > 0)
                {
                    using (var unStream = new MemoryStream())
                    {
                        await item.CopyToAsync(unStream);
                        unBlog.Picture = unStream.ToArray();
                    }
                }
            }
            _context.BlogDetails.Update(unBlog);
            _context.SaveChanges();
            //return View();
            return Redirect("~/BlogsDetails/Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogDetails unBlog, List<IFormFile> Picture) 
        {

            foreach (var item in Picture)
            {

                if (item.Length > 0)
                {
                    using (var unStream = new MemoryStream())
                    {
                        await item.CopyToAsync(unStream);
                        unBlog.Picture = unStream.ToArray();
                    }
                }
            }
            _context.BlogDetails.Add(unBlog);
            _context.SaveChanges();
            //  return View();

            return Redirect("~/BlogsDetails/Index");
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {

                return NotFound();
            }

            var blog = _context.BlogDetails.Find(Id);

            if (blog == null)
            {

                return NotFound();
            }

            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteBlog(int? Id)
        {

            var unBlog = _context.BlogDetails.Find(Id);

            if (unBlog == null)
            {

                return NotFound();
            }

            unBlog.IsDeleted = true;
            _context.BlogDetails.Update(unBlog);
            _context.SaveChanges();

            return Redirect("~/BlogsDetails/Index");
        }


    }
}