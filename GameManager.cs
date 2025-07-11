using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    class GameManager
    {
        
        

        public void Start() 
        {
            Console.WriteLine("게임을 시작합니다.");

            // 게임 흐름 작성
        
        }

        // StartGame.cs
        public class Inventory : GameManager
        {
            // 스크립트에 작성 되어 있는 내용을 불러와 적용시켜줄꺼야
            public void Show()
            {
                Inventory inventory = new Inventory();
                Console.WriteLine();
            }
        }

        // State.cs
        public class State : GameManager
        {
                public void Show()
                {
                    State state = new State();
                    Console.WriteLine();
                }

        }

        // Iventory.cs

        public class Inv : GameManager 
        {

                public void Show()
                {
                Inv iventory = new Inv();
                    Console.WriteLine();
                }

        }

        // Iventory.cs

        public class Item : GameManager 
        {

                public void Show()
                {
                    Item item = new Item();
                    Console.WriteLine();
                }



        }

        public class Shop : GameManager 
        {
                public void Show()
                {
                    Shop shop = new Shop();
                    Console.WriteLine();
                }

        }


        public class Trad : GameManager 
        {
                public void Show()
                {
                    Trad trad = new Trad();
                    Console.WriteLine();
                }


        }


    }
    
}
