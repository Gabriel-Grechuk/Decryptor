using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

using DecryptError;
using DecryptIO;

namespace DecryptAES
{
    class AES
    {
        private static void Decrypt(string file, string key, string crypterExt)
    	{
    		if(!File.Exists(file))
    		{
    			Error.ThrowError(ErrorCode.IO_FILE_NOT_FOUND);
    		}
    		else if (file.EndsWith(crypterExt))
    		{
    			using (FileStream filestream = File.Open(file, FileMode.Open, FileAccess.Read))
    			{
    				using (FileStream stream = new FileStream(file.Replace(crypterExt, ""), FileMode.Create, FileAccess.Write))
    				{
    					using (Rijndael AES = new RijndaelManaged())
    					{
    						AES.Key = (new SHA256Managed()).ComputeHash(Encoding.ASCII.GetBytes(key));
    						AES.Mode = CipherMode.ECB;
    						using (CryptoStream crypto = new CryptoStream(stream, AES.CreateDecryptor(), CryptoStreamMode.Write))
    						{
    							byte[] buffer = new byte[filestream.Length];
    							while (filestream.Read(buffer, 0, buffer.Length) > 0)
    							{
    								crypto.Write(buffer, 0, buffer.Length);
    							}
    						}
    					}
    				}
    			}

    			IO.Success("File: " + file + " decrypted!!!");
    		}
    	}


        public static void RunDecryptor(string dir, string key, string crypterExt)
        {
            FileAttributes attr = File.GetAttributes(dir);
            if((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                foreach (string file in Directory.GetFiles(dir))
                {
                    Decrypt(file, key, crypterExt);
                }
                foreach (string subDir in Directory.GetDirectories(dir))
                {
                    RunDecryptor(subDir, key, crypterExt);
                }
            }
            else
            {
                Decrypt(dir, key, crypterExt);
            }
        }
    }
}
