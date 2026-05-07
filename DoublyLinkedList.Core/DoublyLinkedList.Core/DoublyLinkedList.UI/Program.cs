
using DoublyLinkedList.Core;

namespace DoublyLinkedList.UI
{
	public class Program
	{
		static void Main(string[] args)
		{
			DoublyLinkedList<string> list = new DoublyLinkedList<string>();

			int option;

			do
			{
				Console.WriteLine("\n--- MENU ---");
				Console.WriteLine("1. Add");
				Console.WriteLine("2. Display Forward");
				Console.WriteLine("3. Display Backward");
				Console.WriteLine("4. Sort Descending");
				Console.WriteLine("5. Display Mode(s)");
				Console.WriteLine("6. Display Graph");
				Console.WriteLine("7. Exists");
				Console.WriteLine("8. Remove One");
				Console.WriteLine("9. Remove All");
				Console.WriteLine("0. Exit");

				Console.Write("Option: ");
				option = int.Parse(Console.ReadLine());

				switch (option)
				{
					case 1:
						Console.Write("Enter data: ");
						list.Add(Console.ReadLine());
						break;

					case 2:
						list.DisplayForward();
						break;

					case 3:
						list.DisplayBackward();
						break;

					case 4:
						list.SortDescending();
						Console.WriteLine("List sorted descending.");
						break;

					case 5:
						list.DisplayModes();
						break;

					case 6:
						list.DisplayGraph();
						break;

					case 7:
						Console.Write("Search data: ");

						Console.WriteLine(
							list.Exists(Console.ReadLine())
							? "Element exists"
							: "Element does not exist"
						);
						break;

					case 8:
						Console.Write("Remove data: ");
						list.RemoveOne(Console.ReadLine());
						break;

					case 9:
						Console.Write("Remove all occurrences of: ");
						list.RemoveAll(Console.ReadLine());
						break;

					case 0:
						Console.WriteLine("Program finished.");
						break;

					default:
						Console.WriteLine("Invalid option.");
						break;
				}

			} while (option != 0);
		}
	}
}