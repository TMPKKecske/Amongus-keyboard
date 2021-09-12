using System;
using System.Collections.Generic;
using System.Globalization;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace amongus_keyboard
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int key);


        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            string BaseDir = System.AppDomain.CurrentDomain.BaseDirectory;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string amogus =
            @"        
 $$$$$$\  $$\      $$\  $$$$$$\   $$$$$$\  $$\   $$\  $$$$$$\  
$$  __$$\ $$$\    $$$ |$$  __$$\ $$  __$$\ $$ |  $$ |$$  __$$\ 
$$ /  $$ |$$$$\  $$$$ |$$ /  $$ |$$ /  \__|$$ |  $$ |$$ /  \__|
$$$$$$$$ |$$\$$\$$ $$ |$$ |  $$ |$$ |$$$$\ $$ |  $$ |\$$$$$$\  
$$  __$$ |$$ \$$$  $$ |$$ |  $$ |$$ |\_$$ |$$ |  $$ | \____$$\ 
$$ |  $$ |$$ |\$  /$$ |$$ |  $$ |$$ |  $$ |$$ |  $$ |$$\   $$ |
$$ |  $$ |$$ | \_/ $$ | $$$$$$  |\$$$$$$  |\$$$$$$  |\$$$$$$  |
\__|  \__|\__|     \__| \______/  \______/  \______/  \______/ 
                            _  __                 _                                  _ 
                           | |/ /                | |                                | |
                           | ' /    ___   _   _  | |__     ___     __ _   _ __    __| |
                           |  <    / _ \ | | | | | '_ \   / _ \   / _` | | '__|  / _` |
                           | . \  |  __/ | |_| | | |_) | | (_) | | (_| | | |    | (_| |
                           |_|\_\  \___|  \__, | |_.__/   \___/   \__,_| |_|     \__,_|
                                           __/ |                                       TM
                                          |___/        
                                              by TMPKKecske
            ";

            Console.WriteLine(amogus);

            int[] AMOGUSKeys =             {

0x09,
0x0C,
0x10,
0x11,
0x12,
0x13,
0x14,
0x15,
0x16,
0x17,
0x18,
0x19,
0x1A,
0x1B,
0x1C,
0x1D,
0x1E,
0x1F,
0x21,
0x22,
0x23,
0x24,
0x25,
0x26,
0x27,
0x28,
0x29,
0x2A,
0x2B,
0x2C,
0x2D,
0x2E,
0x2F,
0x30,
0x31,
0x32,
0x33,
0x34,
0x35,
0x36,
0x37,
0x38,
0x39,
0x41,
0x42,
0x43,
0x44,
0x45,
0x46,
0x47,
0x48,
0x49,
0x4A,
0x4B,
0x4C,
0x4D,
0x4E,
0x4F,
0x50,
0x51,
0x52,
0x53,
0x54,
0x55,
0x56,
0x57,
0x58,
0x59,
0x5A,
0x5B,
0x5C,
0x5D,
0x5E,
0x5F,
0x67,
0x68,
0x69,
0x6A,
0x6B,
0x6C,
0x6D,
0x6E,
0x6F,
0x70,
0x71,
0x72,
0x73,
0x74,
0x75,
0x76,
0x77,
0x78,
0x79,
0x7A,
0x7B,
0x7C,
0x7D,
0x7E,
0x7F,
0x80,
0x81,
0x82,
0x83,
0x84,
0x85,
0x86,
0x87,
0x90,
0x91,
0xA0,
0xA1,
0xA2,
0xA3,
0xA4,
0xA5,
0xA6,
0xA7,
0xA8,
0xA9,
0xAA,
0xAB,
0xAC,
0xAD,
0xAE,
0xAF,
0xB0,
0xB1,
0xB2,
0xB3,
0xB4,
0xB5,
0xB6,
0xB7,
0xBA,
0xBB,
0xBC,
0xBD,
0xBE,
0xBF,
0xC0,
0xDB,
0xDC,
0xDD,
0xDE,
0xDF,
0xE1,
0xE2,
0xE5,
0xE6,
0xE7,
0xF6,
0xF7,
0xF8,
0xF9,
0xFA,
0xFB,
0xFC,
0xFD,
0xFE
            };



            IDictionary<int, bool> AMOGUSKeyBools = new Dictionary<int, bool>();
            bool IsBackSpace = false;
            bool IsSpace = false;
            bool IsEnter = false;
            bool IsNum1 = false;
            bool IsNum2 = false;
            bool IsNum3 = false;
            bool IsNum4 = false;
            bool IsNum5 = false;
            bool IsNum6 = false;
            bool IsNum7 = false;


            bool dontstop = false;

            foreach (int key in AMOGUSKeys)
            {
                AMOGUSKeyBools.Add(key, false);
            }



            while (true)
            {
                foreach (int key in AMOGUSKeys)
                {
                    if ((GetAsyncKeyState(key) & 0x8000) > 0)
                    {                        
                        if (!AMOGUSKeyBools[key])
                        {
                            AMOGUSKeyBools[key] = true;
                            Console.WriteLine($"You pressed a key... real sussy");
                            using (var soundPlayer = new SoundPlayer(BaseDir + @"obj\Debug\netcoreapp3.1\AMOGUS.wav"))
                            {
                                soundPlayer.Play();
                            }
                        }
                    }
                    else
                    {
                        AMOGUSKeyBools[key] = false;
                    }
                }
                System.Media.SoundPlayer SUGOMAPlayer = new System.Media.SoundPlayer(BaseDir + @"obj\Debug\netcoreapp3.1\SUGOMA.wav");

                if ((GetAsyncKeyState(0x08) & 0x8000) > 0)
                {
                    if (!IsBackSpace)
                    {
                        IsBackSpace = true;
                        Console.WriteLine("You pressed backspace... real sussy");
                        SUGOMAPlayer.Play();
                    }
                }
                else
                {
                    IsBackSpace = false;
                }

                System.Media.SoundPlayer STOPPlayer = new System.Media.SoundPlayer(BaseDir + @"obj\Debug\netcoreapp3.1\STOP.wav");

                if ((GetAsyncKeyState(0x20) & 0x8000) > 0)
                {
                    if (!IsSpace)
                    {
                        IsSpace = true;
                        dontstop = false;
                        Console.WriteLine("You pressed space... real sussy");
                        STOPPlayer.Play();
                    }
                }
                else
                {
                    IsSpace = false;
                    if (!dontstop)
                    {
                        STOPPlayer.Stop();
                        dontstop = true;
                    }
                }

                System.Media.SoundPlayer OnePlayer = new System.Media.SoundPlayer(BaseDir + @"obj\Debug\netcoreapp3.1\1.wav");

                if ((GetAsyncKeyState(0x61) & 0x8000) > 0)
                {
                    if (!IsNum1)
                    {
                        IsNum1 = true;
                        Console.WriteLine("You pressed the NUM 1 key... real sussy ");
                        OnePlayer.Play();
                    }
                }
                else
                {
                    IsNum1 = false;
                }

               System.Media.SoundPlayer TwoPlayer = new System.Media.SoundPlayer(BaseDir + @"obj\Debug\netcoreapp3.1\2.wav");

                if ((GetAsyncKeyState(0x62) & 0x8000) > 0)
                {
                    if (!IsNum2)
                    {
                        IsNum2 = true;
                        Console.WriteLine("You pressed the NUM 2 key... real sussy");
                        TwoPlayer.Play();
                    }
                }
                else
                {
                    IsNum2 = false;
                }

                System.Media.SoundPlayer ThreePlayer = new System.Media.SoundPlayer(BaseDir + @"obj\Debug\netcoreapp3.1\3.wav");

                if ((GetAsyncKeyState(0x63) & 0x8000) > 0)
                {
                    if (!IsNum3)
                    {
                        IsNum3 = true;
                        Console.WriteLine("You pressed the NUM 3 key... real sussy");
                        ThreePlayer.Play();
                    }
                }
                else
                {
                    IsNum3 = false;
                }

                System.Media.SoundPlayer FourPlayer = new System.Media.SoundPlayer(BaseDir + @"obj\Debug\netcoreapp3.1\4.wav");

                if ((GetAsyncKeyState(0x64) & 0x8000) > 0)
                {
                    if (!IsNum4)
                    {
                        IsNum4 = true;
                        Console.WriteLine("You pressed the NUM 4 key... real sussy");
                        FourPlayer.Play();
                    }
                }
                else
                {
                    IsNum4 = false;
                }

                System.Media.SoundPlayer FivePlayer = new System.Media.SoundPlayer(BaseDir + @"obj\Debug\netcoreapp3.1\5.wav");

                if ((GetAsyncKeyState(0x65) & 0x8000) > 0)
                {
                    if (!IsNum5)
                    {
                        IsNum5 = true;
                        Console.WriteLine("You pressed the NUM 5 key... real sussy");
                        FivePlayer.Play();
                    }
                }
                else
                {
                    IsNum5 = false;
                }

                System.Media.SoundPlayer SixPlayer = new System.Media.SoundPlayer(BaseDir + @"obj\Debug\netcoreapp3.1\6.wav");

                if ((GetAsyncKeyState(0x60) & 0x8000) > 0)
                {
                    if (!IsNum6)
                    {
                        IsNum6 = true;
                        Console.WriteLine("You pressed the NUM 0 key... real sussy");
                        SixPlayer.Play();
                    }
                }
                else
                {
                    IsNum6 = false;
                }

                System.Media.SoundPlayer SevenPlayer = new System.Media.SoundPlayer(BaseDir + @"obj\Debug\netcoreapp3.1\7.wav");

                if ((GetAsyncKeyState(0x66) & 0x8000) > 0)
                {
                    if (!IsNum7)
                    {
                        IsNum7 = true;
                        Console.WriteLine("You pressed the NUM 6 key... real sussy");
                        SevenPlayer.Play();
                    }
                }
                else
                {
                    IsNum7 = false;
                }

                System.Media.SoundPlayer EnterPlayer = new System.Media.SoundPlayer(BaseDir + @"obj\Debug\netcoreapp3.1\Enter.wav");

                if ((GetAsyncKeyState(0x0D) & 0x8000) > 0)
                {
                    if (!IsEnter)
                    {
                        IsEnter = true;
                        Console.WriteLine("You pressed the Enter key... real sussy");
                        EnterPlayer.Play();
                    }
                }
                else
                {
                    IsEnter = false;
                }

            }
        }
    }
}
