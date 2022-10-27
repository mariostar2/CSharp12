using System;

namespace CSharp12
{
    class Program
    {
        static void Main(string[] args)
        {
            SignIn signIn = new SignIn();
            
            //입력문(input)
            //ConsoleKeyInfo input = Console.ReadKey();

            /* int num1 = 10;
             int num2 = 10;*/
            /*
            //bool 변수는 이름 앞에 is를 붙인다 
            bool isEquals = num1 == num2;
            Console.WriteLine($"num1 <= num2 { num1 == num2}");     //같다
            Console.WriteLine($"num1 != num2 { num1 != num2}");     //다르다
            Console.WriteLine($"num1 <= num2 { num1 < num2}");      //작다(미만)
            Console.WriteLine($"num1 <= num2 { num1 <= num2}");     //작거나 같다(이하)
            Console.WriteLine($"num1 > num2 { num1 > num2}");       //크다(초과)
            Console.WriteLine($"num1 >= num2 { num1 >= num2}");     //크거나 같다(이상)*/

            //입력문(Input)
            // ConsoleKeyInfo input = Console.ReadKey(true);
            // Console.WriteLine($"ket{input.Key}, keyChar{input.KeyChar},modifiers{input.Modifiers}");

            //char 1byte
            //short 2byte
            //int 4byte
            //long 8yte
           
           

            //회원가입.
            Console.WriteLine("아이디:");
            Console.WriteLine("비밀번호:");
            Console.CursorTop = 0;
            Console.CursorLeft = 7;
            Console.ReadLine();
            string id = Console.ReadLine();           
            
            string pw = string.Empty;
            bool isEndInput = false;
            Console.CursorTop = 1;
            Console.CursorLeft = 9;

            while (true)
            {
                //입력
                //처리
                //출력
                Console.CursorTop = 0;
                Console.CursorLeft = 0;
                Console.WriteLine($"아이디{id}");
                
                string hide = string.Empty;
                for (int i = 0; i < pw.Length; i++)
                    hide += '*';
                Console.WriteLine($"비밀번호{hide}");
                
            }


            // !(조건식) =  not연산자 . 식의 결과를 반대로 돌린다.  
            while(!isEndInput)
            {
                ConsoleKeyInfo input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.Enter:
                        if (pw.Length < 4 || pw.Length > 12)
                        {
                            DrawText(0, 2, "비밀번호는 4~12글자입니다");
                        }
                        else
                        {
                            isEndInput = true;
                        }
                        //A and B
                        //A OR B
                        isEndInput = true;
                        break;

                    case ConsoleKey.Backspace:
                        //입력된 PW의 길이가 0보다 많을 경우 지울 수 있다.
                        if (pw.Length > 0)
                        {
                            //기존에 있던 별을 지운다
                            DrawChar(9, 1, ' ', pw.Length);
                            pw = pw.Substring(0, pw.Length - 1);        //마지막 문자를 제외하고 짜른다.
                            DrawChar(9, 1, '*', pw.Length);
                        }
                         break;
                    
                    default:
                        if(pw.Length < 12)
                        {
                            pw += input.KeyChar;
                            Console.Write("*");
                            ClearLine(2);
                        }
                        break;
                }                
            }
        }
        //특정 위치에 특정문자를 N개 그려주는 함수.
        static void DrawChar(int left, int top, char c ,int count)
        {
            Console.CursorLeft = left;
            Console.CursorTop = top;
            for (int i = 0; i < count; i++)
                Console.Write(c);
        }

        static void DrawText(int left, int top, string str)
        {
            //이전 커서 위치 저장
            int beforeLeft = Console.CursorLeft;
            int beforeTop = Console.CursorTop;
            
            //요청한 커서 위치로 이동
            Console.CursorLeft = left;
            Console.CursorTop = top;

            //텍스트 출력
            Console.Write(str);

            //이전 위치로 복귀
            Console.CursorLeft = beforeLeft;
            Console.CursorTop = beforeTop;
        }
        
        static void ClearLine (int top )
        {
            string blank = string.Empty;
            for (int i = 0; i < Console.BufferWidth; i++)
                blank += ' ';
            DrawText(0, top, blank);
        }
        //비밀번호 입력 자리수 제한
      

      
    }
    
}
