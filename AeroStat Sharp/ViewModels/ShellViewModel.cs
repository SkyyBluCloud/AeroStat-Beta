using Caliburn.Micro;

namespace AeroStat_Sharp.ViewModels
{
    public class ShellViewModel : Screen
    {
		private string _callsign="FUBAR01";

		public string callsign
		{
			get { return _callsign; }
			set 
			{ 
				_callsign = value;
				NotifyOfPropertyChange(() => callsign);
			}
		}
		

	}
}
