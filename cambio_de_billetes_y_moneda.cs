
int dolar, Can, can200, can100, can50, can20, can10, can5, mon, cmon1, cmon10, cmon25, cmon50;
can200 = 0;
can100 = 0;
can50 = 0;
can20 = 0;
can10 = 0;
can5 = 0;
mon = 0;
cmon1 = 0;
cmon10 = 0;
cmon25 = 0;
cmon50 = 0;
dolar = 7;
string Lin;


     Console.WriteLine("Introduzca la cantidad en $:");
            Lin = Console.ReadLine();
            Can = Convert.ToInt32(Lin);

        Can = (Can * dolar);
        Console.WriteLine($"Esto seria en Quetzales Q:" + Can);



       
        //Billetes
        if ((Can >= 200))
        {
            can200 = (can200 / 200);
            Can = Can - (can200 * 200);
        }


        if ((Can >= 100))
        {
            can100 = (Can / 100);
            Can = Can - (can100 * 100);
        }

        if ((Can >= 50))
        {
            can50 = (Can / 50);
            Can = Can - (can50 * 50);
        }

        if ((Can >= 20))
        {
            can20 = (Can / 20);
            Can = Can - (can20 * 20);
        }

        if ((Can >= 10))
        {
            can10 = (Can / 10);
            Can = Can - (can10 * 10);
        }

        if ((Can >= 5))
        {
            can5 = (Can / 5);
            Can = Can - (can5 * 5);
        }

      //Moneda
      Console.WriteLine("Y tus monedas son");
      

if ((Can >= 0.01))
        {
            cmon1 = ((int)(Can / 0.01));
            Can = Can - ((int)(cmon1 * 0.01));
        }

        if ((Can >= 0.050))
        {
            cmon50 = ((int)(Can / 0.50));
            Can = Can - ((int)(cmon50 * 0.50));
        }

        if ((Can >= 0.10))
        {
            cmon10 = ((int)(Can / 0.10));
            Can = Can - ((int)(cmon10 * 0.10));
        }

        if ((Can >= 0.25)) ;
       {
         cmon25 = ((int)(Can / 0.25));
         Can = Can - ((int)(cmon10 * 0.25));
        }

Console.WriteLine("Seria un billete de Q200:" + can200);
Console.WriteLine("Seria un billete de Q100:" + can100);
Console.WriteLine("Seria un billete de Q50:" + can50);
Console.WriteLine("Seria un billete de Q20:" + can20);
Console.WriteLine("Seria un billete de Q10:" + can10);
Console.WriteLine("Seria un billete de Q5:" + can5);
Console.WriteLine("Seria una moneda de Q1:" + cmon1);
Console.WriteLine("Seria un billete de c50:" + cmon50);
Console.WriteLine("Seria un billete de c10:" + cmon10);
Console.WriteLine("Seria un billete de c25:" + cmon25);

