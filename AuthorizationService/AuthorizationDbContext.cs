﻿// ApplicationDbContext.cs
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class AuthorizationDbContext : IdentityDbContext<IdentityUser>
{
    public AuthorizationDbContext(DbContextOptions<AuthorizationDbContext> options)
        : base(options)
    {
    }
}