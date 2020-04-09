using System;
using System.Text;

namespace SF_Form.EncrySample
{
    internal class SimpleEncryption
    {
        private static SimpleEncryption _instance;
        public static SimpleEncryption EnDecry
        {
            get
            {
                if (_instance == null)
                    _instance = new SimpleEncryption();

                return _instance;
            }
        }

        public string LineEncry(string strData, string key)
        {
            try
            {
                int p1Len = strData.Length;
                int p2Len = key.Length;

                int k = 0, loopJ = 0;

                StringBuilder sb1 = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();

                int ch1, ch2;
                int tempCh;
                while (k < p1Len)
                {
                    ch1 = strData[k];//int.Parse(strData[k].ToString());
                    ch2 = (int)key[loopJ];
                    tempCh = ch1 ^ ch2;

                    sb1.Append(tempCh.ToString());
                    sb2.Append(tempCh.ToString().Length.ToString());

                    if (loopJ == p2Len - 1)
                    {
                        loopJ = 0;
                    }

                    loopJ += 1;

                    k++;
                }
                return sb1.ToString() + "#" + sb2.ToString();
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string LineDecry(string strData, string key)
        {
            try {
                string result = string.Empty;
                string[] sptStr = strData.Split('#');
                int p1Len = sptStr[0].Length;
                int p2Len = sptStr[1].Length;

                int loopJ = 0, j = 0, i = 0;

                StringBuilder sb1 = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();

                int ch1, ch2;
                int tempCh;
                while (j < p1Len)
                {
                    //int len = sptStr[1][loopJ];//int.Parse(sptStr[1][loopJ].ToString());
                    int len = int.Parse(sptStr[1][loopJ].ToString());
                    ch1 = int.Parse(sptStr[0].Substring(j, len));
                    j += len;
                    ch2 = (int)key[i];
                    tempCh = ch1 ^ ch2;

                    sb1.Append(((char)tempCh).ToString());

                    if (loopJ == p2Len - 1)
                    {
                        loopJ = 0;
                    }

                    if (i == key.Length - 1)
                    {
                        i = 0;
                    }

                    loopJ += 1;
                    i += 1;
                }

                result += sb1.ToString();
                result += sb2.ToString();
                return result;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

    }
}