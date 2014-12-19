using System;
using SampleApplication.Interfaces;

namespace SampleApplication.Services
{
	public class MessageService : IMessageService
	{
		public string GetMessage ()
		{
			return "Hellow World!";
		}
	}
}

