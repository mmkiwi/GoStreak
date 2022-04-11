// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using Microsoft.AspNetCore.Mvc;

using MMKiwi.GoStreak.Database;
using MMKiwi.GoStreak.Model;
using Microsoft.EntityFrameworkCore;

namespace GoStreakServer.Controllers;
[ApiController]
[Route("[controller]")]
public class StreakTaskController : ControllerBase
{

    private readonly SqlServerDataContext _context;

    public StreakTaskController(SqlServerDataContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<StreakTask>>> GetTodoItems() 
        => await _context.StreakTasks.ToListAsync();

    [HttpGet("{id}")]
    public async Task<ActionResult<StreakTask>> GetTodoItem(long id) 
        => await _context.StreakTasks.FindAsync(id) ?? (ActionResult<StreakTask>)NotFound();
}
