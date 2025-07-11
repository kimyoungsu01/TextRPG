using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    public class Status
    {
        public void Stx() 
        {

            Console.WriteLine("캐릭터의 정보를 표시합니다");
            Console.WriteLine("\n 7개의 속성을 가지고 있습니다");

            List<String> Status = new List<String>();

            Status.Add("Lv.01");
            Status.Add("이름");
            Status.Add("공격력" + ":" + "10");
            Status.Add("공격력");
            Status.Add("방어력");
            Status.Add("체력");
            Status.Add("Gold");

            Console.WriteLine("\n 0.나가기");

            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");

            string List = Console.ReadLine();

            switch (List)
            {
                case "0":
                    Console.WriteLine("\n 0.나가기");
                    break;

                default:
                    Console.WriteLine("\n 잘못된 입력입니다.");
                    break;

                    Console.WriteLine();
            }


        }
    }
}
