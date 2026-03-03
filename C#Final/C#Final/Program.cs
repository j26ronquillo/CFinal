namespace C_Final
{
	internal class Program
	{ 
		static void Main(string[] args)
		{
			List<CharactersMade> characterList = new List<CharactersMade>();
			/* The Game Character Creation System allows players to create and manage custom characters in a video game.
			 * Users are given a menu and can enter character details such as their name, level, and other stats. 
			 * With this input, the system then calculates a power rank to see how strong they really are. 
			 * After user input is provided, the characters are stored and when need to be searched or viewed, the user can
			 * find their descriptions and statistics. Welcome to the Game Character Creation System! */
			Console.WriteLine("***Welcome to the Game Character Creation System!***");
			bool programMenu = true;
			while (programMenu)
			{
				Console.WriteLine("\n1. Create New Character\n2. View all Characters\n3. Search Characters\n4. Character Statistics\n5. Exit Program");
				Console.Write("Enter Choice: ");
				try
				{
					int choice = int.Parse(Console.ReadLine());
					switch (choice)
					{
						case 1:
							try
							{
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

								newCharacter.CalculatePowerLevel();
								characterList.Add(newCharacter);

								Console.WriteLine("Character successfully created!");
							}
							catch (FormatException)
							{
								Console.WriteLine("ERROR: Invalid input. Please enter the correct values");
							}
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
							try
							{
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
							}
							catch (FormatException)
							{
								Console.WriteLine("ERROR: Invalid input. Please enter the correct values");
							}
							break;
						case 4:
							Console.WriteLine("Character Statistics!");
							if (characterList.Count == 0)
							{
								Console.WriteLine("No characters made yet.");
								break;
							}
							int totalLevel = 0;
							double highestPower = 0;
							int magicCount = 0;

							foreach (CharactersMade character in characterList)
							{
								totalLevel += character.Level;
								if (character.PowerLevelRank > highestPower)
									highestPower = character.PowerLevelRank;
								if (character.HasMagic)
									magicCount++;
							}

							
							
							double averageLevel = (double)totalLevel / characterList.Count;
							double magicPercentage = ((double)magicCount / characterList.Count) * 100;

							Console.WriteLine($"Total Characters: {characterList.Count}");
							Console.WriteLine($"Average Level: {averageLevel}");
							Console.WriteLine($"Highest Power Level: {highestPower:F2}");
							Console.WriteLine($"Characters with Magic: {magicCount} : {magicPercentage}%");
							break;
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
