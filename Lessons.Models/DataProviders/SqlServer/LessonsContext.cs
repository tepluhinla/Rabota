﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lessons.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lessons.Models.DataProviders.SqlServer
{
    public class LessonsContext:DbContext
    {
       public  DbSet<Student> Students { get; set; } 
       public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source=DBSRV\\MSSQL2021;Initial Catalog=LessonsTAS;Integrated Security=True");
        }
    }
}
