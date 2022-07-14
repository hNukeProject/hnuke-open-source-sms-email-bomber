/////////////////////////////////////////////////////////////////////////
//hNuke Open Source SMS/Email Bomber by Investor @ Hackforums.net 2022
//ALL RIGHTS RESERVED, MAY NOT BE USED FOR RESALE AS IS. 
//OPEN SOURCE UNDER THE MIT LICENSE. 
//AUTHGG SETUP & SUPPORT NOT INCLUDED. DO NOT SOLICIT
/////////////////////////////////////////////////////////////////////////
using AuthGG;

namespace hNuke
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            OnProgramStart.Initialize("APPNAME", "AID", "PROGRAMSECRET", "VERSION");
            ApplicationConfiguration.Initialize();
            Application.Run(new License());
        }
    }
}