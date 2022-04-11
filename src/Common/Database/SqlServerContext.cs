﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using MMKiwi.GoStreak.Model;

namespace MMKiwi.GoStreak.Database;
public class SqlServerDataContext: IdentityDbContext<IdentityUser>
{
    public DbSet<StreakTask> StreakTasks => Set<StreakTask>();
    public DbSet<StreakPause> StreakPause => Set<StreakPause>();

    public SqlServerDataContext() : base() { }
    public SqlServerDataContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.UseCollation("LATIN1_GENERAL_100_CI_AS_SC_UTF8");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GoStreak");
    }
}
