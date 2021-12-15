using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBuilderFinalProject.Models
{
    public class RecipeContext:DbContext
    {

        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {

        }
        public DbSet<RecipeModel> RecipeModels { get; set; }

    }
}
