using System;

namespace HSFFinance
{
	public interface INetworkConnection
	{
		bool IsConnected { get; }
		void CheckNetworkConnection();
	}
}

