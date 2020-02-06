using System;
using System.Collections.Generic;
using System.Text;

namespace HMX.HASSActronQue
{
	public class QueueCommand
	{
		public long RequestId;
		public QueueCommandData Data;

		public QueueCommand(long lRequestId)
		{
			RequestId = lRequestId;
			Data = new QueueCommandData();
		}
	}
}
