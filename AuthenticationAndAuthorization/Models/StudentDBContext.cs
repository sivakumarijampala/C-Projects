﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AuthenticationAndAuthorization.Models
{
    public class StudentDBContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}