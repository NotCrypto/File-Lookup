using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Util
{
    /*
     * GOING TO ADD SHA-512 to Encryption!
     * Base64 added and encryption method fixed;
     */

    class Encrypt
    {
        public static string encodeToString(string content)
        {
            byte[] bCnt = Encoding.ASCII.GetBytes(content);
            var encoded = Convert.ToBase64String(bCnt);
            return encoded;
        }

        public static string decodeToString(string encoded)
        {
            var bDec = Convert.FromBase64String(encoded);
            return ASCIIEncoding.ASCII.GetString(bDec); 
        }
    }
}
