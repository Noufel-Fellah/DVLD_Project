using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;


namespace bussinessLayer
{
    public class GlobalSettings
    {

       public static string ComputeHash(string input)
        {
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));


                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }


        private static string SourceName = "DVLD_APPLICATION";
        public static void CreateEventLog(string message, Exception ex, EventLogEntryType level)
        {



            //string source = @"MyAppNoufel";
            //Create the event source if it does not exist
            if (!(EventLog.SourceExists(SourceName)))
            {
                EventLog.CreateEventSource(SourceName, "Application", ".");
                //Console.WriteLine("Event source has been created successfully");


            }
            if (ex != null) message = message + ex.Message;



            EventLog.WriteEntry(SourceName, message  ,level);





        }
        public static clsUser currentUser;
        public static bool UserEntredBefore=false;
        public static bool saveUserNameAndPassword(string userName,string password,string separator="#//#")
        {

            //if (File.Exists(filePath))
            //{
            //    // Create a file to write to.
            //    string[] createText = { userName+separator+password };

            //    File.WriteAllLines(filePath, createText, Encoding.UTF8);
               
            //    return true;
            //}
            //// Specify the Registry key and path
           
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";
            string valueName = "DVLD_INFORMATION";
            string inforamtion = userName + separator + password;


            try
            {
                // Write the value to the Registry
                Registry.SetValue(keyPath, valueName, inforamtion, RegistryValueKind.String);

                return true;
                // Console.WriteLine($"Value {valueName} successfully written to the Registry.");
            }
            catch (Exception ex)
            {
                return false;
                //Console.WriteLine($"An error occurred: {ex.Message}");
            }
           

        }
       
        public static string [] RememberMe()
        {
            string record = "";
            string[] UsernameAndPassword= { "",""} ;
            // Specify the Registry key and path
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";
            string valueName = "DVLD_INFORMATION";


            try
            {
                // Read the value from the Registry
                record= Registry.GetValue(keyPath, valueName, null) as string;


                if (record != null)
                {
                    //Console.WriteLine($"The value of {valueName} is: {value}");
                    int pos = record.IndexOf("#//#");
                    UsernameAndPassword[0] = record.Substring(0, pos);
                    UsernameAndPassword[1] = record.Substring(pos + 4);
                    return UsernameAndPassword;
                }
                else
                {
                    //Console.WriteLine($"Value {valueName} not found in the Registry.");
                    return UsernameAndPassword;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"An error occurred: {ex.Message}");
                return UsernameAndPassword;
            }


        }


    }
}
