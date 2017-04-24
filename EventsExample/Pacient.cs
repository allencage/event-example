using System;

namespace EventsExample
{
	public class Pacient
	{
		private string _name;
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if(_name != value)
				{
					OnNameChanged(this, new NameChangedEventArgs(value));
					_name = value;
				}
			}
		}

		public event NameChangedDelegate OnNameChanged;
	}

	public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);

	public class NameChangedEventArgs : EventArgs
	{
		private string _name;
		public string Name { get { return _name; } }
		public NameChangedEventArgs(string name)
		{
			_name = name;
		}
	}
}
