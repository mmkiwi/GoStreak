using Microsoft.AspNetCore.Identity;

namespace MMKiwi.GoStreak.Model;
public class StreakUser : IdentityUser<int>
{
    public StreakUser() { }

    public StreakUser(string userName) : base(userName) { }
}
