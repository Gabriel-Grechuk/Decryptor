using System;

using DecryptIO;


namespace DecryptError
{
    //--------------------------------------------------------------------------
    public enum ErrorCode
    {
        OK = 0,
        IO_NO_ARGUMENTS = 1,
        IO_MISSING_ARGUMENT = 2,
        IO_FILE_NOT_FOUND = 3
    };



    //--------------------------------------------------------------------------
    class Error
    {
        public static string[] ErrorString = {
            "[CODE 0] - SUCCESS.",
            "[CODE 1] - IO_NO_ARGUMENTS > No commnad-line arguments.",
            "[CODE 2] - IO_MISSING_ARGUMENT > Missing Command line argument.",
            "[CODE 3] - IO_FILE_NOT_FOUND > File to decrypt not found."
        };

        // Method to throw an error. Prints the error message and quits the program.
        public static void ThrowError(ErrorCode error)
        {
            IO.Error(ErrorString[(int)error]);
            System.Environment.Exit((int)error);
        }
    }



    //--------------------------------------------------------------------------
    class Success
    {
        public static void Exit()
        {
            IO.Success("Execution successful.");
            System.Environment.Exit(0);
        }
    }
}
