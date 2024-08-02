using System.Diagnostics;
using System.Xml.Linq;

namespace Test5
{
    internal class Program
    {
        public class Player
        {
            public int atk;
            public int def;
            public int hp;
        }
        public class Shop()
        {

            public void Buy(int gold, string item1, string item2, string item3,Dictionary<string, Item> item)
            {
                Console.Clear();
                Console.WriteLine($"보유한 골드 : {gold}");
                Console.WriteLine();
                Console.WriteLine($"1. {item[item1].Name}");
                Console.WriteLine($"가격 : {item[item1].Price}");
                Console.WriteLine($"설명 : {item[item1].Explain}");
                Console.WriteLine($"효과 : {item[item1].Effect}");
                Console.WriteLine();
                Console.WriteLine($"2. {item[item2].Name}");
                Console.WriteLine($"가격 : {item[item2].Price}");
                Console.WriteLine($"설명 : {item[item2].Explain}");
                Console.WriteLine($"효과 : {item[item2].Effect}");
                Console.WriteLine();
                Console.WriteLine($"3. {item[item3].Name}");
                Console.WriteLine($"가격 : {item[item3].Price}");
                Console.WriteLine($"설명 : {item[item3].Explain}");
                Console.WriteLine($"효과 : {item[item3].Effect}");
                Console.WriteLine();
                Console.Write("구매할 아이템을 선택하세요 : ");
                int choice = int.Parse( Console.ReadLine() );
                if( choice == 1)
                {
                    if (gold > item[item1].Price)
                    {
                        Console.WriteLine($"{item[item1].Name}을 구매합니다.");
                        Console.WriteLine($"보유한 골드가 {item[item1].Price}G 감소하여 {gold - item[item1].Price}G가 됩니다.");
                    }
                    else { Console.WriteLine("골드가 부족합니다."); }
                }
                else if (choice == 2 && gold > item[item2].Price)
                {
                    if (gold > item[item2].Price)
                    {
                        Console.WriteLine($"{item[item2].Name}을 구매합니다.");
                        Console.WriteLine($"보유한 골드가 {item[item2].Price}G 감소하여 {gold - item[item2].Price}G가 됩니다.");
                    }
                    else { Console.WriteLine("골드가 부족합니다."); }
                }
                else if (choice == 3 && gold > item[item3].Price)
                {
                    if (gold > item[item3].Price)
                    {
                        Console.WriteLine($"{item[item3].Name}을 구매합니다.");
                        Console.WriteLine($"보유한 골드가 {item[item3].Price}G 감소하여 {gold - item[item3].Price}G가 됩니다.");
                    }
                    else { Console.WriteLine("골드가 부족합니다."); }
                } 
                else 
                { Console.WriteLine("잘못된 값을 입력하였습니다."); }
            }
            public void Sell()
            {

            }
            public void Check()
            {

            }
        }

        public class Item
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public string Explain { get; set; }
            public string Effect { get; set; }

            public Item(string name, int price, string explain, string effect)
            {
                Name = name;
                Price = price;
                Explain = explain;
                Effect = effect;
            }
            public virtual void ItemEffect(Player player) 
            { 
                 
            }
        }
        public class Sword : Item
        {
            public Sword(string name, int price, string explain, string effect) : base( name, price, explain, effect) { }

            public override void ItemEffect(Player player)
            {
                player.atk += 15;
            }
        }

        public class Armor : Item
        {
            public Armor(string name, int price, string explain, string effect) : base(name, price, explain, effect) {}
        }

        public class Candy : Item
        {
            public Candy(string name, int price, string explain, string effect) : base(name, price, explain, effect) { }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Item> item = new Dictionary<string, Item>();
            Player player = new Player();
            Shop shop = new Shop();
            Sword sword = new Sword("롱소드", 400, "기본적인 검이다", "(소유) 공격력 상승 15");
            Armor armor = new Armor("천갑옷", 500, "얇은 갑옷이다", "(소유) 방어력 상승 15");
            Candy candy = new Candy("이상한사탕", 800, "먹으면 신비한 효과를 일으킬 것 같다", "(사용) 체력 영구상승 300");

            item.Add("롱소드", new Item(sword.Name, sword.Price, sword.Explain, sword.Effect));
            item.Add("천갑옷", new Item(armor.Name, armor.Price, armor.Explain, armor.Effect));
            item.Add("이상한사탕", new Item(candy.Name, candy.Price, candy.Explain, candy.Effect));

            int input; // 입력값

            int gold = 3000;
            Console.WriteLine("*******************");
            Console.WriteLine("    아이템 상점");
            Console.WriteLine("*******************");
            Console.WriteLine();
            Console.WriteLine("=====상점 메뉴======");
            Console.WriteLine("아이템 구매");
            Console.WriteLine("아이템 판매");
            Console.WriteLine("아이템 확인");
            Console.WriteLine();
            Console.Write("메뉴를 선택하세요");
            input = int.Parse(Console.ReadLine());

            if (input == 1) 
            { shop.Buy(gold, "롱소드", "천갑옷", "이상한사탕", item); } 
            else if (input == 2) 
            { } 
            else if(input == 3) 
            { } 
            else 
            {
                Console.WriteLine("잘못된 값");
            }
        }
    }
}
