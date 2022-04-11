// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using Microsoft.EntityFrameworkCore;

namespace MMKiwi.GoStreak.Database;
public class SqliteDataContext : SqlServerDataContext
{
    public SqliteDataContext() : base() { }
    public SqliteDataContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        BaseOnModelCreating(builder);

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite("file::memory:");
    }
}
