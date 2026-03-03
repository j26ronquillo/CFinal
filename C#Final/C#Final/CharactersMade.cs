using System;
using System.Collections.Generic;
using System.Text;

namespace C_Final
{
	internal class CharactersMade
	{
		// 5+ string fields
		public string CharacterName;
		public string CreatorPlayer;
		public string CharacterWeapon;
		public string CharacterRace;
		public string CharacterClan;
		public string CharacterTitle;
		public string CharacterArmorType;
		public string CharacterSpecialFood;
		public string CharacterVoiceLine;
		// 5+ numeric fields
		public int Level;
		public int Strength;
		public int CriticalDamage;
		public int CriticalRate;
		public int HealthPoints;
		public int Defense;
		public int AttackSpeed;
		public int PlayerGold;
		public int CharacterAgility;
		// 3+ Boolean fields
		public bool HasPet;
		public bool HasMagic;
		public bool CanDualWield;
		public bool HasPassiveAbility;
		// 2+ selection-based fields (stiched or if/else if)
		public string CharacterClass;
		public int DifficultyChoice;
		public double PowerLevelRank;
	public CharactersMade(string charactername, string creatorplayer)
		{
			CharacterName = charactername;
			CreatorPlayer = creatorplayer;
			PowerLevelRank = 0;
		}
	public void CalculatePowerLevel()
		{
			double basePower = Strength + Defense + CharacterAgility + (CriticalDamage * 0.5);

			if (CharacterClass == "Warrior")
			{
				basePower += Strength * 1.5;
			}
			else if (CharacterClass == "Mage")
			{
				if (HasMagic && Level >= 10)
				{
					basePower += Level * 2;
				}
				else 
				{ 
					basePower += Level;
				}
			}
			else
			{
				basePower += Level;
			}

			if (DifficultyChoice == 3 && CanDualWield)
			{
				basePower *= 1.5;
			}

			PowerLevelRank = basePower; 
		}
	public void DisplayCharacterInformation()
		{
			Console.WriteLine("\nCHARACTER INFORMATION");
			Console.WriteLine($"Name: {CharacterName}");
			Console.WriteLine($"Creator: {CreatorPlayer}");
			Console.WriteLine($"Class: {CharacterClass}");
			Console.WriteLine($"Level: {Level}");
			Console.WriteLine($"Strength: {Strength}");
			Console.WriteLine($"Defense: {Defense}");
			Console.WriteLine($"Agility: {CharacterAgility}");
			Console.WriteLine($"Power Rank: {PowerLevelRank}\n");
		}
	}
}
