using System;

namespace Cs_2
{
    class Program
    {
        class Example{                         //6차
            public static void StaticMethod(){            //public 선언해주어야 접근가능
                Console.WriteLine("StaticMethod");
            }
            public void InstanceMethod(){                // static으로 메모리를 할당시키지 않았을 경우 new.Example로 메모리 할당을 시켜야함
                Console.WriteLine("InstanceMethod");
            }
        }



        // struct BusinissCard{   //4차 main 안에 있으면 실행오류 
        //     public string name;
        //     public string tel;
        //     public int id;
        // }


        static void Main(string[] args)
        {

        //2차 실습 두 수의 합을 구하는 함수를 만들라
        // int num1,num2,re1,re2;
        // Console.Write("1번 숫자 입력 : ");
        // num1 = int.Parse(Console.ReadLine());
        // Console.Write("2번 숫자 입력 : ");
        // num2 = int.Parse(Console.ReadLine());

        // re1 = _sum(num1,num2);
        // Console.WriteLine("합은 : {0}",re1);

        // int _sum(int a, int b){    // 합
        //     return a+b;
        // }


        // int _big(int a, int b){     //큰 수
        //     if (a>b){return a;}
        //     else if (b>a){return b;}
        //     else{ 
        //         Console.WriteLine("error, 값이 동일함");
        //         return 0;
        //     } 
        // }
        
        // int _small(int a, int b){  //작은수
        //     if (a>b){return b;}
        //     else if (b>a){return a;}
        //     else{ 
        //         Console.WriteLine("error, 값이 동일함");
        //         return 0;
        //     } 
        // }

        // int _abs(int a){    //절대 값
        //     if(a<0){
        //         a = a * (-1);
        //     }
        //     return a;
        // }
       
        // re1 = _big(num1,num2);  
        // if (re1 != 0){Console.WriteLine("큰 수 : {0}",re1);}   //error 처리
        // re1 = _small(num1,num2);
        // if (re1 != 0){Console.WriteLine("작은 수 : {0}",re1);}
        // re2 = _abs(num1);
        // Console.WriteLine("1번 절대값 : {0}",re2);
        // re2 = _abs(num2);
        // Console.WriteLine("2번 절대값 : {0}",re2);

        //3차 args -> 터미널에서 console형식으로 입력가능함. 
        //사용법 dotnet run args[0] args[1] ... args[n] /space bar를 기준으로 요소를 받아옴

        // int one = int.Parse(args[0]);        //int.parse -> null을 사용하면 error
        // int two = Convert.ToInt32(args[1]);  //convert.toint32 -> null 입력시 0으로 반환

        // sum(one,two);

        // void sum(int fst, int sec){
        //     Console.WriteLine(fst+sec);
        // }

        //4차 상단 static BusinissCard 참조
        
        // BusinissCard bc;         //nicname 만들어주기

        // bc.name = "Lee dong jun";  // class형식과 동일 클래스.메소드 대입
        // bc.tel = "000-0000-0000";
        // bc.id = 100;

        // string str = $"이름 : {bc.name} \n전화번호 {bc.tel} \n아이디 {bc.id}"; 
        // Console.WriteLine(str);

        //5차 is,to -> upper,lower 등 사용해보기
        // char a = 'A';
        // char b = 'a';
        // if (char.IsUpper(a)){
        //     Console.WriteLine("{0}은 대문자입니다.",a);
        // }
        // if (char.IsLower(b)){
        //     Console.WriteLine("{0}은 소문자입니다.",b);
        // } 
        // a = char.ToLower(a);          //a를 재할당 시켜야함
        // Console.WriteLine(a); 

        //6차 상단 class Example 참조

        Example.StaticMethod();            //staticmethod는 정적으로 메모리를 할당받은상태라 실행가능
        Example ins = new Example();       //'1'
        ins.InstanceMethod();              //instance의 경우 void로 메모리할당이 되지 않았기에 '1'번과 같이 new로 메모리를 할당시켜줘야함

        // Example.InstanceMethod();          //'0' 메모리를 할당받지 못해 오류 출력


        }
    }
}
