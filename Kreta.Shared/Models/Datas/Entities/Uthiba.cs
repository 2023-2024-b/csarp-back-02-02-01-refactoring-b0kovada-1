using System.Runtime.CompilerServices;

namespace Kreta.Shared.Models.Datas.Entities
{
    public class Uthiba
    {
        public Uthiba()
        {
            Id = Guid.NewGuid();
            Leiras = string.Empty;
            Address = string.Empty;
            IsDone = true;
        }
        public Uthiba(string leiras, string address, bool isDone)
        {
            Id = Guid.NewGuid();
            Leiras = leiras;
            Address = address;
            IsDone = false;
        }
        public Uthiba(Guid id, string leiras, string address, bool isDone)
        {
            Id = Guid.NewGuid();
            Leiras = leiras;
            Address = address;
            IsDone = false;
        }
        public Guid Id { get; set; }
        public string Leiras { get; set; }
        public string Address { get; set; }
        public bool IsDone { get; set; }
        public override string ToString()
        {
            return $"{Leiras} {Address}";
        }
    }
}
