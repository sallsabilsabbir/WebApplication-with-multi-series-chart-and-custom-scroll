namespace WebApplicationJPL.Models
{
    public class EnergyModels
    {
        public List<TodaysDatum> TodaysDatas { get; set; }
        public List<TodayPlantTotalEnergy> TodayPlantTotalEnergies { get; set; }
        public List<YesterdaysDatum> YesterdaysDatas { get; set; }
        public List<YesterdayPlantTotalEnergy> YesterdayPlantTotalEnergies { get; set; }
    }
}
