
﻿Console.WriteLine("Welcome to Geometryguru project!");
Console.WriteLine("Siz bu loyihada harxil geometrik shakllarning xisoblashingiz mumkin.");
Console.WriteLine("Menuda");
Console.WriteLine("1.Doiraning diametrini aniqlash.");
Console.WriteLine("2.kvadratni uzini hisoblash.");
Console.WriteLine("3.Tug`ri to`rtburchakning perimetrini hisoblash");
Console.WriteLine("O`zingizga qiziq bo`lgan geometrik amalni tanlang.");

    int userTanlov = Convert.ToInt32(Console.ReadLine());
    
    switch (userTanlov)
    {
        case 1:
            {
                Console.WriteLine("Siz bilan doirani diametrini aniqlaymiz!!!");
                doiraDiametr();
            }
        break;
        case 2:
            {
                Console.WriteLine("Siz bilan kvadrat yuzini hisoblaymiz!!!");
                kvadratYuzi();
            }
         break;
        case 3:
            {
                Console.WriteLine("To`g`ri to`rtburchakning perimetrini hisoblaymiz!!!");
                tugriTurtburchakPerimetri();
            }
        break;
    }
static void doiraDiametr()
{
    Console.WriteLine("User radiusni kiriting:");
    Console.Write("Radius =");
    decimal value = Convert.ToDecimal(Console.ReadLine()); // user ixtiyoriy qiymat kiritishi
    decimal diametr = 2 * value;                           // kiritilgan qiymat diametrga hisoblanishi
    Console.WriteLine("Doiraning diametri: " + diametr);   // UI ga chiqarilishi    
}

static void kvadratYuzi()
{
    
    Console.Write("Kvadratning tomonini kiriting:");
    decimal kvadratTomoni = Convert.ToDecimal(Console.ReadLine());
    decimal resultS = kvadratTomoni * kvadratTomoni;
    Console.WriteLine("Kvadratning yuzasi:"+ resultS + "\n");
}

static void tugriTurtburchakPerimetri()
{
    
    Console.WriteLine("1-chi tomonni kiriting:");
    decimal value1 = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("2-chi tomonni kiriting:");
    decimal value2 = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("3-chi tomonni kiriting:");
    decimal value3 = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("4-chi tomonni kiriting:");
    decimal value4 = Convert.ToDecimal(Console.ReadLine());

    decimal perimetr = value1 + value2 + value3 + value4;

    Console.WriteLine("Natija:" + perimetr);
}

