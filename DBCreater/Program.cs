using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AnimalFriend.DAL;
using Microsoft.EntityFrameworkCore;

namespace DBCreater
{
    public class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            //context.Database.EnsureCreated();

            //var type = new AnimalTypeDto();
            //type.Id = 1;
            //type.Type = "cat";
            //context.AnimalTypes.Add(type);
            //context.SaveChanges();

            //var type1 = new AnimalTypeDto();
            //type.Id = 2;
            //type.Type = "dog";
            //context.AnimalTypes.Add(type);
            //context.SaveChanges();

            //var type2 = new AnimalTypeDto();
            //type.Id = 3;
            //type.Type = "all animal";
            //context.AnimalTypes.Add(type);
            //context.SaveChanges();

            //var type3 = new AnimalTypeDto();
            //type.Id = 4;
            //type.Type = "other";
            //context.AnimalTypes.Add(type);
            //context.SaveChanges();

            //var animal = new AnimalDto();
            //animal.Name = "Test";
            //animal.Age = 5;
            //animal.Description = "Test";
            //animal.ImagePath = "images/dog.jpg";
            //animal.Type = context.AnimalTypes.Where(t => t.Id == 1).FirstOrDefault();
            //animal.Shelter = context.Shelters.Where(t => t.Id == 1).FirstOrDefault();
            //context.Animals.Add(animal);
            //context.SaveChanges();

            //var shelter = new ShelterDto();
            //shelter.Id = 1;
            //shelter.Name = "Test";
            //shelter.Description = "Test";
            //shelter.Address = "Test";
            //shelter.Phone = "Test";
            //shelter.Type = context.AnimalTypes.Where(t => t.Id == 1).FirstOrDefault();
            //context.Shelters.Add(shelter);
            //context.SaveChanges();

            //CREATE USER ROLE
            //var roleIdA = new UserRoleDto();
            //roleIdA.Id = 3;
            //roleIdA.Role = "admin";
            //context.UserRoles.Add(roleIdA);
            //context.SaveChanges();

            //var roleIdM = new UserRoleDto();
            //roleIdM.Id = 2;
            //roleIdM.Role = "manager";
            //context.UserRoles.Add(roleIdM);
            //context.SaveChanges();

            //var roleIdU = new UserRoleDto();
            //roleIdU.Id = 1;
            //roleIdU.Role = "user";
            //context.UserRoles.Add(roleIdU);
            //context.SaveChanges();
        }
    }
}
