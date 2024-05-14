namespace DesafioProjetoHospedagem.Models
{
    public class Bedroom
    {
        public Bedroom(string bedroomType, int capacity, decimal dailyValue)
        {
            BedroomType = bedroomType;
            Capacity = capacity;
            DailyValue = dailyValue;
        }
        public string BedroomType { get; set; }
        public int Capacity { get; set; }
        public decimal DailyValue { get; set; }
    }
}