using EWXICQBotAPI;
using EWXICQBotAPI.Responses.AbstractResponses;
using System;
using System.IO;

namespace EWXICQBotAPI_Tests
{
    internal class Program
    {
        private static ICQBot _bot;
        private static string _token;

        static void Main(string[] args)
        {
            LoadToken();
            Console.Write("Init bot... ");
            _bot = new ICQBot(_token);
            Console.WriteLine("Done!\n");
            Console.Write("Test 1: SelfGet... ");
            Console.WriteLine(SelfGet() ? "Passed!" : "Failed!");
            ////    Basic tests, test that API methods works

            //  Test /self/get

            //  Test /messages/sendText

            //  Test /messages/sendFile

            //  Test /messages/sendVoice

            //  Test /messages/editText

            //  Test /messages/deleteMessages

            //  Test /messages/answerCallbackQuery

            //  Test /chats/members/delete

            //  Test /chats/avatar/set

            //  Test /chats/sendActions

            //  Test /chats/getInfo

            //  Test /chats/getAdmins

            //  Test /chats/getMembers

            //  Test /chats/getBlockedUsers

            //  Test /chats/getPendingUsers

            //  Test /chats/blockUser

            //  Test /chats/unblockUser

            //  Test /chats/resolvePending

            //  Test /chats/setTitle

            //  Test /chats/setAbout

            //  Test /chats/setRules

            //  Test /chats/pinMessage

            //  Test /chats/unpinMessage

            //  Test /files/getInfo

            //  Test /events/get

            ////    Global test

            Console.WriteLine("All tests passed. Press any key to close this window");
            Console.ReadKey();
        }

        private static void LoadToken()
        {
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + "EWXICQTest"; // Path.DirectorySeparatorChar + "session.ewx"
            if (!Directory.Exists(filepath)) Directory.CreateDirectory(filepath);
            filepath += Path.DirectorySeparatorChar + "session.ewx";
            if (File.Exists(filepath))
            {
                string token = File.ReadAllText(filepath);
                _token = token;
            }
            else
            {
                Console.WriteLine("Enter your token below:");
                string input = Console.ReadLine();
                _token = input;
                try
                {
                    StreamWriter file = new StreamWriter(filepath);
                    file.WriteLine(input);
                    file.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occured. See the stacktrace below:");
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        // Tests

        private static bool SelfGet()
        {
            ICQASelfGetResponse response = _bot.APIAbsSelfGet();
            if (response.ok) return true;
            return false;
        }
    }
}
