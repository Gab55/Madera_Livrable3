﻿using System;
using Microsoft.EntityFrameworkCore;
namespace Madera.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options)
            :base(options)
        {

        }

    }
}
