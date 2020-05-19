using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryption_app
{
    interface Iencryptionblueprint
    {
        string Encrypt(string data);
        string Decrypt(string text);

    }
}
