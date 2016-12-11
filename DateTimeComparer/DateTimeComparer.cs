using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
	public class DateTimeComparer : Comparer<DateTime>
	{
		private Precision _Precision;

		public enum Precision : sbyte
		{
			Years,
			Months,
			Days,
			Hours,
			Minutes,
			Seconds,
			Milliseconds,
			Ticks
		}

		private static Func<DateTime, DateTime, int>[] S_compareFuncs = new Func<DateTime, DateTime, int>[]
		{
			(x,y) => { return (x-y) < TimeSpan.FromDays(365) ? 0 : x.CompareTo(y); },
			(x,y) => { return (x-y) < TimeSpan.FromDays(DateTime.DaysInMonth(x.Year, x.Month)) ? 0 : x.CompareTo(y); },
			(x,y) => { return (x-y) < TimeSpan.FromDays(1) ? 0 : x.CompareTo(y); },
			(x,y) => { return (x-y) < TimeSpan.FromHours(1) ? 0 : x.CompareTo(y); },
			(x,y) => { return (x-y) < TimeSpan.FromMinutes(1) ? 0 : x.CompareTo(y); },
			(x,y) => { return (x-y) < TimeSpan.FromSeconds(1) ? 0 : x.CompareTo(y); },
			(x,y) => { return x.Ticks.CompareTo(y.Ticks); },
		};

		public DateTimeComparer(Precision precision = Precision.Ticks)
		{
			_Precision = precision;
		}

		public override int Compare(DateTime x, DateTime y)
		{
			if(_Precision == Precision.Ticks)
			{
				return x.Ticks.CompareTo(y.Ticks);
			}

			for(sbyte i = (sbyte)(_Precision); i >= 0; i--)
			{
				int compare = S_compareFuncs[i](x, y);
				if(compare != 0) return compare;
			}

			return 0;
		}
	}
}
