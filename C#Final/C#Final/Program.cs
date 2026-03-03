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
				Console.WriteLine("\n1. Create New Character\n2. View all Characters\n3. Search Characters\n4. Display All Characters\n5. Exit Program");
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
							newCharacter.Level = int.Parse(Console.ReadLine());

							Console.Write("Enter Strength: ");
							newCharacter.Strength = int.Parse(Console.ReadLine());

							Console.Write("Enter Defense: ");
							newCharacter.Defense = int.Parse(Console.ReadLine());

							Console.Write("Enter Agility: ");
							newCharacter.CharacterAgility = int.Parse(Console.ReadLine());

							Console.Write("Enter Critical Damage: ");
							newCharacter.CriticalDamage = int.Parse(Console.ReadLine());

							Console.Write("Choose Class (Warrior or Mage): ");
							newCharacter.CharacterClass = Console.ReadLine();

							Console.Write("Has Magic? (true/false): ");
							newCharacter.HasMagic = bool.Parse(Console.ReadLine());

							Console.Write("Has Passive Ability? (true/false): ");
							newCharacter.HasPassiveAbility = bool.Parse(Console.ReadLine());

							Console.Write("Choose Difficulty of Character (1=Easy, 2=Normal, 3=Hard): ");
							newCharacter.DifficultyChoice = int.Parse(Console.ReadLine());

							newCharacter.DifficultyChoice = int.Parse(Console.ReadLine());
							newCharacter.CalculatePowerLevel();
							characterList.Add(newCharacter);

							Console.WriteLine("Character successfully created!");
							break;
						case 2:
							Console.WriteLine("\nAll Created Characters!");
							if (characterList.Count == 0)
							{
								Console.WriteLine("No characters have been created yet. Please create a character and try again.\n");
							}
							else
							{
								foreach (CharactersMade character in characterList)
								{
									character.DisplayCharacterInformation();
								}
							}
							break;
						case 3:
							Console.WriteLine("\nCharacter Search");

							if (characterList.Count == 0)
							{
								Console.WriteLine("Sorry, no characters available to search.");
								break;
							}
							Console.Write("Please enter a character name to search (Caps Necessary):");
							string searchName = Console.ReadLine();
							bool searching = false;
							foreach (CharactersMade character in characterList)
							{
								if (character.CharacterName == searchName)
								{
									character.DisplayCharacterInformation();
									searching = true;
								}
							}
							if (!searching)
							{
								Console.WriteLine("No character found. Try again.");
							}
							break;
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
