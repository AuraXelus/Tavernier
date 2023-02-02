using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace Tavernier
{
    internal class SerializeTheObject
    {
        public Balfis_Character balfis_Save { get; set; }
        public Nina_Character nina_Save { get; set; }
        public Elizendre_Character elizendre_Save { get; set; }
        public Laevis_Character laevis_Save { get; set; }
        public int player_posX_Save { get; set; }
        public int player_posY_Save { get; set; }


        public SerializeTheObject(Balfis_Character balfis, Nina_Character nina, Elizendre_Character elizendre, Laevis_Character laevis/*, int player_posX, int player_posY*/) 
        {
            balfis_Save = balfis;
            nina_Save = nina;
            elizendre_Save = elizendre;
            laevis_Save = laevis;
            //player_posX_Save = player_posX;
            //player_posY_Save= player_posY;
        }
    }
}
