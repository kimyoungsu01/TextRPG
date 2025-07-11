using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class Inv
    {
        public void Inventory()
        {

            Inventory inventory = new Inventory();

        }
        public void ShowMenu()
        {
            Console.WriteLine("인벤토리");
            Console.WriteLine("\n 보유 중인 아이템을 관리할 수 있습니다 \n");

            List<String> list = new List<String>();

            list.Add("0. 나가기");
            list.Add("1. 장착 관리");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n 원하시는 행동을 입력해주세요.");
            Console.Write(">>");

            string input = Console.ReadLine();


            switch (input)
            {

                case "0":
                    Console.WriteLine("\n 나가기를 선택하셨습니다.");
                    break;

                case "1":
                    Console.WriteLine("\n 장착 관리를 선택하셨습니다.");
                    break;


                default:
                    Console.WriteLine("\n 잘못된 입력입니다.");
                    break;

                    if (input == "1")
                    {

                        Console.WriteLine("1.장착 관리");
                        Console.WriteLine("2.나가기");

                        Console.WriteLine("\n [아이템 목록]");

                        List<String> itemList = new List<String>();

                        list.Add("무쇠갑옷" + "방어력[5]" + "무쇠로 만들어져 튼튼한 갑옷입니다");
                        list.Add("스파르타의 창" + "공격력[7]" + "스파르타의 전사들이 사용했다는 전설의 창입니다");
                        list.Add("낡은 검" + "공격력[2]" + "쉽게 볼 수 있는 낡은 검 입니다");

                        foreach (string s in list)
                        {
                            Console.WriteLine(s);
                        }

                        Console.WriteLine("\n 원하시는 행동을 입력해주세요.");
                        Console.Write(">>");

                        string select = Console.ReadLine();

                        switch (select)
                        {
                            case "0":
                                Console.WriteLine("\n 장착 관리를 선택하셨습니다.");
                                break;

                            case "1":
                                Console.WriteLine("\n 나가기를 선택하셨습니다.");
                                break;



                            default:
                                Console.WriteLine("\n 잘못된 입력입니다.");
                                break;

                        }

                    }

            }
        }
    }
}
