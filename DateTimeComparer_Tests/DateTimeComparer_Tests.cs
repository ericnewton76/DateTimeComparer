using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTC = System.DateTimeComparer;

namespace DateTimeComparer_Tests
{
	[TestFixture]
	public class DateTimeComparer_Tests
	{
		[Test]
		public void WithinSeconds()
		{
			//arrange
			DateTime x = new DateTime(2000, 1, 1, 12, 0, 0);
			DateTime y = x.AddMilliseconds(100);

			//act
			var comparer = new DateTimeComparer(DTC.Precision.Seconds);
			var test = comparer.Compare(x, y);

			//assert
			Assert.That(test, Is.Zero);
		}

		[Test]
		public void WithinMinutes()
		{
			//arrange
			DateTime x = new DateTime(2000, 1, 1, 12, 0, 0);
			x = x.AddSeconds(30); 

			DateTime y = x.AddSeconds(30);

			//act
			var comparer = new DateTimeComparer(DTC.Precision.Minutes);
			var test = comparer.Compare(x, y);

			//assert
			Assert.That(test, Is.Zero);
		}

		[Test]
		public void WithinHours()
		{
			//arrange
			DateTime x = new DateTime(2000, 1, 1, 12, 0, 0);
			x = x.AddMinutes(5);

			DateTime y = x.AddMinutes(30);

			//act
			var comparer = new DateTimeComparer(DTC.Precision.Hours);
			var test = comparer.Compare(x, y);

			//assert
			Assert.That(test, Is.Zero);
		}
	}
}
