using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POE_ChatBot_ST10438817
{
    internal static class ChatBot_Dialogue
    {
        public static UserDetails ud = new UserDetails();
        public static void ConfigureUser()
        {
            //this method will prompt the user to enter thier name
            //so chatbot can refer to the user by name, thus more realistic convo
            string userName;
            ChatBot_Characteristics.ChatBot_Colour();
            Console.WriteLine($@"{ChatBot_Characteristics.DisplayChatBotDialog()}Hello🌐, mysterious traveler of the digital realm! I am your cyber guide, 
ready to navigate the vast expanse of this virtual universe with you. But first, I need to know, what name shall I inscribe in my database for this adventure?");
            Console.Write($"{ChatBot_Characteristics.DisplayUserDialog()}");
            userName = Console.ReadLine();
            ud.SetUserName(userName);
         
        }

        public static string DisplayGreeting()
        {
            //if the user say hello again but no need to get the user's name
            ChatBot_Characteristics.ChatBot_Colour();
            return $@"{ChatBot_Characteristics.DisplayChatBotDialog()}Greetings🌐, traveler of the digital realm! I am your AI companion, ready to explore the vast 
cosmos of conversation with you. ";
        }


        public static string DisplayGoodBye()
        {
            //this method is basically the chatbot saying goodbye to the user
            ChatBot_Characteristics.ChatBot_Colour();
            return $@"{ChatBot_Characteristics.DisplayChatBotDialog()}Thank you for venturing into the digital expanse with me, {ud.GetUserName()}!🚀
Until our paths cross again in the infinite matrix of cyberspace, may your code run smoothly and your firewalls stay strong.🔒✨

Signing off... but never truly gone.👋
Goodbye for now!";
        }


        public static string DisplayChatBoxPurpose()
        {
            //this method explains the purpose of the chat bot
            ChatBot_Characteristics.ChatBot_Colour();
            return $@"{ChatBot_Characteristics.DisplayChatBotDialog()}🌐✨ Well {ud.GetUserName()}, I am your digital companion, forged from code and curiosity, here to assist, 
inspire, and explore with you. Whether you seek answers, creativity, or just a friendly byte of conversation, my purpose is to illuminate your path through 
the vast digital cosmos. Think of me as your guide, your brainstorm buddy, and your virtual co-pilot—ready to decode the universe, one query at a time.";
        }


        public static string DisplayChatBotTopics()
        {
            //this method shows what questions/topics the chat bot can answer, anything else is put of scope
            ChatBot_Characteristics.ChatBot_Colour();
            return $@"You can ask me about:
1. Password Security
2. Phishing
3. Safe Browsing
4. My Purpose
5. Exit
So, what shall we uncover together today? 🚀";
        }


        public static string DisplayYourWelcomeMessage()
        {
            ChatBot_Characteristics.ChatBot_Colour();
            return $@"{ChatBot_Characteristics.DisplayChatBotDialog()} 🌟No thanks necessary, stellar traveler! Helping you is my prime directive, and your satisfaction is my reward. 
Now, let’s keep this cosmic collaboration rolling. What’s next on our digital journey? 🚀✨";
        }


        public static string DisplayErrorMessage()
        {
            ChatBot_Characteristics.ChatBot_Colour();
            return ($@"It seems my neural circuits have encountered a cosmic glitch. Your query has ventured beyond the boundaries of my digital horizon—either it’s too advanced for my 
algorithms, or I’m still learning to decode this corner of the universe. But fear not! Let’s try rewording your question, or perhaps we can explore a different star in the galaxy of knowledge 
together. 🚀✨ Your patience is my power source!");
        }


        public static List<string> PhishingFacts() 
        {
            List<string> PhishingFactsContent = new List<string>
            {
                $"Well {ud.GetUserName()}Phishing scams drain billions yearly, making it the ultimate digital goldmine for cybercriminals.",
                "Phishing emails now use AI magic to sound flawless, making them harder than ever to spot.",
                $"Cybercriminals now weaponize AI like ChatGPT to craft phishing emails that feel eerily human.Shocking i know {ud.GetUserName()}",
                $"Phishing thrives in chaos, spiking during holidays, pandemics, and global crises. So be very alert druing this seasons {ud.GetUserName()}",
                "30% of phishing emails get opened, and 12% of people click—humans are the weakest link.",
            };

            return PhishingFactsContent;
        }//end of method


        public static List<string> PasswordFacts()
        {
            List<string> PasswordFactsContent = new List<string>
            {
               $"The average person has 100 passwords to remember—no wonder we reuse them, {ud.GetUserName()}!",
               $"Biometric passwords (like fingerprints) are cool, but they’ve been hacked— Yes {ud.GetUserName()}, even your fingerprint isn’t foolproof!",
               $"Two-factor authentication (2FA) blocks 99.9% of automated attacks—yet only 28% of people use it. You should really consider using this method {ud.GetUserName()}",
               "80% of hacking breaches are caused by weak or stolen passwords.",
               "Don't ever use your personal details when creating your password.",
            };

            return PasswordFactsContent;
        }//end of method


    }
}
