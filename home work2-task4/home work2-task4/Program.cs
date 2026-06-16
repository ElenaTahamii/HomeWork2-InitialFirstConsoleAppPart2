


class Program
{
 
    public static void Main()
    {
          int count;//مقدار تعداد  خانه های ارایه
    Console.WriteLine(" How many numbers do you want to enter?  ");
      
        count = Convert.ToInt32(Console.ReadLine()); //تعداد خانه ها را به عدد تبدیل کند.
        if (count == 0)
        {
            Console.WriteLine(" max is 0 and  ave is 0 ");
            return;//از برنامه خارج بشه.
        }
        double[] numberArray = new double[count];
       Console.WriteLine($" enter Your Number.");
        AnalyzeArray array1 = new AnalyzeArray();

        for (int i = 0; i < count; i++)
        {
          numberArray[i] = Convert.ToDouble(Console.ReadLine());


        }
        double max = 0;
        double ave;
        array1.AnalyzerArray(numberArray, ref max, out ave);
        Console.WriteLine($"max is {max} ;average is {ave}");
    }
   
    class AnalyzeArray
    {

       // public double max ;
     //   public double ave;
       public double sum = 0;
        public void AnalyzerArray(double[] array, ref double max, out double ave)
        {
            sum = 0;
            max = array[0];  
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

                if (array[i] > max)
                {

                    max=array[i];

                }
                   
               
            }
            ave=sum/array.Length;
           
        }
    }
}