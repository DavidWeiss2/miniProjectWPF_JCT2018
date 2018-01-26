using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    [Serializable]
    [ComVisible(true)]
    public class MyArgumentNullException : ArgumentNullException
    {
        //
        // Summary:
        //     Initializes a new instance of the System.MyArgumentNullException class.
        public MyArgumentNullException();
        //
        // Summary:
        //     Initializes a new instance of the System.MyArgumentNullException class with the
        //     name of the parameter that causes this exception.
        //
        // Parameters:
        //   paramName:
        //     The name of the parameter that caused the exception.
        public MyArgumentNullException(string paramName);
        //
        // Summary:
        //     Initializes a new instance of the System.MyArgumentNullException class with a specified
        //     error message and the exception that is the cause of this exception.
        //
        // Parameters:
        //   message:
        //     The error message that explains the reason for this exception.
        //
        //   innerException:
        //     The exception that is the cause of the current exception, or a null reference
        //     (Nothing in Visual Basic) if no inner exception is specified.
        public MyArgumentNullException(string message, Exception innerException);
        //
        // Summary:
        //     Initializes an instance of the System.MyArgumentNullException class with a specified
        //     error message and the name of the parameter that causes this exception.
        //
        // Parameters:
        //   paramName:
        //     The name of the parameter that caused the exception.
        //
        //   message:
        //     A message that describes the error.
        public MyArgumentNullException(string paramName, string message);
        //
        // Summary:
        //     Initializes a new instance of the System.MyArgumentNullException class with serialized
        //     data.
        //
        // Parameters:
        //   info:
        //     The object that holds the serialized object data.
        //
        //   context:
        //     An object that describes the source or destination of the serialized data.
        [SecurityCritical]
        protected MyArgumentNullException(SerializationInfo info, StreamingContext context);
    }
}
