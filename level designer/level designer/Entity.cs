using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_designer
{
    class Entity
    {
        public int hp;
        public int ap;
        public string name;


        public void dealdamage(int damage, Entity entity)
        {
            entity.hp = entity.hp - damage;
        }
        public void showstats()
        {try { Console.WriteLine(name  + "  hp: " + hp);}catch (Exception) { }}





       

    }





    class Hero : Entity
    {

        
        

    }
    class Guard : Entity
    {
        





    }










}
