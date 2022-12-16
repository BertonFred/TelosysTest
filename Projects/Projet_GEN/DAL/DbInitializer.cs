
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using CarModel.Entities;

namespace CarModel.Models;

public static class DbInitializer
{
    public static void Initialize(EntitiesDbContext context)
    {
        // $$$ TODO
        context.Posts.Add(new Post() { Title = "poste 1", Description = "le poste 1" });
        context.Posts.Add(new Post() { Title = "poste 2", Description = "le poste 2" });
        context.Posts.Add(new Post() { Title = "poste 3", Description = "le poste 3" });
        context.SaveChanges();
    }
}
