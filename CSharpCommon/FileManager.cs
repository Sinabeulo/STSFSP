using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCommon
{
    public class FileManager
    {
        public static FileManager FileReadWriter
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FileManager();
                }
                return _instance;
            }
        }

        private static FileManager _instance;

        public bool FileWriter(string path, List<string> data)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        foreach (var line in data)
                        {
                            writer.WriteLine(line);
                        }   
                    }
                }
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool FileWriter(string path, string data)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        writer.WriteLine(data);
                    }
                }
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> FileReaderToList(string path)
        {
            try
            {
                List<string> retData = new List<string>();
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        while (!reader.EndOfStream)
                        {
                            retData.Add(reader.ReadLine());
                        }
                    }
                }
                return retData;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<string> FileReaderToString(string path)
        {
            try
            {
                string retData = string.Empty;

                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fs))
                {
                    retData = await reader.ReadToEndAsync();
                }

                return retData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}