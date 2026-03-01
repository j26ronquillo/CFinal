namespace C_Final
{
	internal class Program
	{
		static void Main(string[] args)
		{
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
						case 2:
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
