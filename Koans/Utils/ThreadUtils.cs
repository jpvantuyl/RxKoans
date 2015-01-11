﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Koans.Utils
{
	public class ThreadUtils
	{
		public static void WaitUntil(Func<bool> func)
		{
			while (!func())
			{
				Thread.Sleep(100);
			}
		}
	}
}
