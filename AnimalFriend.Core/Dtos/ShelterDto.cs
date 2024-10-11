

namespace AnimalFriend.Core.Dtos
{
    public class ShelterDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public string Phone { get; set; }

        public SpeciesAnimal SpeciesAnimals { get; set; }

        public UserRoleDto Manager { get; set; }
    }
}
