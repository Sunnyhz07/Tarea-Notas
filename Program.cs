namespace TareaNotas

{
    class Program
    {
        static void Main(string[] args)
        {

            double c1, c2, c3, c4, c5, SN, NM;


            Console.WriteLine("Vamos a ver si hemos aprobado el curso :)");

            Console.WriteLine("Nota de matemáticas");
            c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota de Euskera");
            c2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota de Programacion");
            c3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota de ingles");
            c4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota de algebra");
            c5 = Convert.ToDouble(Console.ReadLine());

            SN = c1 + c2 + c3 + c4 + c5;
            Console.WriteLine("Suma de las notas:");
            Console.WriteLine(SN);
         
            NM = SN / 5;
            Console.WriteLine("Nota media del curso:");
            Console.WriteLine(NM);

            //Se sabe que para poder pasar el curso debe tener una media de 6

            int x = 6;
            bool aprobado = NM >= 6; 
            
            aprobado = NM >= 6;
            Console.WriteLine("No ha aprobado el curso");
            Console.WriteLine(aprobado);
            



        }

    }
}