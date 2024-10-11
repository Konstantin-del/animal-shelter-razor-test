

namespace AnimalFriend.Core.Dtos
{
    public class AnimalDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public SpeciesAnimal Species { get; set; }

        public int Age { get; set; }

        public string PathPhoto { get; set; }

        public bool isActive { get; set; }

        public ShelterDto Shelter { get; set; }
    }
}
