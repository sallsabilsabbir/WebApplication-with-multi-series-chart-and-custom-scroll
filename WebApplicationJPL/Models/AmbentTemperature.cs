using System.ComponentModel.DataAnnotations;

namespace WebApplicationJPL.Models;

public partial class AmbentTemperature
{
    //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm tt}")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm:ss tt}")]
    public DateTime Time { get; set; }

    public float AmbentTemperature1 { get; set; }
}
