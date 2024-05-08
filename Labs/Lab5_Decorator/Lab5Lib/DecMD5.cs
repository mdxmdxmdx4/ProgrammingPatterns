using System.Security.Cryptography;
using System.Text;

namespace Lab5Lib
{
    public class DecMD5 : Decorator
    {
        public DecMD5(IWriter writer) : base(writer) { }

        public override string? Save(string? message)
        {
            message = message ?? string.Empty;
            byte[] hash;
            MD5 md5 =MD5.Create(); 
            hash = md5.ComputeHash(Encoding.ASCII.GetBytes(message));
            message += Constant.Delimiter + Convert.ToBase64String(hash);

            return base.Save(message);
        }
    }
}
