using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavernier
{
    public class Laevis_Character : Character
    {
        public Laevis_Character() 
        {
            Name = "Laevis";
            _Elem_Type = "Nature";
            _Lvl = 1;
            _Exp = 0;

            _Max_HP = 100;
            _HP = _Max_HP;
            _Max_SP = 100;
            _SP = _Max_SP;

            _Phys_Atk = 15;
            _Elem_Atk = 50;

            _Phys_Def = 5;
            _Elem_Def = 25;

            _Accuracy = 85;
            _Critical_Chance = 3;
            _Critical_Puiss = 2;

            _Speed = 80;
                                                                                       
            _Sprite = "\t\t\t\t                                                                _ .-'\r\n\t\t\t\t                                                                _`\\`\r\n\t\t\t\t                                                            `._/` ;_.  \\,\r\n\t\t\t\t                                                               `. /  _ /`\r\n\t\t\t\t                                                                 ;_ _,;\r\n\t\t\t\t                                                               _/ , , /_,\r\n\t\t\t\t                                                               `\"\\ _  |'\r\n\t\t\t\t                                                               _=}  ` ;/\r\n\t\t\t\t                                                              .'    `. `-._\r\n\t\t\t\t                                                           ,_/ ,| '    {  `.\r\n\t\t\t\t                                                            ] ',/  ; , ;\\ , \\_\r\n\t\t\t\t                                                            `._L`\\  `  \\ `.` :`";

            _Name_First_Weapon = "Wooden stick";
            _First_Weapon.choseWeapon(_Name_First_Weapon);

            _First_Skill.setSkill("Laevis", 1);
            _Second_Skill.setSkill("Laevis", 2);
        }
    }
}
