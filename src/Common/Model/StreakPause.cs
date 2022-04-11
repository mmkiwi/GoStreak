// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

namespace MMKiwi.GoStreak.Model;

public class StreakPause
{
    public int StreakPauseId { get; set; }
    public int UserId { get; set; }
    public StreakUser User { get; set; } = null!;

    public DateTime PauseStart { get; set; }
    public DateTime PauseEnd { get; set; }
}