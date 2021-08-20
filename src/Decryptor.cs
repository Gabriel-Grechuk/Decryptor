using System;

using DecryptInfo;
using DecryptIO;
using DecryptArgs;
using DecryptError;
using DecryptAES;


class Decryptor
{
    public static void Main(string[] args)
    {
        Args.Validate(args);
        IO.Print(Args.ArgsToHeaderString());
        AES.RunDecryptor(Decrypt.path, Decrypt.key, Decrypt.crypterExt);

        Success.Exit();
    }
}
