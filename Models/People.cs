namespace DesafioProjetoHospedagem.Models
{
    public class People
    {
        public People(string name, string lastName)
            {
                Name = name;
                LastName = lastName;
            }
            public string Name { get; set; }
            public string LastName { get; set; }
    }
}