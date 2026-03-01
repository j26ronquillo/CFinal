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
	}
	public GameCharacter(
		string CharacterName, 
		string CreatorPlayer,
		string CharacterWeapon,
		string CharacterRace,
		string CharacterClan,
		string CharacterTitle,
		string CharacterArmorType,
		string CharacterSpecialFood,
		string CharacterVoiceLine,
		int Level,
		int Strength,
		int CriticalDamage,
		int CriticalRate,
		int HealthPoints,
		int Defense,
		int AttackSpeed,
		int PlayerGold,
		int CharacterAgility,
		bool HasPet,
		bool HasMagic,
		bool CanDualWield,
		bool HasPassiveAbility,
		string CharacterClass,
		int DifficultyChoice,
		double PowerLevelRank,
		)
		{ }
}
