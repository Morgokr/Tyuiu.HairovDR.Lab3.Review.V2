using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolveTabMathFuction;
using SolveTabMathFuction.Lib;

namespace Tyuiu.HairovDR.Lab3.Review
{
    internal class TabMathFunctionPage : IPage
    {
        public TabMathFunctionPage()
        {
            Render();
            Console.CursorVisible = false;
        }
        public void DownButtonPressed()
        {

        }

        public IPage EnterButtonPressed()
        {
            Console.CursorVisible = true;
            Console.CursorLeft = 17;
            Console.CursorTop = 6;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 17;
            Console.CursorTop = 7;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 17;
            Console.CursorTop = 8;
            Console.Write("                                                                                                    ");
            Console.CursorLeft = 17;
            Console.CursorTop = 6;
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                EnterButtonPressed();
                return this;
            }
            Console.CursorLeft = 17;
            Console.CursorTop = 7;
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                EnterButtonPressed();
                return this;
            }
            Console.CursorLeft = 17;
            Console.CursorTop = 8;
            if (!int.TryParse(Console.ReadLine(), out int y))
            {
                EnterButtonPressed();
                return this;
            }

            var res = TabMathFuction.CalculateTabMathFuction(a, b, y);
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                          *");
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine("+-------+--------+                                                               ");
            Console.WriteLine("|   X   |  f(x)  |                                                               ");
            Console.WriteLine("+-------+--------+                                                               ");
            int range = Math.Abs(a - b) + 1;
            for (int i = 0; i < range; i++)
            {
                Console.WriteLine(
                //$"|   {i+a}    |  {res[i]}  |"
                format: $"| {i + a}\t|{res[i]}\t |");
            }
            Console.WriteLine("+-------+--------+");
            Console.CursorVisible = false;
            return this;
        }

        public IPage EscButtonPressed()
        {
            return new MenuPage();
        }

        public void NumberPressed(int value)
        {

        }

        public void UpButtonPressed()
        {

        }
        private void Render()
        {
            Console.Clear();
            RenderHead();
            RenderBody();
            RenderBot();
        }
        private void RenderHead()
        {
            Console.WriteLine("РАССЧИТАТЬ ТАБУЛЯЦИЮ");
            for (int i = 0; i < 120; i++)
            {
                Console.Write("═");
            }
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

        private void RenderBody()
        {
            Console.WriteLine("Выполняется функция табулирования математического выражения...");
            Console.WriteLine("(");
            Console.WriteLine("");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Для ввода данных нажмите Enter");
            Console.ResetColor();
            Console.WriteLine("Старт шага: ");
            Console.WriteLine("Конец шага: ");
            Console.WriteLine("Аргумент y: ");
            for (int i = 0; i < 18; i++)
            {
                Console.WriteLine("");
            }
        }

        public IPage F1ButtonPressed()
        {
            return this;
        }
    }
}
