namespace TaskOneSaber {
    class Programm
    {
        static void Main()
        {
            // в тз написано "знаковое целое число" - не очень понятно, решил что будет int. 
            int number = Int32.Parse(Console.ReadLine());

            string binaryNumber = TransformToBinary(number);

            Console.WriteLine(binaryNumber);
        }

        public static string TransformToBinary(int number)
        {
            Stack<int> binaryStack = new Stack<int>();
            bool isPositive = true;

            if(number == 0) return "0";

            if(number < 0) 
            {
                isPositive = false;
                // бинарное отрицательное число = граница int + (- наше число)
                number = int.MaxValue + number + 1;
            }

            while(number > 1)
            {
                // в коллекцию записываем остаток от деления на 2
                binaryStack.Push(number % 2);
                number /= 2;
            }
            binaryStack.Push(number);

            if(!isPositive) {
                // если отрицательное, то в самый левый разряд записывается 1
                binaryStack.Push(1);
            }

            return string.Join("",binaryStack);
        }
    }
}