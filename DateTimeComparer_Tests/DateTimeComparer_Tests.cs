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
			var comparer = new DateTimeComparer(DTC.Precision.Seconds);

			DateTime x = DateTime.Now;
			x = x.AddMilliseconds(x.Millisecond * -1); //clear out milliseconds

			DateTime y = x.AddMilliseconds(100);

			var test = comparer.Compare(x, y);

			Assert.That(test, Is.Zero);
		}
	}
}
