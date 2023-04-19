﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationJPL.Models;

public partial class MaxDcPower
{
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
    public DateTime? Time { get; set; }

    public float? Shed1 { get; set; }

    public float? Shed2 { get; set; }

    public float? Shed3And4 { get; set; }

    public float? Shed5 { get; set; }

    public float? Shed6 { get; set; }

    public float? Shed7 { get; set; }

    public float? Shed8 { get; set; }

    public float? Shed10 { get; set; }

    public float? Shed11 { get; set; }

    public float? Shed12 { get; set; }
}
