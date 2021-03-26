using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class DataBaseBlog : DbContext
    {

        public DataBaseBlog(DbContextOptions<DataBaseBlog> options) : base(options)
        {



        }

        public DbSet<BlogDetails> BlogDetails { get; set; }
   
    }

    public class BlogDetails
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Titulo")]
        public String Title { get; set; }

        [Required]
        [Display(Name = "Contenido")]
        public String Contents { get; set; }



        [Required]
        [Display(Name = "Categoria")]
        public String CategoryName { get; set; }

        [Required]
        [Display(Name = "Imagen")]
        public byte[] Picture { get; set; }


        [Required]
        [Display(Name = "Fecha de Creacion")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }


   


    }
}


