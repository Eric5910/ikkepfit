﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace ikeepfit.Models
{
    public class Plan
    {
    }
    public class PlanDBContext : DbContext
    {
        public DbSet<Plan> Movies { get; set; }
    }
}