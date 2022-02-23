using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.ExceptionLibrary.Service
{
public     class DataServiceException : Exception
    {
        public DataServiceException(string message,Exception innerException):base(message,innerException)
        {

        }
        public override string Message {

            get {
                string msg = InnerException.Message != null ? " ,İnner Exception :" + InnerException.Message : "";
                return $"Message :{base.Message} {msg}";
            
            
            
            }
        
        
        }


    }
}
