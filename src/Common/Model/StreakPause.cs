// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using Microsoft.AspNetCore.Identity;

namespace MMKiwi.GoStreak.Model;

public class StreakPause
{
    public int StreakPauseId { get; set; }
    public string UserId { get; set; } = null!;
    public IdentityUser User { get; set; } = null!;

    public DateTime PauseStart { get; set; }
    public DateTime PauseEnd { get; set; }
}