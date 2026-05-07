

namespace DoublyLinkedList.Core
{
	public class DoublyLinkedList<T> where T : IComparable<T>
	{
		private Node<T> head;

		public void Add(T data)
		{
			Node<T> newNode = new Node<T>(data);

			if (head == null)
			{
				head = newNode;
				return;
			}

			Node<T> current = head;

			while (current != null && current.Data.CompareTo(data) < 0)
			{
				current = current.Next;
			}

			if (current == head)
			{
				newNode.Next = head;
				head.Previous = newNode;
				head = newNode;
			}
			else if (current == null)
			{
				Node<T> temp = head;

				while (temp.Next != null)
				{
					temp = temp.Next;
				}

				temp.Next = newNode;
				newNode.Previous = temp;
			}
			else
			{
				Node<T> previous = current.Previous;

				previous.Next = newNode;
				newNode.Previous = previous;

				newNode.Next = current;
				current.Previous = newNode;
			}
		}

		public void DisplayForward()
		{
			Node<T> current = head;

			while (current != null)
			{
				Console.Write(current.Data + " ");
				current = current.Next;
			}

			Console.WriteLine();
		}

		public void DisplayBackward()
		{
			Node<T> current = head;

			if (current == null)
			{
				return;
			}

			while (current.Next != null)
			{
				current = current.Next;
			}

			while (current != null)
			{
				Console.Write(current.Data + " ");
				current = current.Previous;
			}

			Console.WriteLine();
		}

		public void SortDescending()
		{
			Node<T> current = head;
			Node<T> temp = null;

			while (current != null)
			{
				temp = current.Previous;
				current.Previous = current.Next;
				current.Next = temp;

				current = current.Previous;
			}

			if (temp != null)
			{
				head = temp.Previous;
			}
		}

		public bool Exists(T data)
		{
			Node<T> current = head;

			while (current != null)
			{
				if (current.Data.CompareTo(data) == 0)
				{
					return true;
				}

				current = current.Next;
			}

			return false;
		}

		public void RemoveOne(T data)
		{
			Node<T> current = head;

			while (current != null)
			{
				if (current.Data.CompareTo(data) == 0)
				{
					if (current.Previous != null)
					{
						current.Previous.Next = current.Next;
					}
					else
					{
						head = current.Next;
					}

					if (current.Next != null)
					{
						current.Next.Previous = current.Previous;
					}

					return;
				}

				current = current.Next;
			}
		}

		public void RemoveAll(T data)
		{
			Node<T> current = head;

			while (current != null)
			{
				Node<T> next = current.Next;

				if (current.Data.CompareTo(data) == 0)
				{
					if (current.Previous != null)
					{
						current.Previous.Next = current.Next;
					}
					else
					{
						head = current.Next;
					}

					if (current.Next != null)
					{
						current.Next.Previous = current.Previous;
					}
				}

				current = next;
			}
		}

		public void DisplayModes()
		{
			Dictionary<T, int> counter = new Dictionary<T, int>();

			Node<T> current = head;

			while (current != null)
			{
				if (counter.ContainsKey(current.Data))
				{
					counter[current.Data]++;
				}
				else
				{
					counter[current.Data] = 1;
				}

				current = current.Next;
			}

			int max = 0;

			foreach (var item in counter)
			{
				if (item.Value > max)
				{
					max = item.Value;
				}
			}

			Console.Write("Mode(s): ");

			foreach (var item in counter)
			{
				if (item.Value == max)
				{
					Console.Write(item.Key + " ");
				}
			}

			Console.WriteLine();
		}

		public void DisplayGraph()
		{
			Dictionary<T, int> counter = new Dictionary<T, int>();

			Node<T> current = head;

			while (current != null)
			{
				if (counter.ContainsKey(current.Data))
				{
					counter[current.Data]++;
				}
				else
				{
					counter[current.Data] = 1;
				}

				current = current.Next;
			}

			foreach (var item in counter)
			{
				Console.Write(item.Key + " ");

				for (int i = 0; i < item.Value; i++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}
		}
	}
}