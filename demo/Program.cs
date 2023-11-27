// See https://aka.ms/new-console-template for more information
using System;
using jicheng;
using RandomNumberGenerator;
namespace ProgramApplication{
    class Program{
        static void Main(string[] args){
            MyClass my = new MyClass();
            my.ConsoleArea();
            
            childer child = new childer();
            child.setWidth(10);
            child.setHeight(3);
            Console.WriteLine(child.GetArea());

            Test test = new Test();
            test.printHello();

            RandomNumber randomNumber = new RandomNumber();
            randomNumber.RandomNumberTest();
            
        }
    }
    class MyClass{
        double length;
        double Width;
        public void AccepthDetails(){
            length = 4.5;
            Width = 2.1;
        }
        public double GetArea(){
            return length * Width;
        }
        public void ConsoleArea(){
            AccepthDetails();
            Console.WriteLine("Length: {0}",length);
            Console.WriteLine("Width: {0}",Width);
            Console.WriteLine("The Area: {0}",(float)GetArea());
        }
    }
}
