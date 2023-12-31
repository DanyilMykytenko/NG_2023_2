﻿namespace RepoUofExample.DAL.Entities;

public class Tag : BaseEntity
{
    public string Name { get; set; }

    public virtual ICollection<Recipe> Recipes { get; set; }
}