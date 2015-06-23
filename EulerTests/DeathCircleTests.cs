using System.Collections.Generic;
using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class DeathCircleTests {
        List<Person> people = new List<Person>
            {
                new Person{Id = 1, IsDead = false},
                new Person{Id = 2, IsDead = false},//
                new Person{Id = 3, IsDead = false},//
                new Person{Id = 4, IsDead = false},//
                new Person{Id = 5, IsDead = false},//
                new Person{Id = 6, IsDead = false},//
            };

		[TestMethod]
		public void DeathCircle_1() {
			var problem = new DeathCircle();



		    var interval = 1;


            var actual = problem.KillPeople(people, interval);
			Assert.AreEqual(6, actual.Id);
		}

        [TestMethod]
        public void DeathCircle_2()
        {
            var problem = new DeathCircle();
            var interval = 2;


            var actual = problem.KillPeople(people, interval);
            Assert.AreEqual(5, actual.Id);
        }

        [TestMethod]
        public void DeathCircle_3()
        {
            var problem = new DeathCircle();
            var interval = 3;


            var actual = problem.KillPeople(people, interval);
            Assert.AreEqual(1, actual.Id);
        }
	}
}
