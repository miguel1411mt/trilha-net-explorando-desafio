using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

Reservation reservation = new Reservation(12);

People p1 = new People("João", "Almeida");
People p2 = new People("Caio", "Fernades");
People p3 = new People("Rafael", "Pereira");

List<People> guests = new List<People>();

guests.Add(p1);
guests.Add(p2);
guests.Add(p3);


Bedroom bedroom = new Bedroom("VIP", 3, 79);

reservation.AddBedroom(bedroom);

reservation.AddGuests(guests);

reservation.CalculateDailyValue();