using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [Required (ErrorMessage =" El Titulo del blog es Obligatorio")]
        [Display(Name = "Titulo")]
        public String Title { get; set; }

        [Required(ErrorMessage = " El contenido del blog es Obligatorio")]
        [Display(Name = "Contenido")]
        public String Contents { get; set; }



        [Required(ErrorMessage = " La categoria del blog es Obligatorio")]
        [Display(Name = "Categoria")]
        public String CategoryName { get; set; }

        [Required(ErrorMessage = " La imagen del blog es Obligatorio")]
        [Display(Name = "Imagen")]
        public byte[] Picture { get; set; }


        [Required(ErrorMessage = "La fecha del blog es Obligatorio")]
        [Display(Name = "Fecha de Creacion")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }


        //public bool IsDeleted { get; set; }



    }
}


