using System.Collections.Generic;
using System.Linq;

namespace EulerProblems {
    //My wife just wouldn't let this one go so here it is.
    public class DeathCircle
    {
        public Person KillPeople(List<Person> people, int interval)
        {
            if (people.Count == 1)
                return people.First();
            int start = 0;
            foreach (var person in people.Circular())
            {
                if (people.Count(p => !p.IsDead) == 1)
                    return people.First(p => !p.IsDead);

                if (person.IsDead) continue;

                start++;
                if (start%interval == 0)
                {
                    person.IsDead = true;
                    start = 0;
                }
            }
            return null;
        }
    }

    public static class EnumerableExtension
    {
        public static IEnumerable<T> Circular<T>(this IEnumerable<T> coll)
        {
            while (true)
            {
                foreach (T t in coll)
                    yield return t;
            }
        }
    }


    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsDead { get; set; }
    }

}
