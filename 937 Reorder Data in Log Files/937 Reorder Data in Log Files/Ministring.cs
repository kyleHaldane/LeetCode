using System;
using System.Collections.Generic;
using System.Text;

namespace _937_Reorder_Data_in_Log_Files
{
    public class ministring : IComparable<ministring>
    {
        private string _stringSub;
        public string _stringStart;

        public string stringSub
        {
            get => _stringSub;
            set
            {
                _stringSub = value.Substring(value.IndexOf(" "));
            }
        }

        public ministring(string inputString)
        {
            _stringStart = inputString;
            stringSub = inputString;
        }

        public int CompareTo(ministring compareString)
        {
            // A null value means that this object is greater.
            if (compareString == null)
                return 1;

            else if (this._stringSub == compareString._stringSub)
                return this._stringStart.CompareTo(compareString._stringStart);

            else
                return this._stringSub.CompareTo(compareString._stringSub);
        }
    }
}
