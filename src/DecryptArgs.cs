using DecryptInfo;
using DecryptIO;
using DecryptError;

namespace DecryptArgs
{
    class Args
    {
        public static void Validate(string[] args)
        {
            if(args.Length == 0)
    		{
                Error.ThrowError(ErrorCode.IO_NO_ARGUMENTS);
    		}
    		else
    		{
    			int index = 0;
    			foreach (string arg in args)
    			{
    				switch(arg)
    				{
    					case "-k":
    						Decrypt.key = args[index + 1];
    						break;

    					case "-p":
    						Decrypt.path = args[index + 1];
    						break;

    					case "-e":
    						Decrypt.crypterExt = args[index + 1];
    						break;
    				}
    				index++;
    			}
    		}
    		if (Decrypt.key == "" || Decrypt.crypterExt == "" || Decrypt.path == "")
    		{
    			Error.ThrowError(ErrorCode.IO_MISSING_ARGUMENT);
    		}
        }


        public static string ArgsToHeaderString()
        {
            return "Key..............: " + Decrypt.key +
                    "\nFile Extetition..: " + Decrypt.crypterExt +
                    "\nPath.............: " + Decrypt.path + "\n";
        }
    }
}
