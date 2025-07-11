using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_RPG;




namespace StartGame
{

    public class Inventory
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");

            List<String> list = new List<String>();

            list.Add("1.상태보기");
            list.Add("2.인벤토리");
            list.Add("3.상점 \n");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");

            string input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    Console.WriteLine("\n 상태보기를 선택하셨습니다.");

                    // Status관련 자료를 넣을꺼니까 메서드 호출해줘
                    Status status = new Status();
                    // Status안에 있는 변수를 호출 할꺼야
                    Status.Add();

                    break;
                case "2":
                    Console.WriteLine("\n 인벤토리를 선택하셨습니다.");
                    break;
                case "3":
                    Console.WriteLine("\n 상점을 선택하셨습니다.");
                    break;

                default:
                    Console.WriteLine("\n 잘못된 입력입니다.");
                    break;

            }
        }



    }


}