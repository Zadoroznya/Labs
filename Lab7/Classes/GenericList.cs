using Lab7.Models;

namespace Lab7.Classes;

internal class GenericList<T> where T : Product {
	private Node? _head = null;

	public void AddHead(T t) {
		var n = new Node(t) {
			Next = _head
		};
		_head = n;
	}

	public IEnumerator<T?> GetEnumerator() {
		var current = _head;

		while (current != null) {
			yield return current.Data;
			current = current.Next;
		}
	}

	public T? FindFirstOccurrence(string name) {
		var current = _head;

		while (current != null) {
			if (current.Data?.Name == name)
				return current.Data;

			current = current.Next;
		}

		return null; // Якщо не знайдено
	}

	private class Node {
		public Node(T? data) {
			Data = data;
			Next = null;
		}

		public Node? Next { get; init; }
		public T? Data { get; }
	}
}