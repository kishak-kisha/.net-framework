using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6q3
{
    class DataEntryException : ApplicationException
    {
        private String _msg;
        public DataEntryException()
        {

        }
        public DataEntryException(string msg)
        {
            this._msg = msg;
        }
        public override string Message
        {
            get
            {
                return this._msg;
            }
        }
    }
}