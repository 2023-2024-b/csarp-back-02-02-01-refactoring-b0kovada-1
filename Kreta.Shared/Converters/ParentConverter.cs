using Kreta.Shared.Models.Datas.Entities;

namespace Kreta.Shared.Converters
{
    public static class ParentConverter
    {
        public static ParentDto ToDto(this Parent parent)
        {
            return new ParentDto
            {
                Id = parent.Id,
                FirstName = parent.FirstName,
                LastName = parent.LastName,
                Address = parent.Address,
                IsWoman = parent.IsWoman
            };
        }

        public static Parent ToModel(this ParentDto parent)
        {
            return new Parent
            {
                Id = parent.Id,
                FirstName = parent.FirstName,
                LastName = parent.LastName,
               Address = parent.Address,
                IsWoman = parent.IsWoman
            };
        }

        public static List<ParentDto> GetParentsDtos(this List<Parent> parents)
        {
            return parents.Select(parent => ToDto(parent)).ToList();
        }

        public static List<Parent> GetParents(this List<ParentDto> parentDtos)
        {
            return parentDtos.Select(parentDto => ToModel(parentDto)).ToList();
        }
    }
}