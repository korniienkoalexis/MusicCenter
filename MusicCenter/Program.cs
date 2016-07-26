using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCenter
{
    class Program
    {
        static void Main(string[] args)
        {

            IDictionary<string, Device> devDictionary = new Dictionary<string, Device>();


            devDictionary.Add("Radiola", new Radio(true, "Radiola", new Volume(), new RadioChannel(88.5F)));
            devDictionary.Add("LG", new TV(true, "LG", new TVChanneChangel(), new Volume()));
            devDictionary.Add("Sony", new MusicCenter(true, "Sony", new Volume(), new RadioChannel(88.5F), new ChangeCD(1), new MusicMode()));
            devDictionary.Add("Libher", new Refrigerator(true, "Libher" ,new ChangeFrostMode() , false, false));
            devDictionary.Add("Midea", new AirCond(true, "Midea", new AirCondModeChng(), new Temperature()));

            while (true)
            {
                Console.Clear();
                foreach (var devs in devDictionary)
                {
                    Console.WriteLine("Name: " + devs.Key + ", " + devs.Value.Info());
                }

                Console.WriteLine();
                Console.Write("Enter command: ");

                string[] commands = Console.ReadLine().Split(' ');
                if (commands[0].ToLower() == "exit" & commands.Length == 1)
                
                {
                    return;
                }

                if (commands[0].ToLower() == "add" && devDictionary.ContainsKey(commands[2]))
                {
                    Console.WriteLine("Device with name " + commands[0] + " exists, please enter another name");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    continue;
                }

               if (commands[0].ToLower() == "add")
                {
                    if (commands.Length == 3)
                    {
                        if (!devDictionary.ContainsKey(commands[2]))
                        {
                            switch (commands[1].ToLower())
                            {
                                case "radio":
                                    devDictionary.Add(commands[2], new Radio(true, commands[2], new Volume(), new RadioChannel(88.5F)));
                                    break;
                                case "tv":
                                    devDictionary.Add(commands[2], new TV(true, commands[2], new TVChanneChangel(), new Volume()));
                                    break;
                                case "musiccenter":
                                    devDictionary.Add(commands[2], new MusicCenter(true, commands[2], new Volume(), new RadioChannel(88.5F) , new ChangeCD(1), new MusicMode()));
                                    break;
                                case "fridge":
                                    devDictionary.Add(commands[2], new Refrigerator(true, commands[2], new ChangeFrostMode(), false ,false));
                                    break;
                                
                                default:
                                    DevicesList();
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Help();
                        continue;
                    }
                    continue;
                }

               
                
                if (commands.Length == 2 && devDictionary.ContainsKey(commands[0]))
                {
                    switch (commands[1].ToLower())
                    {
                        case "volume+":
                            if (devDictionary[commands[0]] is IVolume)
                            {
                                ((IVolume)devDictionary[commands[0]]).UpVolume();
                            }
                            else
                            {
                                Console.WriteLine("Device with name " + commands[0] + " dosn`t exist");
                                Console.ReadLine();
                            }
                            break;

                        case "volume-":
                            if (devDictionary[commands[0]] is IVolume)
                            {
                                ((IVolume)devDictionary[commands[0]]).DownVolume();
                            }
                            else
                            {
                                Console.WriteLine("Device with name " + commands[0] + " dosn`t exist");
                                Console.ReadLine();
                            }
                            break;

                        case "nxtchannel":
                            if (devDictionary[commands[0]] is ITVChangeChannel)
                            {
                                ((ITVChangeChannel)devDictionary[commands[0]]).NextChannal();
                            }
                            else
                            {
                                Console.WriteLine("Device with name " + commands[0] + " dosn`t exist");
                                Console.ReadLine();
                            }
                            break;

                        case "prvchannel":
                            if (devDictionary[commands[0]] is ITVChangeChannel)
                            {
                                ((ITVChangeChannel)devDictionary[commands[0]]).PrevChannel();
                            }
                            else
                            {
                                Console.WriteLine("Device with name " + commands[0] + " dosn`t exist");
                                Console.ReadLine();
                            }
                            break;
                        case "tuneup":
                            if (devDictionary[commands[0]] is IRadioChannel)
                            {
                                ((IRadioChannel)devDictionary[commands[0]]).NextChannal();
                            }
                            else
                            {
                                Console.WriteLine("Device with name " + commands[0] + " dosn`t exist");
                                Console.ReadLine();
                            }
                            break;
                        case "tunedwn":
                            if (devDictionary[commands[0]] is IRadioChannel)
                            {
                                ((IRadioChannel)devDictionary[commands[0]]).PrevChannel();
                            }
                            else
                            {
                                Console.WriteLine("Device with name " + commands[0] + " dosn`t exist");
                                Console.ReadLine();
                            }
                            break;
                        case "on":
                            if (devDictionary[commands[0]] is IOnOff)
                            {
                                ((IOnOff)devDictionary[commands[0]]).On();
                            }
                            else
                            {
                                Console.WriteLine("Device with name " + commands[0] + " dosn`t exist");
                                Console.ReadLine();
                            }
                            break;

                        case "off":
                            if (devDictionary[commands[0]] is IOnOff)
                            {
                                ((IOnOff)devDictionary[commands[0]]).Off();
                            }
                            else
                            {
                                Console.WriteLine("Device with name " + commands[0] + " dosn`t exist");
                                Console.ReadLine();
                            }
                            break;

                        case "del":
                            if (devDictionary.ContainsKey(commands[0]))
                        {
                            devDictionary.Remove(commands[0]);
                        }
                        else
                        {
                            Console.WriteLine("Device with name " + commands[0] + "dosn`t exist");
                            Console.ReadLine();
                        }
                        break;

                        case "mode":
                        if (devDictionary[commands[0]] is IDeviceChangeMode)
                        {
                            ((IDeviceChangeMode)devDictionary[commands[0]]).ChangeMode();
                        }
                        else
                        {
                            Console.WriteLine("Device with name " + commands[0] + "dosn`t exist");
                            Console.ReadLine();
                        }
                        break;

                        case "open":
                        if (devDictionary[commands[0]] is IdoorOpen)
                        {
                            ((IdoorOpen)devDictionary[commands[0]]).RefrigeratDoorOpen();
                        }
                        else
                        {
                            Console.WriteLine("Device with name " + commands[0] + "dosn`t exist");
                            Console.ReadLine();
                        }
                        break;
                        case "close":
                        if (devDictionary[commands[0]] is IdoorOpen)
                        {
                            ((IdoorOpen)devDictionary[commands[0]]).RefrigeratDoorClose();
                        }
                        else
                        {
                            Console.WriteLine("Device with name " + commands[0] + "dosn`t exist");
                            Console.ReadLine();
                        }
                        break;

                        case "fclose":
                        if (devDictionary[commands[0]] is IFrostdoorOpen)
                        {
                            ((IFrostdoorOpen)devDictionary[commands[0]]).frostDoorStateClose();
                        }
                        else
                        {
                            Console.WriteLine("Device with name " + commands[0] + "dosn`t exist");
                            Console.ReadLine();
                        }
                        break;

                        case "fopen":
                        if (devDictionary[commands[0]] is IFrostdoorOpen)
                        {
                            ((IFrostdoorOpen)devDictionary[commands[0]]).frostDoorStateOpen();
                        }
                        else
                        {
                            Console.WriteLine("Device with name " + commands[0] + "dosn`t exist");
                            Console.ReadLine();
                        }
                        break;

                        case "temperature+":
                        if (devDictionary[commands[0]] is ITemperature)
                        {
                            ((ITemperature)devDictionary[commands[0]]).UpTemperature();
                        }
                        else
                        {
                            Console.WriteLine("Device with name " + commands[0] + "dosn`t exist");
                            Console.ReadLine();
                        }
                        break;

                        case "temperature-":
                        if (devDictionary[commands[0]] is ITemperature)
                        {
                            ((ITemperature)devDictionary[commands[0]]).DownTemperature();
                        }
                        else
                        {
                            Console.WriteLine("Device with name " + commands[0] + "dosn`t exist");
                            Console.ReadLine();
                        }
                        break;
                    }
                }
            }
            
        }
        private void Options(int key)
        {
            //Console.WriteLine("{0}: {1}", devDictionary.ElementAt(key).Key, devDictionary.ElementAt(key).Value);
        }

        private static void Help()
        {
            Console.WriteLine("Type of device");
            Console.WriteLine("\tlamp");
            Console.WriteLine("\tmusiccenter");
            Console.WriteLine("\tfridge");
            Console.WriteLine("\tradio");
            Console.WriteLine("\ttv");

            Console.WriteLine("Доступные команды для них:");
            Console.WriteLine("\tadd device name");
            Console.WriteLine("\tname device del ");

            Console.WriteLine("\tname on");
            Console.WriteLine("\tname off");
            Console.WriteLine("\tname open");
            Console.WriteLine("\tname close");

            Console.WriteLine("    Commands for device tv, radio and MusicCenter");
            Console.WriteLine("\tname nxtchannel");
            Console.WriteLine("\tname prvchannel");
            Console.WriteLine("\tname volume-");
            Console.WriteLine("\tname volume+");
            Console.WriteLine("\tname mode");

            Console.WriteLine("    Commands for device fridge ");
            Console.WriteLine("\tname mode");
            Console.WriteLine("\tname open");
            Console.WriteLine("\tname close");
            Console.WriteLine("\tname fopen");
            Console.WriteLine("\tname fclose");

            Console.WriteLine("    Commands for device AirCoonditioner ");
            Console.WriteLine("\tname temperature+");
            Console.WriteLine("\tname temperature-");
            Console.WriteLine("\tname mode");

            Console.WriteLine("\texit");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadLine();
        }

        private static void DevicesList()
        {
            Console.WriteLine("Список доступных устройств");
            Console.WriteLine("\tradio - Radio");
            Console.WriteLine("\ttv - TV");
            Console.WriteLine("\tmusiccenter - Music Center");
            Console.WriteLine("\tfridge - Refregirator");
            Console.WriteLine("\tairconditioner - AirConditioner");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

        }


    }

}
