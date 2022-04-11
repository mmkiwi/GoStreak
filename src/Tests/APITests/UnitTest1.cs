// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System.Text.Json;

using MMKiwi.GoStreak.Model;

using Xunit;

namespace MMKiwi.GoStreak.APITests;
public class Protobuf
{
    [Fact]
    public void GetProto()
    {
        var streakTask = new StreakTask("Test", null!);
        byte[] utf8Json = JsonSerializer.SerializeToUtf8Bytes(streakTask, GoStreakJsonContext.Default.StreakTask);
        string json = JsonSerializer.Serialize(streakTask, GoStreakJsonContext.Default.StreakTask);
    }
}