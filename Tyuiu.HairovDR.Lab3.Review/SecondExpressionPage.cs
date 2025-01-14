using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolveMathFirstExpression;
using SolveMathSecondExpression.Lib;

namespace Tyuiu.HairovDR.Lab3.Review
{
    internal class SecondExpressionPage : IPage
    {
        public SecondExpressionPage()
        {
            Render();
            Console.CursorVisible = false;

        }
        public void DownButtonPressed()
        {

        }
        public void UpButtonPressed()
        {

        }

        public IPage EscButtonPressed()
        {
            return new MenuPage();
        }

        public void NumberPressed(int value)
        {

        }


        public void Render()
        {
            Console.Clear();
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            RenderHead();
            RenderBody();
            RenderBot();

        }
        private void RenderHead()
        {
            Console.WriteLine("РАССЧИТАТЬ ВТОРОЕ МАТЕМАТИЧЕСКОЕ ВЫРАЖЕНИЕ");
            for (int i = 0; i < 120; i++)
            {
                Console.Write("═");
            }
        }
        private void RenderBody()
        {
            Console.WriteLine("Выполняется функция расчета 2 математического выражения...");
            Console.WriteLine("6x + ((2x + y - 3) / (a + 2x - 7y)) + (((x+3) / y) / ((2 - x) / x))");
            Console.WriteLine("");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Для ввода данных нажмите Enter");
            Console.ResetColor();
            Console.WriteLine("Первый аргумент(x): ");
            Console.WriteLine("Второй аргумент(y): ");
            Console.WriteLine("Третий аргумент(a): ");
            Console.WriteLine("Значение функции равно: ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }
        private void RenderBot()
        {
            for (int i = 0; i < 120; i++)
            {
                Console.Write("═");
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню");
            Console.ResetColor();
        }

        public IPage EnterButtonPressed()
        {
            //я запутался
            Console.CursorVisible = true;
            Console.CursorLeft = 20;
            Console.CursorTop = 6;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 20;
            Console.CursorTop = 7;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 20;
            Console.CursorTop = 8;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 24;
            Console.CursorTop = 9;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 20;
            Console.CursorTop = 6;
            if (!float.TryParse(Console.ReadLine(), out float x))
            {
                EnterButtonPressed();
                return this;
            }
            Console.CursorLeft = 20;
            Console.CursorTop = 7;
            if (!float.TryParse(Console.ReadLine(), out float y))
            {
                EnterButtonPressed();
                return this;
            }
            
            //проверь позже

            Console.CursorLeft = 20;
            Console.CursorTop = 8;
            if (!float.TryParse(Console.ReadLine(), out float a))
            {
                EnterButtonPressed();
                return this;
            }
            Console.CursorLeft = 24;
            Console.CursorTop = 9;
            Console.Write(MathSecondExpression.CalculateSecondExpression(a, x, y));
            Console.CursorVisible = false;
            return this;
        }

        public IPage F1ButtonPressed()
        {
            return this;
        }
    }
}
