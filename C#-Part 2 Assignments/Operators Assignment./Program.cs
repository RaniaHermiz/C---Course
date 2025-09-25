using System;

namespace EmployeeEqualityApp
{
    class Staff
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }

        public static bool operator ==(Staff s1, Staff s2)
        {
            if (ReferenceEquals(s1, s2))
                return true;
            if (ReferenceEquals(s1, null) || ReferenceEquals(s2, null))
                return false;
            return s1.Id == s2.Id;
        }

        public static bool operator !=(Staff s1, Staff s2)
        {
            return !(s1 == s2);
        }

        public override bool Equals(object obj)
        {
            var s = obj as Staff;
            return s != null && s.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }

    class Program2
    {
        static void Main()
        {
            Staff s1 = new Staff { Id = 10, First = "A", Last = "B" };
            Staff s2 = new Staff { Id = 20, First = "C", Last = "D" };

            Console.WriteLine("Staff equal? " + (s1 == s2));
            Console.WriteLine("Staff not equal? " + (s1 != s2));
            Console.ReadKey();
        }
    }
}
