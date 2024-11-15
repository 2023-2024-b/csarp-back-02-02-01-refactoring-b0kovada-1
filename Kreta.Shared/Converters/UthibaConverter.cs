using Kreta.Shared.Models.Datas.Entities;

namespace Kreta.Shared.Converters
{
    public static class UthibaConverter
    {
        public static UthibaDto ToDto(this Uthiba uthiba)
        {
            return new UthibaDto
            {
                Id = uthiba.Id,
                Leiras = uthiba.Leiras,
                Address = uthiba.Address,
                IsDone = uthiba.IsDone

            };
            }

        public static Uthiba ToModel(this UthibaDto uthiba)
        {
            return new Uthiba
            {
                Id = uthiba.Id,
                Leiras = uthiba.Leiras,
                Address = uthiba.Address,
                IsDone = uthiba.IsDone

            };
        }

        public static List<UthibaDto> GetUthibasDtos(this List<Uthiba> Uthibak)
        {
            return Uthibak.Select(Uthiba => ToDto(Uthiba)).ToList();
        }

        public static List<Uthiba> GetUthibak(this List<UthibaDto> UthibaDtos)
        {
            return UthibaDtos.Select(UthibaDto => ToModel(UthibaDto)).ToList();
        }
    }
}