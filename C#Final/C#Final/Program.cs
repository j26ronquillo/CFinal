namespace C_Final
{
	internal class Program
	{ 
		static void Main(string[] args)
		{
			List<CharactersMade> characterList = new List<CharactersMade>();

			Console.WriteLine("***Welcome to the Game Character Creation System!***");
			bool programMenu = true;
			while (programMenu)
			{
				Console.WriteLine("1. Create New Character\n2. View all Characters\n3. Search Characters\n4. Display All Characters\n5. Exit Program");
				Console.Write("Enter Choice: ");
				try
				{
					int choice = int.Parse(Console.ReadLine());
					switch (choice)
					{
						case 1:

							Console.WriteLine("\nCreate New Character");

							Console.Write("Enter Username: ");
							string creator = Console.ReadLine();

							Console.Write("Enter Character Name: ");
							string name = Console.ReadLine();
							CharactersMade newCharacter = new CharactersMade(name, creator);

							Console.Write("Enter Level: ");
							int Level = int.Parse(Console.ReadLine());

							Console.Write("Enter Strength: ");
							int Strength = int.Parse(Console.ReadLine());

							Console.Write("Enter Defense: ");
							int Defense = int.Parse(Console.ReadLine());

							Console.Write("Enter Agility: ");
							int CharacterAgility = int.Parse(Console.ReadLine());

							Console.Write("Enter Critical Damage: ");
							int CriticalDamage = int.Parse(Console.ReadLine());

							Console.Write("Choose Class (Warrior, Mage, Rogue): ");
							string CharacterClass = Console.ReadLine();

							Console.Write("Has Magic? (true/false): ");
							bool HasMagic = bool.Parse(Console.ReadLine());

							Console.Write("Has Passive Ability? (true/false): ");
							bool HasPassiveAbility = bool.Parse(Console.ReadLine());

							Console.Write("Choose Difficulty of Character (1=Easy, 2=Normal, 3=Hard): ");

							newCharacter.DifficultyChoice = int.Parse(Console.ReadLine());
							newCharacter.CalculatePowerLevel();
							characterList.Add(newCharacter);

							Console.WriteLine("Character successfully created!");
							break;
						case 2:
							Console.WriteLine
						case 3:
						case 4:
						case 5: 
							programMenu = false;
							break;
						default:
							Console.WriteLine("ERROR: Invalid menu number.");
							break;
					}
				}
				catch (FormatException)
				{ Console.WriteLine("ERROR: Please enter a valid numerical value."); }
			}
		}
	}
}
