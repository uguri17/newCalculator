// 필드
// 생성자
// 메서드
// 종료자
// 객체 생성 및 호출

// 실제로 사용 구현해보기
// 날코딩 보다는 전체적인 흐름이 중요

using System;

namespace newCalculator
{
    class Calculator
    {
        // 필드 선언
        double num1, num2, result;

        // 생성자 정의
        public Calculator(double a, double b)
        {
            num1 = a;
            num2 = b;
        }

        // 소멸자 정의
        ~Calculator()
        {
            Console.WriteLine("소멸자");
        }

        // 메서드 정의
        public void Plus()
        {
            result = num1 + num2;
            Console.WriteLine($"+: {result}\n");
        }

        public void Minus()
        {
            result = num1 - num2;
            Console.WriteLine($"-: {result}\n");
        }

        public void Multiply()
        {
            result = num1 * num2;
            Console.WriteLine($"×: {result}\n");
        }

        public void Divide()
        {
            result = num1 / num2;
            Console.WriteLine($"÷: {result}\n");
        }             
    }

    // 피연산자들의 사칙연산 값을 보고 싶은 user 

    class MainApp
    {
        // 객체 생성 없이 Main메서드 호출 가능하게 하는 "static"
        static void Main(string[] args)
        {
            // 객체 생성
            Calculator calculator = new Calculator(4, 4);

            // 메서드 호출
            calculator.Plus();
            calculator.Minus();
            calculator.Multiply();
            calculator.Divide();
        }        
    }
}
