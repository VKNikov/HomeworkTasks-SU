namespace TheSlum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NewGame : GameEngine.Engine
    {
        //public virtual void Run()
        //{
        //    ReadUserInput();
        //    InitializeTimeoutItems();
        //    for (int i = 0; i < GameTurns; i++)
        //    {
        //        foreach (var character in characterList)
        //        {
        //            if (character.IsAlive)
        //            {
        //                ProcessTargetSearch(character);
        //            }
        //        }
        //        ProcessItemTimeout(timeoutItems);
        //    }
        //    PrintGameOutcome();
        //}

        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    PrintCharactersStatus(characterList);
                    break;
                case "create": CreateCharacter(inputParams);
                    break;
                case "add": AddItem(inputParams);
                    break;
                default:
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            Character character;
            Team team = inputParams[5] == "Red"? Team.Red : Team.Blue;
            switch (inputParams[1])
            {
                case "mage": character = new Mage(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]), team);
                    break;
                case "warrior": character = new Warrior(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]), team);
                    break;
                case "healer": character = new Healer(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]), team);
                    break;
                default: throw new Exception("Sorry, something went wrong :(.");
            }

            this.characterList.Add(character);
        }

        protected new void AddItem(string[] inputParams)
        {
            Item item;
            switch (inputParams[2])
            {
                case "axe": item = new Axe(inputParams[3]);
                    break;
                case "shield": item = new Shield(inputParams[3]);
                    break;
                case "injection": item = new Injection(inputParams[3]);
                    break;
                case "pill": item = new Injection(inputParams[3]);
                    break;
                default: throw new Exception("Sorry, something went wrong :(.");
            }

            var heroe = characterList.Find(character => character.Id == inputParams[1]);
            heroe.AddToInventory(item);
        }
    }
}
