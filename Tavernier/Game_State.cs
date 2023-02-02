using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;

namespace Tavernier
{
    public class Game_State
    {
        private bool _end_Game = false;

        public Balfis_Character? Balfis { get; set; }
        public Nina_Character? Nina { get; set; }
        public Elizendre_Character? Elizendre { get; set; }
        public Laevis_Character? Laevis { get; set; }

        private Map_State _map = new Map_State();
        private int player_posX { get; set; }
        private int player_posY { get; set; }

        private Fight_State _fight = new Fight_State();
        private Character _playerSelected = new Character();
        private Character _enemySelected = new Character();

        private Menu_State _menu = new Menu_State();

        private int _stockRandom = 0;
        private Random random = new Random();

        public Game_State() 
        {
            SerializeTheObject loadSave;
            string loadString;
            loadString = File.ReadAllText("save.json");
            loadSave = JsonSerializer.Deserialize<SerializeTheObject>(loadString);
            Balfis = loadSave.balfis_Save;
            Nina = loadSave.nina_Save;
            Elizendre = loadSave.elizendre_Save;
            Laevis = loadSave.laevis_Save;
            //player_posX = loadSave.player_posX_Save;
            //player_posY = loadSave.player_posY_Save;

        }

        public void run()
        {
            Console.CursorVisible = false;
            _map.initMap();
            _map.displayMap();
            _playerSelected = Balfis;
            do
            {
                ConsoleKey key= Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.Q:
                    case ConsoleKey.Z:
                    case ConsoleKey.D:
                    case ConsoleKey.S:
                        _map.movePlayer(key);
                        if(_map.Behind_Player == '#') drawingOfMonster();
                        break;

                    case ConsoleKey.Escape:
                        _menu.run(Balfis, Nina, Elizendre, Laevis);
                        break;

                    case ConsoleKey.J:
                        save();
                        break;

                    //case ConsoleKey.Backspace:
                    //    break;
                    //case ConsoleKey.Tab:
                    //    break;
                    //case ConsoleKey.Clear:
                    //    break;
                    //case ConsoleKey.Enter:
                    //    break;
                    //case ConsoleKey.Pause:
                    //    break;
                    //case ConsoleKey.Spacebar:
                    //    break;
                    //case ConsoleKey.PageUp:
                    //    break;
                    //case ConsoleKey.PageDown:
                    //    break;
                    //case ConsoleKey.End:
                    //    break;
                    //case ConsoleKey.Home:
                    //    break;
                    //case ConsoleKey.Select:
                    //    break;
                    //case ConsoleKey.Print:
                    //    break;
                    //case ConsoleKey.Execute:
                    //    break;
                    //case ConsoleKey.PrintScreen:
                    //    break;
                    //case ConsoleKey.Insert:
                    //    break;
                    //case ConsoleKey.Delete:
                    //    break;
                    //case ConsoleKey.Help:
                    //    break;
                    //case ConsoleKey.D0:
                    //    break;
                    //case ConsoleKey.D1:
                    //    break;
                    //case ConsoleKey.D2:
                    //    break;
                    //case ConsoleKey.D3:
                    //    break;
                    //case ConsoleKey.D4:
                    //    break;
                    //case ConsoleKey.D5:
                    //    break;
                    //case ConsoleKey.D6:
                    //    break;
                    //case ConsoleKey.D7:
                    //    break;
                    //case ConsoleKey.D8:
                    //    break;
                    //case ConsoleKey.D9:
                    //    break;
                    //case ConsoleKey.A:
                    //    break;
                    //case ConsoleKey.B:
                    //    break;
                    //case ConsoleKey.C:
                    //    break;
                    //case ConsoleKey.E:
                    //    break;
                    //case ConsoleKey.F:
                    //    break;
                    //case ConsoleKey.G:
                    //    break;
                    //case ConsoleKey.H:
                    //    break;
                    //case ConsoleKey.I:
                    //    break;

                    //case ConsoleKey.K:
                    //    break;
                    //case ConsoleKey.L:
                    //    break;
                    //case ConsoleKey.M:
                    //    break;
                    //case ConsoleKey.N:
                    //    break;
                    //case ConsoleKey.O:
                    //    break;
                    //case ConsoleKey.P:
                    //    break;
                    //case ConsoleKey.R:
                    //    break;
                    //case ConsoleKey.T:
                    //    break;
                    //case ConsoleKey.U:
                    //    break;
                    //case ConsoleKey.V:
                    //    break;
                    //case ConsoleKey.W:
                    //    break;
                    //case ConsoleKey.X:
                    //    break;
                    //case ConsoleKey.Y:
                    //    break;
                    //case ConsoleKey.LeftWindows:
                    //    break;
                    //case ConsoleKey.RightWindows:
                    //    break;
                    //case ConsoleKey.Applications:
                    //    break;
                    //case ConsoleKey.Sleep:
                    //    break;
                    //case ConsoleKey.NumPad0:
                    //    break;
                    //case ConsoleKey.NumPad1:
                    //    break;
                    //case ConsoleKey.NumPad2:
                    //    break;
                    //case ConsoleKey.NumPad3:
                    //    break;
                    //case ConsoleKey.NumPad4:
                    //    break;
                    //case ConsoleKey.NumPad5:
                    //    break;
                    //case ConsoleKey.NumPad6:
                    //    break;
                    //case ConsoleKey.NumPad7:
                    //    break;
                    //case ConsoleKey.NumPad8:
                    //    break;
                    //case ConsoleKey.NumPad9:
                    //    break;
                    //case ConsoleKey.Multiply:
                    //    break;
                    //case ConsoleKey.Add:
                    //    break;
                    //case ConsoleKey.Separator:
                    //    break;
                    //case ConsoleKey.Subtract:
                    //    break;
                    //case ConsoleKey.Decimal:
                    //    break;
                    //case ConsoleKey.Divide:
                    //    break;
                    //case ConsoleKey.F1:
                    //    break;
                    //case ConsoleKey.F2:
                    //    break;
                    //case ConsoleKey.F3:
                    //    break;
                    //case ConsoleKey.F4:
                    //    break;
                    //case ConsoleKey.F5:
                    //    break;
                    //case ConsoleKey.F6:
                    //    break;
                    //case ConsoleKey.F7:
                    //    break;
                    //case ConsoleKey.F8:
                    //    break;
                    //case ConsoleKey.F9:
                    //    break;
                    //case ConsoleKey.F10:
                    //    break;
                    //case ConsoleKey.F11:
                    //    break;
                    //case ConsoleKey.F12:
                    //    break;
                    //case ConsoleKey.F13:
                    //    break;
                    //case ConsoleKey.F14:
                    //    break;
                    //case ConsoleKey.F15:
                    //    break;
                    //case ConsoleKey.F16:
                    //    break;
                    //case ConsoleKey.F17:
                    //    break;
                    //case ConsoleKey.F18:
                    //    break;
                    //case ConsoleKey.F19:
                    //    break;
                    //case ConsoleKey.F20:
                    //    break;
                    //case ConsoleKey.F21:
                    //    break;
                    //case ConsoleKey.F22:
                    //    break;
                    //case ConsoleKey.F23:
                    //    break;
                    //case ConsoleKey.F24:
                    //    break;
                    //case ConsoleKey.BrowserBack:
                    //    break;
                    //case ConsoleKey.BrowserForward:
                    //    break;
                    //case ConsoleKey.BrowserRefresh:
                    //    break;
                    //case ConsoleKey.BrowserStop:
                    //    break;
                    //case ConsoleKey.BrowserSearch:
                    //    break;
                    //case ConsoleKey.BrowserFavorites:
                    //    break;
                    //case ConsoleKey.BrowserHome:
                    //    break;
                    //case ConsoleKey.VolumeMute:
                    //    break;
                    //case ConsoleKey.VolumeDown:
                    //    break;
                    //case ConsoleKey.VolumeUp:
                    //    break;
                    //case ConsoleKey.MediaNext:
                    //    break;
                    //case ConsoleKey.MediaPrevious:
                    //    break;
                    //case ConsoleKey.MediaStop:
                    //    break;
                    //case ConsoleKey.MediaPlay:
                    //    break;
                    //case ConsoleKey.LaunchMail:
                    //    break;
                    //case ConsoleKey.LaunchMediaSelect:
                    //    break;
                    //case ConsoleKey.LaunchApp1:
                    //    break;
                    //case ConsoleKey.LaunchApp2:
                    //    break;
                    //case ConsoleKey.Oem1:
                    //    break;
                    //case ConsoleKey.OemPlus:
                    //    break;
                    //case ConsoleKey.OemComma:
                    //    break;
                    //case ConsoleKey.OemMinus:
                    //    break;
                    //case ConsoleKey.OemPeriod:
                    //    break;
                    //case ConsoleKey.Oem2:
                    //    break;
                    //case ConsoleKey.Oem3:
                    //    break;
                    //case ConsoleKey.Oem4:
                    //    break;
                    //case ConsoleKey.Oem5:
                    //    break;
                    //case ConsoleKey.Oem6:
                    //    break;
                    //case ConsoleKey.Oem7:
                    //    break;
                    //case ConsoleKey.Oem8:
                    //    break;
                    //case ConsoleKey.Oem102:
                    //    break;
                    //case ConsoleKey.Process:
                    //    break;
                    //case ConsoleKey.Packet:
                    //    break;
                    //case ConsoleKey.Attention:
                    //    break;
                    //case ConsoleKey.CrSel:
                    //    break;
                    //case ConsoleKey.ExSel:
                    //    break;
                    //case ConsoleKey.EraseEndOfFile:
                    //    break;
                    //case ConsoleKey.Play:
                    //    break;
                    //case ConsoleKey.Zoom:
                    //    break;
                    //case ConsoleKey.NoName:
                    //    break;
                    //case ConsoleKey.Pa1:
                    //    break;
                    //case ConsoleKey.OemClear:
                    //    break;
                    default:
                        break;
                }
            } while(_end_Game != true);
        }

        public void drawingOfMonster()
        {
            _stockRandom = random.Next(10);
            if (_stockRandom == 0)
            {
                _stockRandom = random.Next(20);

                if(_stockRandom <= 3)        //Imp
                {
                    Imp enemy= new Imp();
                    _enemySelected = enemy;
                }
                else if(_stockRandom <= 7)   //Goblin
                {
                    Goblin enemy= new Goblin();
                    _enemySelected = enemy;
                }
                else if(_stockRandom == 8)   //Gnolls
                {
                    Gnolls enemy = new Gnolls();
                    _enemySelected = enemy;
                }
                else if(_stockRandom <= 11)  //Orc
                {
                    Orc enemy= new Orc();
                    _enemySelected = enemy;
                }
                else if(_stockRandom <= 14)  //Troll
                {
                    Troll enemy = new Troll();
                    _enemySelected = enemy;
                }
                else if(_stockRandom <= 17)  //Ogre
                {
                    Ogre enemy= new Ogre();
                    _enemySelected = enemy;
                }
                else if(_stockRandom <= 19)  //Draugr
                {
                    Draugr enemy= new Draugr();
                    _enemySelected = enemy;
                }
                do      //FIGHT
                {                    
                    chooseCharacter();
                    _fight.runFight(_playerSelected, _enemySelected);
                    Console.Clear();
                } while (_enemySelected.Alive == true);
                _map.displayMap();
            }
        }

        public void chooseCharacter()
        {
            bool changeFinish = false;
            do
            {                
                Console.Clear();
                Console.WriteLine("1-Balfis");
                Console.WriteLine();
                Console.WriteLine("2-Nina");
                Console.WriteLine();
                Console.WriteLine("3-Elizendre");
                Console.WriteLine();
                Console.WriteLine("4-Laevis");
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.NumPad0:
                        break;

                    case ConsoleKey.NumPad1:
                        if(Balfis.Alive == true) { _playerSelected = Balfis; changeFinish = true; }
                        else { Console.WriteLine("This Character is dead"); }
                        break;

                    case ConsoleKey.NumPad2:
                        if (Nina.Alive == true) { _playerSelected = Nina; changeFinish = true; }
                        else { Console.WriteLine("This Character is dead"); }
                        break;

                    case ConsoleKey.NumPad3:
                        if (Elizendre.Alive == true) { _playerSelected = Elizendre; changeFinish = true; }
                        else { Console.WriteLine("This Character is dead"); }
                        break;

                    case ConsoleKey.NumPad4:
                        if (Laevis.Alive == true) { _playerSelected = Laevis; changeFinish = true; }
                        else { Console.WriteLine("This Character is dead"); }
                        break;

                    case ConsoleKey.NumPad5:
                        break;

                    case ConsoleKey.NumPad6:
                        break;

                    case ConsoleKey.NumPad7:
                        break;

                    case ConsoleKey.NumPad8:
                        break;

                    case ConsoleKey.NumPad9:
                        break;

                    default:
                        break;
                }
            }while(changeFinish != true);

        }

        public void save()
        {
            SerializeTheObject save = new SerializeTheObject(Balfis, Nina, Elizendre, Laevis);

            var options = new JsonSerializerOptions { WriteIndented = true };
            string SaveString = JsonSerializer.Serialize(save, options);
            File.WriteAllText("save.json", SaveString);
        }
        
        //Get
        public Character balfis { get => Balfis; }
        public Character nina { get => Nina; }
        public Character elizendre { get => Elizendre; }
        public Character laevis { get => Laevis; }


        public Character playerSelected { get => _playerSelected; set => _playerSelected = value; }
    }
}
