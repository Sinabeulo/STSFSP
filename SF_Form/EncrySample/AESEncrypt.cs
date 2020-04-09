using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SF_Form.EncrySample
{
    internal class AESEncrypt
    {
        private static AESEncrypt _instance;

        public static AESEncrypt AES
        {
            get
            {
                if(_instance == null) { _instance = new AESEncrypt(); }
                return _instance;
            }
        }

        #region AES 256

        /// <summary>
        /// AES 256 Encry
        /// https://lazydeveloper.net/1703266
        /// </summary>
        public string AES256Encry(string plainText, string key)
        {
            try
            {
                //RijndaelManaged RijndaelCipher = new RijndaelManaged();
                //byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

                //// 딕셔너리 공격을 대비해 키값을 어렵게 바꿈
                //byte[] salt = Encoding.ASCII.GetBytes(key.Length.ToString());
                //PasswordDeriveBytes deriveBytes = new PasswordDeriveBytes(key, salt);

                //ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(deriveBytes.GetBytes(32), deriveBytes.GetBytes(16));

                //MemoryStream memoryStream = new MemoryStream();

                //// CryptoStream객체를 암호화된 데이터를 쓰기 위한 용도로 선언
                //CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);

                //// 암호화 프로세스가 진행됨
                //cryptoStream.Write(plainBytes, 0, plainBytes.Length);

                //// 암호화 종료
                //cryptoStream.FlushFinalBlock();

                //// 암호화된 데이터를 바이트 배열로 담는다.
                //byte[] CipherBytes = memoryStream.ToArray();

                //memoryStream.Close();
                //cryptoStream.Close();

                //string encryptedData = Convert.ToBase64String(CipherBytes);

                //return encryptedData;
                var aes = new RijndaelManaged
                {
                    KeySize = 256,
                    BlockSize = 128,
                    Mode = CipherMode.CBC,
                    Padding = PaddingMode.PKCS7,
                    Key = Encoding.UTF8.GetBytes(key),
                    IV = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
                };

                var encrypt = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] xBuff = null;
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encrypt, CryptoStreamMode.Write))
                    {
                        var xXml = Encoding.UTF8.GetBytes(plainText);
                        cs.Write(xXml, 0, xXml.Length);
                    }

                    xBuff = ms.ToArray();
                }

                var output = Convert.ToBase64String(xBuff);
                return output;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// AES 256 Decry
        /// </summary>
        /// <param name="text"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string AES256Decry(string text, string key)
        {
            try
            {
                //RijndaelManaged RijndaelCipher = new RijndaelManaged();

                //byte[] EncryptedData = Convert.FromBase64String(plainText);
                //byte[] Salt = Encoding.ASCII.GetBytes(key.Length.ToString());

                //PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(key, Salt);

                //// Decryptor 객체를 만든다.
                //ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

                //MemoryStream memoryStream = new MemoryStream(EncryptedData);

                //// 데이터 읽기(복호화이므로) 용도로 cryptoStream객체를 선언, 초기화
                //CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);

                //// 복호화된 데이터를 담을 바이트 배열을 선언한다.
                //// 길이는 알 수 없지만, 일단 복호화되기 전의 데이터의 길이보다는
                //// 길지 않을 것이기 때문에 그 길이로 선언한다.
                //byte[] PlainBytes = new byte[EncryptedData.Length];

                //// 복호화 시작
                //int DecryptedCount = cryptoStream.Read(PlainBytes, 0, PlainBytes.Length);

                //memoryStream.Close();
                //cryptoStream.Close();

                //// 복호화된 데이터를 문자열로 바꾼다.
                //string decryptedData = Encoding.Unicode.GetString(PlainBytes, 0, DecryptedCount);

                //// 최종 결과 리턴
                //return decryptedData;
                var aes = new RijndaelManaged
                {
                    KeySize = 256,
                    BlockSize = 128,
                    Mode = CipherMode.CBC,
                    Padding = PaddingMode.PKCS7,
                    Key = Encoding.UTF8.GetBytes(key),
                    IV = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
                };

                var decrypt = aes.CreateDecryptor();
                byte[] xBuff = null;
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, decrypt, CryptoStreamMode.Write))
                    {
                        var xXml = Convert.FromBase64String(text);
                        cs.Write(xXml, 0, xXml.Length);
                    }

                    xBuff = ms.ToArray();
                }

                var output = Encoding.UTF8.GetString(xBuff);
                return output;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion

        #region AES 128
        /// <summary>
        /// AES 128 Encry
        /// </summary>
        /// <param name="plain"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string AES128Encry(string plain, string key)
        {
            try
            {
                var rijndaelCipher = new RijndaelManaged();

                var plainText = Encoding.Unicode.GetBytes(plain);
                var salt = Encoding.ASCII.GetBytes(key.Length.ToString());

                var secretKey = new PasswordDeriveBytes(key, salt);
                var encryptor = rijndaelCipher.CreateEncryptor(secretKey.GetBytes(32), secretKey.GetBytes(16));

                var memoryStream = new MemoryStream();
                var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);

                cryptoStream.Write(plainText, 0, plainText.Length);
                cryptoStream.FlushFinalBlock();

                var cipherBytes = memoryStream.ToArray();

                memoryStream.Close();
                cryptoStream.Close();

                var encryptedData = Convert.ToBase64String(cipherBytes);

                return encryptedData;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// AES 128 Decry
        /// </summary>
        public string AES128Decry(string text, string key)
        {
            try
            {
                var rijndaelCipher = new RijndaelManaged();

                var encryptedData = Convert.FromBase64String(text);
                var salt = Encoding.ASCII.GetBytes(key.Length.ToString());

                var secretKey = new PasswordDeriveBytes(key, salt);
                var decryptor = rijndaelCipher.CreateDecryptor(secretKey.GetBytes(32), secretKey.GetBytes(16));
                var memoryStream = new MemoryStream(encryptedData);
                var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

                var plainText = new byte[encryptedData.Length];

                var decryptedCount = cryptoStream.Read(plainText, 0, plainText.Length);

                memoryStream.Close();
                cryptoStream.Close();

                var decryptedData = Encoding.Unicode.GetString(plainText, 0, decryptedCount);

                return decryptedData;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion
    }
}