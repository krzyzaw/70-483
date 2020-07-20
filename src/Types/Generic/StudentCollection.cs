using System.Collections;

namespace Types.Generic
{
    public class StudentCollection : IEnumerable
    {
        private ArrayList studentArrayList = new ArrayList();

        // Rzutowanie dla procedury wywołującej.
        public Student GetStudent(int pos) => (Student)studentArrayList[pos];

        // Wstawiaj wyłącznie obiekty typu Student.
        public void AddStudent(Student p) => studentArrayList.Add(p);

        public void ClearStudent() => studentArrayList.Clear();

        public int Count => studentArrayList.Count;

        // Obsługa wyliczania za pomocą pętli foreach.
        IEnumerator IEnumerable.GetEnumerator() => studentArrayList.GetEnumerator();
    }
}