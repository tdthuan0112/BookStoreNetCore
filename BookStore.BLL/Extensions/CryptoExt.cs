using System.Security.Cryptography;
using System.Text;

namespace BookStore.BLL.Extensions
{
    public class CryptoExt
    {
        private static readonly string KeyEncode = "BookStoreEcommerce";

        public static byte[] EncryptTextToMemory(string Data, byte[] Key, byte[] IV)
        {
            try
            {
                // Create a MemoryStream.
                MemoryStream mStream = new MemoryStream();

                // Create a CryptoStream using the MemoryStream
                // and the passed key and initialization vector (IV).
                CryptoStream cStream = new CryptoStream(mStream,
                    new TripleDESCryptoServiceProvider().CreateEncryptor(Key, IV),
                    CryptoStreamMode.Write);

                // Convert the passed string to a byte array.
                byte[] toEncrypt = new ASCIIEncoding().GetBytes(Data);

                // Write the byte array to the crypto stream and flush it.
                cStream.Write(toEncrypt, 0, toEncrypt.Length);
                cStream.FlushFinalBlock();

                // Get an array of bytes from the
                // MemoryStream that holds the
                // encrypted data.
                byte[] ret = mStream.ToArray();

                // Close the streams.
                cStream.Close();
                mStream.Close();

                // Return the encrypted buffer.
                return ret;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }

        public static string DecryptTextFromMemory(byte[] Data, byte[] Key, byte[] IV)
        {
            try
            {
                // Create a new MemoryStream using the passed
                // array of encrypted data.
                MemoryStream msDecrypt = new MemoryStream(Data);

                // Create a CryptoStream using the MemoryStream
                // and the passed key and initialization vector (IV).
                CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                    new TripleDESCryptoServiceProvider().CreateDecryptor(Key, IV),
                    CryptoStreamMode.Read);

                // Create buffer to hold the decrypted data.
                byte[] fromEncrypt = new byte[Data.Length];

                // Read the decrypted data out of the crypto stream
                // and place it into the temporary buffer.
                csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);

                //Convert the buffer into a string and return it.
                return new ASCIIEncoding().GetString(fromEncrypt);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }

        public static string Encrypt(string content, string key)
        {
            if (string.IsNullOrEmpty(content)) { return ""; }
            var toEncryptArray = Encoding.UTF8.GetBytes(content);
            TripleDESCryptoServiceProvider tDESCryptor = new()
            {
                //Key = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(!string.IsNullOrEmpty(key) ? key : KeyEncode)),
                Key = MD5.HashData(Encoding.UTF8.GetBytes(!string.IsNullOrEmpty(key) ? key : KeyEncode)),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            var resultArray = tDESCryptor.CreateEncryptor().TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            string result = Convert.ToBase64String(resultArray, 0, resultArray.Length);
            return result;
        }

        public static string Decrypt(string content, string key)
        {
            if (string.IsNullOrEmpty(content)) { return ""; }
            try
            {
                var toEncryptArray = Convert.FromBase64String(content);
                TripleDESCryptoServiceProvider tDESCryptor = new()
                {
                    //Key = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(!string.IsNullOrEmpty(key) ? key : KeyEncode)),
                    Key = MD5.HashData(Encoding.UTF8.GetBytes(!string.IsNullOrEmpty(key) ? key : KeyEncode)),
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };
                var resultArray = tDESCryptor.CreateDecryptor().TransformFinalBlock(
                    toEncryptArray, 0, toEncryptArray.Length);
                string result = Encoding.UTF8.GetString(resultArray);
                return result;
            }
            catch { }
            return "";
        }
    }
}
