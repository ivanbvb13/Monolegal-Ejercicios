using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{

    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0,HowTo="Boil an egg",Line="Boil Water",PlatForm="Kettle & Pan"},
                new Command{Id=1,HowTo="Cut Bread",Line="Get a Knife",PlatForm="Knife & chopping board"},
                new Command{Id=2,HowTo="Make cup of tea",Line="Please teabag in cup",PlatForm="Kettle & Cup"}
                
            };

            return commands;

        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0,HowTo="Boil an egg",Line="Boil Water",PlatForm="Kettle & Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }


}