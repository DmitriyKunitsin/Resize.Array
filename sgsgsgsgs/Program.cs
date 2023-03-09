using System.Drawing;

namespace sgsgsgsgs
{
    internal class Program
    {
        
        //static ref int ArrayCount( int[] array, int size)
        //{
            
        //    Array.Resize(ref array, array.Length);
        //}
        
        


        static void Main(string[] args)
        {
            string sizeArray = null;
            Random rand= new Random();
            int[] array = new int[rand.Next(3, 15)];
            for (int elem=0; elem < array.Length; elem++) 
            {
                array[elem] = rand.Next(1,200);
            }
            Console.WriteLine($"Массив состоит из  {array.Length} элементов \nСколько желаете отобразить?");
            int size = int.Parse(Console.ReadLine());
            sizeArray = size > array.Length ? "Вы ввели большее колличество элементов, но не беда, создадим новые" : "Вы ввели меньше, не беда обрежем массив";
            Console.WriteLine(sizeArray);
            Array.Resize(ref array, size);
            ref int[] b = ref array;
            int index = -1;
            foreach (int cyfra in b)
            {
                index++;
                if (cyfra == 0)
                {
                    for (int elem = 0; elem < array.Length; elem++)
                    {
                        array[elem] = rand.Next(1, 200);
                    }
                }
                else
                {
                    
                    Console.WriteLine($"Значение элемента индекса номер : {index} равен "+cyfra);
                }
            }
            

        }
    }
}