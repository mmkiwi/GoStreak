// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Microsoft.AspNetCore.Identity;

namespace MMKiwi.GoStreak.Model;

[DataContract]
public class StreakTask
{
    public StreakTask(string name)
    {
        Name = name;
    }

    [DataMember(EmitDefaultValue = false, Order = 1)]
    public int StreakTaskId { get; set; }

    [MaxLength(100)]
    [DataMember(Order = 2)]
    public string Name { get; set; }

    [DataMember(Order = 7)]
    public bool Sunday { get; set; }

    [DataMember(Order = 8)]
    public bool Monday { get; set; }

    [DataMember(Order = 9)]
    public bool Tuesday { get; set; }

    [DataMember(Order = 10)]
    public bool Wednesday { get; set; }

    [DataMember(Order = 11)]
    public bool Thursday { get; set; }

    [DataMember(Order = 12)]
    public bool Friday { get; set; }

    [DataMember(Order = 13)]
    public bool Saturday { get; set; }

    [DataMember(Order = 4)]
    public DateTime CreateDate { get; set; }
   

    [DataMember(Order = 5)]
    public DateTime LastCompleteDate { get; set; }
    
    [DataMember(Order = 6)]
    public DateTime StreakStartDate { get; set; }
    

    [DataMember(Order = 3)]
    public string OwnerId { get; set; } = null!;
    public IdentityUser Owner { get; set; } = null!;

}
