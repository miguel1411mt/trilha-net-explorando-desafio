namespace DesafioProjetoHospedagem.Models
{
    public class Reservation
    {
        public Reservation(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public List<People> Guests { get; set; }
        public Bedroom Bedroom { get; set; }
        public int ReservedDays { get; set; }

        public void AddGuests(List<People> guests)
        {
            Guests = guests;
                
            if(guests.Count > Bedroom.Capacity)
            {
                throw new ArgumentException($"O quarto cabe apenas {Bedroom.Capacity} pessoas");
            }
        }

        public void AddBedroom(Bedroom bedroom)
        {
            Bedroom = bedroom;
        }

        public void CalculateDailyValue()
        {
            decimal dailyValue = Bedroom.DailyValue * ReservedDays;
            
            if(ReservedDays >= 10)
            {
                Console.WriteLine("---------------RESERVA---------------");
                Console.WriteLine($"Hóspedes: {Guests.Count}");
                Console.WriteLine("Você ganhou um desconto de 10% por reservar 10 ou mais dias!");
                decimal discount = 0.1m * dailyValue;
                Console.WriteLine($"O valor da reserva foi: R$ {dailyValue - discount}0");
            }
            else 
            {
                Console.WriteLine($"O valor da reserva foi de R$ {dailyValue},00");
            }
        }
    }
}