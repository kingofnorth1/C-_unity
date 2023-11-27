using System;
namespace RandomNumberGenerator{

    class RandomNumber{
        public void RandomNumberTest(){
            Random random = new Random();
            int number = random.Next(1,100);
            Console.WriteLine("请输入所猜的值：");
            int guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("你猜的数字是：" + guess);
            while (guess != number){
                if (guess < number){
                    Console.WriteLine("猜小了，继续猜");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("你猜的数字是：" + guess);

                }else if (guess > number){
                    Console.WriteLine("猜大了，继续猜");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("你猜的数字是：" + guess);
                }
            }
            Console.WriteLine("恭喜回答正确,答案就是{0}", number);
        }
    }
}