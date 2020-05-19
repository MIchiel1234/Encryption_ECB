using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryption_app
{
    class Encryptdecryptdatacs 
    {
        public string encryptdata(string message)
        {
         
            encryptforinterface absi = new encryptforinterface();
            string encryptedmessage = absi.Encrypt(message);
            return encryptedmessage;
        }
        public string decryptdata(string messagetodecpt)
        {
            encryptforinterface absi = new encryptforinterface();
            string decrcypt = absi.Decrypt(messagetodecpt);
            return decrcypt;
        }
    }
}
