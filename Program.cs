using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shad_Arf_Sadiq___Assignment
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try { 
            //Using try catch To catch any Crush which happen in the program
            while (true) 
                    //Using while loop to help user Order food more Than One 
            {
                    Console.WriteLine("\t\t\t              |---------------------------------------------------|\n\t\t\t -------------|  Soran Universty cafeteria -Sciance-Engineering   |-------------\n\t\t\t              |---------------------------------------------------|\n\t\t\t\t---- Welcome to Soran Universty cafeteria -Sciance-Engineering ----\n");
                    //Why Soran Universty Cafe ? Because I know it i know the prices and drinks and foods types and it is not Large shop or cafe it have few foods and drinks 
                    //And it ins't dream cafe it is real cafe and it is Academy cafe So that is why i Used Saran Universty cafe , I could use Another market but Some of them 
                    //hava a lot of iteam or i could not the real price Of the iteams . So If I did that i may be used Fake prices and iteam which it wast alowed 
                    Console.WriteLine(" - Please Order your food By Number of the foods or drinks list \n");
                    // Just alert User To Pickup Number of the food because if he/she didnt do that the Program may be crush 
                    List();
                    int  WaterSum = 0, CoffeeSum = 0, TeaSum = 0, CapuchnuSum = 0, ChuculataSum = 0, PatatoSum = 0, BayjanSum = 0, FlafleSum = 0, HambargrSum = 0, NyskSum = 0 , BryaniSum = 0 , ShlawgoshtSum = 0 , ShlawbrnjSum = 0 , GazigoshtSum = 0 , GazimrishkSum = 0 , NokSum = 0 , SupSum = 0 ;
                    // all of food Or drinks Number of Order will be refreashing if User Want to refreash them Or rest them
                int Water = 250 , Coffee = 500, Tea = 250 , Capuchnu = 500 , Chuculata = 500 , Patato = 500 , Bayjan = 500 , Flafle = 750 , Hambargr = 1000 , Nysk = 1000 , Sup = 1000 , Nok = 1000 ,  Gazimrishk = 1250,  Gazigosht = 1250 , Shlawbrnj = 2000 , Shlawgosht = 3000 ,  Bryani = 3000;
                    // indentfy all of foods and dirnks price 
                    //all of foods and drinks price will be refreashing if User cancel them
                 int WaterTotal = 0, CoffeeTotal = 0, TeaTotal = 0, CapuchnuTotal = 0, ChuculataTotal = 0, PatatoTotal = 0, BayjanTotal = 0, FlafleTotal = 0, HambargrTotal = 0, NyskTotal = 0, SupTotal = 0, NokTotal = 0, GazimrishkTotal = 0, GazigoshtTotal = 0, ShlawbrnjTotal = 0, ShlawgoshtTotal = 0, BryaniTotal = 0;
                    // Now we indentfy the varible of foods and drinks Sum and price and Total Price 
                    int waterNum, coffeeNum ,TeaNum , CapuchnuNum , ChuculataNum, PatatoNum , BayjanNum , FlaflNum ,HambargrNum , NyskNum , SupNum , NokNum,Gaz_mrishkNum, Gaz_GoshtNum, shlawbrnjNum ,shlawgoshtNum, BryaniNum;
                int Order =1;
                    // indentfy Order =1 and the vaule Order=1  We USe it because if we didnt do that Program gave us Erorr
                while (Order != 0) 
                       //Using while loop if Order =0 the loop will stop  
                {
                       
                        try
                            //Using try Catch too catch crush in our program
                        {
                            Console.Write("\n- please Pick Up your Order Number : ");
                            // Alert User To Pick Up Number making Sure user Pick Up Number  
                            Order = Convert.ToInt32(Console.ReadLine());
                            //Now Order have new value User can Pick Up the value of Order
                            switch (Order)
                            //Using Switch case to let user PickUp number and show User what he/she  Ordered 
                            //Using Switch case because it is fast and it is easy to use and it need less line of codes 
                            {
                                case 0:
                                    Console.WriteLine("\n - Your Order Has Been canceled");
                                    // after User Order any think user can cancel own Order by chooses case 0
                                    break;
                                case 1:
                                    Console.WriteLine($"Water price - {Water} Dinnar :");
                                    Console.Write("How Many Water do you want ? ");
                                    
                                    //Number 1 is water So USer can pickup how many water do he/she want
                                     waterNum = Convert.ToInt32(Console.ReadLine());
                                    //convert waterNUmber  to int 
                                    WaterSum = WaterSum + waterNum;
                                    //water sum is mean pluses all water Number if user picked Up,  user may pick up 2 in first loop but user want to pick up more water
                                    //in second loop user can order 2 more water so the sum of water isnt 2 it is 4 water  
                                    WaterTotal = WaterSum * Water;
                                    // water Total is mean total of water price if user Order 3 water So the total price is 750 dinnar it is not 250 
                                    Console.WriteLine($"{WaterSum} Water -   {WaterTotal} Dinnar");
                                    // Our aim is that we want too tell user How may water he/she Ordered and How Much the Tolal of the water be 
                                    break;
                                case 2:
                                    Console.WriteLine($"Coffee price - {Coffee} Dinnar :");
                                    Console.Write("How Many Coffee do you want ? ");
                                    // case Number 2 is caffee 
                                    coffeeNum = Convert.ToInt32(Console.ReadLine());
                                    CoffeeSum = CoffeeSum + coffeeNum;
                                    //Likewise CoffeeSum is sum of the CoffeeNumber which time user Order Coffee each loop it will be incrising 
                                    CoffeeTotal = CoffeeSum * Coffee;
                                    //and CaffeeTotal is Used for the prices MainPrice miltple of Coffee Sum 
                                    Console.WriteLine($" {CoffeeSum} Coffee -  {CoffeeTotal}  Dinnar   ");
                                    break;
                                    // like the case of the water Our aim is that we want tell user How many coffee he/she Ordered and how much the price is 
                                case 3:
                                    Console.WriteLine($"Tea price - {Tea} Dinnar :");
                                    Console.Write("How Many tea do you want ? ");
                                    // I should not Expalin all of them all cased have same idea 
                                    TeaNum = Convert.ToInt32(Console.ReadLine());
                                    TeaSum = TeaSum + TeaNum;
                                    TeaTotal = Tea * TeaSum;
                                    Console.WriteLine($" {TeaSum} Tea -  {TeaTotal} Dinnar    ");
                                    break;
                                case 4:
                                    Console.WriteLine($"Capuchnu price - {Capuchnu} Dinnar :");
                                    Console.Write("How Many Capuchnu do you want ? ");
                                    CapuchnuNum = Convert.ToInt32(Console.ReadLine());
                                    CapuchnuSum = CapuchnuSum + CapuchnuNum;
                                    CapuchnuTotal = CapuchnuSum * Capuchnu;
                                    Console.WriteLine($" {CapuchnuSum} Capuchnu -  {CapuchnuTotal} Dinnar    ");
                                    break;
                                case 5:
                                    Console.WriteLine($"Chuculata price - {Chuculata} Dinnar :");
                                    Console.Write("How Many Chuculata do you want ? ");
                                    ChuculataNum = Convert.ToInt32(Console.ReadLine());
                                    ChuculataSum = ChuculataSum + ChuculataNum;
                                    ChuculataTotal = ChuculataSum * Chuculata;
                                    Console.WriteLine($" {ChuculataSum} Chuculata -  {ChuculataTotal} Dinnar    ");
                                    break;
                                case 6:
                                    Console.WriteLine($"Patato price - {Patato} Dinnar :");
                                    Console.Write("How Many Patato do you want ? ");
                                    PatatoNum = Convert.ToInt32(Console.ReadLine());
                                    PatatoSum = PatatoSum + PatatoNum;
                                    PatatoTotal = PatatoSum * Patato;
                                    Console.WriteLine($" {PatatoSum} Patato -  {PatatoTotal} Dinnar    ");
                                    break;
                                case 7:
                                    Console.WriteLine($"Bayjan price - {Bayjan} Dinnar :");
                                    Console.Write("How Many Bayjan do you want ? ");
                                    BayjanNum = Convert.ToInt32(Console.ReadLine());
                                    BayjanSum = BayjanSum + BayjanNum;
                                    BayjanTotal = BayjanSum * Bayjan;
                                    Console.WriteLine($" {BayjanSum} Bayjan -  {BayjanTotal} Dinnar");
                                    break;
                                case 8:
                                    Console.WriteLine($"Flafl price - {Flafle} Dinnar :");
                                    Console.Write("How Many Flafle do you want ? ");
                                    FlaflNum = Convert.ToInt32(Console.ReadLine());
                                    FlafleSum = FlafleSum + FlaflNum;
                                    FlafleTotal = FlafleSum * Flafle;
                                    Console.WriteLine($" {FlafleSum} Flafle -  {FlafleTotal} Dinnar    ");
                                    break;
                                case 9:
                                    Console.WriteLine($"Hambargr price - {Hambargr} Dinnar :");
                                    Console.Write("How Many Hambargr do you want ? ");
                                    HambargrNum = Convert.ToInt32(Console.ReadLine());
                                    HambargrSum = HambargrSum + HambargrNum;
                                    HambargrTotal = HambargrSum * Hambargr;
                                    Console.WriteLine($" {HambargrSum} Hambargr -  {HambargrTotal} Dinnar    ");
                                    break;
                                case 10:
                                    Console.WriteLine($"Nysk price - {Nysk} Dinnar :");
                                    Console.Write("How Many Nysk do you want ? ");
                                    NyskNum = Convert.ToInt32(Console.ReadLine());
                                    NyskSum = NyskSum + NyskNum;
                                    NyskTotal = NyskSum * Nysk;
                                    Console.WriteLine($" {NyskSum} Nysk -  {NyskTotal} Dinnar    ");
                                    break;
                                case 11:
                                    Console.WriteLine($"Sup price - {Sup} Dinnar :");
                                    Console.Write("How Many Sup do you want ? ");
                                    SupNum = Convert.ToInt32(Console.ReadLine());
                                    SupSum = SupSum + SupNum;
                                    SupTotal = SupSum * Sup;
                                    Console.WriteLine($" {SupSum} Sup -  {SupTotal} Dinnar    ");
                                    break;
                                case 12:
                                    Console.WriteLine($"Nok price - {Nok} Dinnar :");
                                    Console.Write("How Many Nok do you want ? ");
                                    NokNum = Convert.ToInt32(Console.ReadLine());
                                    NokSum = NokSum + NokNum;
                                    NokTotal = NokSum * Nok;
                                    Console.WriteLine($" {NokSum} Nok -  {NokTotal} Dinnar    ");
                                    break;
                                case 13:
                                    Console.WriteLine($"Gazi Mrishk price - {Gazimrishk} Dinnar :");
                                    Console.Write("How Many Gazi mrishk do you want ? ");
                                    Gaz_mrishkNum = Convert.ToInt32(Console.ReadLine());
                                    GazimrishkSum = GazimrishkSum + Gaz_mrishkNum;
                                    GazimrishkTotal = GazimrishkSum * Gazimrishk;
                                    Console.WriteLine($" {GazimrishkSum} Gazi mrishk -  {GazimrishkTotal} Dinnar    ");
                                    break;
                                case 14:
                                    Console.WriteLine($"Gazi Gosht price - {Gazigosht} Dinnar :");
                                    Console.Write("How Many Gazi Gosht do you want ? ");
                                    Gaz_GoshtNum = Convert.ToInt32(Console.ReadLine());
                                    GazigoshtSum = GazigoshtSum - Gaz_GoshtNum;
                                    GazigoshtTotal = GazigoshtSum * Gazigosht;
                                    Console.WriteLine($" {GazigoshtSum} Gazi Gosht -  {GazigoshtTotal} Dinnar    ");
                                    break;
                                case 15:
                                    Console.WriteLine($"Shla w Brinj price - {Shlawbrnj} Dinnar :");
                                    Console.Write("How Many Shla w brnj do you want ? ");
                                    shlawbrnjNum = Convert.ToInt32(Console.ReadLine());
                                    ShlawbrnjSum = ShlawbrnjSum + shlawbrnjNum;
                                    ShlawbrnjTotal = ShlawbrnjSum * Shlawbrnj;
                                    Console.WriteLine($" {ShlawbrnjSum} Shla w brnj -  {ShlawbrnjTotal} Dinnar    ");
                                    break;
                                case 16:
                                    Console.WriteLine($"Shla W Gosht price - {Shlawgosht} Dinnar :");
                                    Console.Write("How Many Shla w gosht do you want ? ");
                                    shlawgoshtNum = Convert.ToInt32(Console.ReadLine());
                                    ShlawgoshtSum = ShlawgoshtSum + shlawgoshtNum;
                                    ShlawgoshtTotal = ShlawgoshtSum * Shlawgosht;
                                    Console.WriteLine($" {ShlawgoshtSum} Shla w gosht -  {ShlawgoshtTotal} Dinnar    ");
                                    break;
                                case 17:
                                    Console.WriteLine($"Bryani price - {Bryani} Dinnar :");
                                    Console.Write("How Many Bryani do you want ? ");
                                    BryaniNum = Convert.ToInt32(Console.ReadLine());
                                    BryaniSum = BryaniSum + BryaniNum;
                                    BryaniTotal = BryaniSum * Bryani;
                                    Console.WriteLine($" {BryaniSum} Bryani -  {BryaniTotal} Dinnar     ");
                                    break;
                                case 18:
                                    //if User Order Number 18 
                                    int Total = BryaniTotal + ShlawgoshtTotal + ShlawbrnjTotal + GazigoshtTotal + GazimrishkTotal + NokTotal + WaterTotal + CoffeeTotal + TeaTotal + CapuchnuTotal + ChuculataTotal + PatatoTotal + BayjanTotal + FlafleTotal + HambargrTotal + NyskTotal + SupTotal;
                                    // We Total of all the prices in Value ofTotal
                                    Cases(WaterSum, CoffeeSum, TeaSum, CapuchnuSum, ChuculataSum, PatatoSum, BayjanSum, FlafleSum, HambargrSum, NyskSum, BryaniSum, ShlawgoshtSum, ShlawbrnjSum, GazigoshtSum, GazimrishkSum, NokSum, SupSum, WaterTotal, CoffeeTotal, TeaTotal, CapuchnuTotal, ChuculataTotal, PatatoTotal, BayjanTotal, FlafleTotal, HambargrTotal, NyskTotal, SupTotal, NokTotal, GazimrishkTotal, GazigoshtTotal, ShlawbrnjTotal, ShlawgoshtTotal, BryaniTotal );
                                    Console.Write(" Thanks To Choose Soran Univirsty Caftiria your Order has been Done if you Want More food press 1 ,  if you Done press 0");
                                     // tell user to choose Number 1 to countinus the loop and press 0 to stop the loop 
                                    Order = Convert.ToInt32(Console.ReadLine());
                                    // Coverting New Value of Order  to int
                                    break;
                                case 19:
                                    //if User Order Number 19
                                    Cases(WaterSum, CoffeeSum, TeaSum, CapuchnuSum, ChuculataSum, PatatoSum, BayjanSum, FlafleSum, HambargrSum, NyskSum, BryaniSum, ShlawgoshtSum, ShlawbrnjSum, GazigoshtSum, GazimrishkSum, NokSum, SupSum,WaterTotal, CoffeeTotal, TeaTotal, CapuchnuTotal, ChuculataTotal, PatatoTotal, BayjanTotal, FlafleTotal, HambargrTotal, NyskTotal, SupTotal, NokTotal, GazimrishkTotal, GazigoshtTotal, ShlawbrnjTotal, ShlawgoshtTotal, BryaniTotal);
                                    break;
                                case 20:
                                    //case 20 if user print 20 she/he can refuse his/her Order for example if he/she dont want to Order 4 water USer can refuse 4 water and Order 2 water  
                                    Console.WriteLine("This is Your Order list");
                                    // tell User than we will show him his/her Order list Tell his the Number of the foods and drinks and coun of the food and drinks User Ordered and the prices 
                                    Console.WriteLine("\nN |  Your Order  |   Prices ");
                                    //again alerting User which that is 3 lists of Number And Counting Order and The Priced
                                    Console.WriteLine("-----------------------------");
                                    if (WaterTotal > 0)
                                    {
                                        Console.WriteLine($"1 |{WaterSum}  Water      |  {WaterTotal}");
                                    }
                                    if (CoffeeTotal > 0)
                                    {
                                        Console.WriteLine($"2 |{CoffeeSum}  Coffee     |  {CoffeeTotal}");
                                    }
                                    if (TeaTotal > 0)
                                    {
                                        Console.WriteLine($"3 |{TeaSum}  Tea        |  {TeaTotal}");
                                    }
                                    if (CapuchnuTotal > 0)
                                    {
                                        Console.WriteLine($"4 |{CapuchnuSum}  Capuchnu   |  {CapuchnuTotal}");
                                    }
                                    if (ChuculataTotal > 0)
                                    {
                                        Console.WriteLine($"5 |{ChuculataSum}  Chuculata  |  {ChuculataTotal}");
                                    }
                                    if (PatatoTotal > 0)
                                    {
                                        Console.WriteLine($"6 |{PatatoSum}  Patato     |  {PatatoTotal}");
                                    }
                                    if (BayjanTotal > 0)
                                    {
                                        Console.WriteLine($"7 |{BayjanSum}  Bayjan     |  {BayjanTotal}");
                                    }
                                    if (FlafleTotal > 0)
                                    {
                                        Console.WriteLine($"8 |{FlafleSum}  Flafle     |  {FlafleTotal}");
                                    }
                                    if (HambargrTotal > 0)
                                    {
                                        Console.WriteLine($"9 |{HambargrSum}  Hambargr   |  {HambargrTotal}");
                                    }
                                    if (NyskTotal > 0)
                                    {
                                        Console.WriteLine($"10|{NyskSum}  Nysk       |  {NyskTotal}");
                                    }
                                    if (SupTotal > 0)
                                    {
                                        Console.WriteLine($"11|{SupSum}  Sup        |  {SupTotal}");
                                    }
                                    if (NokTotal > 0)
                                    {
                                        Console.WriteLine($"12|{NokSum}  Nok        |  {NokTotal}");
                                    }
                                    if (GazimrishkTotal > 0)
                                    {
                                        Console.WriteLine($"13|{GazimrishkSum}  Gazimrishk |  {GazimrishkTotal}");
                                    }
                                    if (GazigoshtTotal > 0)
                                    {
                                        Console.WriteLine($"14|{GazigoshtSum}  Gazigosht  |  {GazigoshtTotal}");
                                    }
                                    if (ShlawbrnjTotal > 0)
                                    {
                                        Console.WriteLine($"15|{ShlawbrnjSum}  Shlawbrnj  |  {ShlawbrnjTotal}");
                                    }
                                    if (ShlawgoshtTotal > 0)
                                    {
                                        Console.WriteLine($"16|{ShlawgoshtSum}  Shlawgosht |  {ShlawgoshtTotal}");
                                    }
                                    if (BryaniTotal > 0)
                                    {
                                        Console.WriteLine($"17|{BryaniSum}  Bryani     |  {BryaniTotal}");
                                    }

                                    int Refuse = 1;
                                    //So Refuse equl to 1 because if Refuse equl to 0 the loop emergsy Stop and if we didnt indentfy Refuse we might be see erorr
                                    while (Refuse !=0) {
                                        //So if Refuse does not equl to 0 the loop will be stating 
                                        try {
                                            //Using try To catching any bugs and Crushes in the Program
                                            Console.Write(" - Press 0 To Exit  \n -Which Order do you Want refuse Print Number Of Your Order ");
                                            //telling User That he/she Can refuse His/Her Order By printing the Number of his Order which we was alert him/her moment ago
                                            //And Tell User Can press 0 to Exit because if User Print 0 the Loop Will be Stop
                                            Refuse = Convert.ToInt32(Console.ReadLine());
                                            //Now Refuse Has been Changed to int and Switch Case will Use it 
                                            switch (Refuse) {
                                                case 0:
                                                    Console.WriteLine(" - You Exit From refuseing iteams ");
                                                    // after User Wanted To Exit From Refusing his/her foods and drinks User Can Exit From their by choosing case 0
                                                    break;
                                                case 1:
                                                   
                                                  
                                                        Console.WriteLine("How Many Water do you want To Refuse ? ");
                                                        //Number 1 is water So USer can Refuse how many water do he/she want
                                                        int waterRefuse = Convert.ToInt32(Console.ReadLine());
                                                        //convert water Refuse   to int 
                                                        WaterSum = WaterSum - waterRefuse;
                                                        //Before The list of Refuseing WaterSum was eqal to Water plus WaterNum But Now if he print and NUmber WaterSum will be minus To That Number 
                                                        if (WaterSum <= 0)
                                                        //if waterSum was Smaller Than 0 We cant tell User That he Ordered -2 Water So We Must Fix that By if statment
                                                        {
                                                        WaterSum = 0;
                                                        //Water Sum will be equl to 0 if User Print Number That was bigger Than WaterSum
                                                        Console.WriteLine("You Refused All Waters");
                                                        //And Tell User That he/She Refused All iteams                                                            
                                                        }
                                                    //if USer have 10 water sum is mean Minuses all water Refuseing Number if user  Refused,  user may Refuse 2 water in first loop but user want to Refuse more water
                                                    //in second loop user can Refuse 2 more water so the sum of water isnt 8 it is 6 water  
                                                    WaterTotal = WaterSum * Water;
                                                    // water Total is mean total of water price if user Order 3 water So the total price is 750 dinnar it is not 250 
                                                    Console.WriteLine($"{WaterSum} Water -   {WaterTotal} Dinnar");
                                                    // And At The End Telling USer How many water did he/she HAVE and Total Prices of water
                                                    break;
                                                case 2:
                                                    //Likewise of Case Number 1 But in that case User Can Refuse Coffee NOT Water
                                                   Console.WriteLine("How Many Coffee do you want To Refuse ? ");
                                                        // case Number 2 is caffee 
                                                        int coffeeRefuse = Convert.ToInt32(Console.ReadLine());
                                                        CoffeeSum = CoffeeSum - coffeeRefuse;
                                                    //User can Refuse how many Coffee Do he/she Want But Not More That he/she Ordered
                                                        if (CoffeeSum <= 0)
                                                        //NOT Smaller Than 0
                                                        {
                                                        CoffeeSum = 0;
                                                        Console.WriteLine("You Refused All Coffee");
                                                         }
                                                    //Likewise CoffeeSum is sum of the CoffeeNumber which time user Order Coffee each loop it will be incrising 
                                                    CoffeeTotal = CoffeeSum * Coffee;
                                                    //and CaffeeTotal is Used for the prices MainPrice miltple of Coffee Sum 
                                                    Console.WriteLine($" {CoffeeSum} Coffee -  {CoffeeTotal}  Dinnar   ");
                                                    //Telling User how many Coffee Do he/she have and Total Price of Her/Him Order
                                                    break;
                                                case 3:
                                                        Console.WriteLine("How Many Tea do you want To Refuse ? ");
                                                        // I should not Expalin all of them all cased have same idea 
                                                        int TeaRefuse = Convert.ToInt32(Console.ReadLine());
                                                        TeaSum = TeaSum - TeaRefuse;
                                                        if (TeaSum <= 0)
                                                        {
                                                        TeaSum = 0;
                                                        Console.WriteLine("You Refused All Tea");
                                                    }
                                                    TeaTotal = Tea * TeaSum;
                                                    Console.WriteLine($" {TeaSum} Tea -  {TeaTotal} Dinnar    ");
                                                    break;
                                                case 4:
                                                    Console.WriteLine("How Many Capuchnu do you want To Refuse ? ");
                                                        int CapuchnuRefuse = Convert.ToInt32(Console.ReadLine());
                                                        CapuchnuSum = CapuchnuSum - CapuchnuRefuse;
                                                        if (CapuchnuSum <= 0)
                                                        {
                                                        CapuchnuSum = 0;
                                                        Console.WriteLine("You Refused All Capuchnu");
                                                    }
                                                    CapuchnuTotal = CapuchnuSum * Capuchnu;
                                                    Console.WriteLine($" {CapuchnuSum} Capuchnu -  {CapuchnuTotal} Dinnar    ");
                                                    break;
                                                case 5:
                                                    Console.WriteLine("How Many Chuculata do you want To Refuse ? ");
                                                        int ChuculataRefuse = Convert.ToInt32(Console.ReadLine());
                                                        ChuculataSum = ChuculataSum - ChuculataRefuse;
                                                        if (ChuculataSum <= 0)
                                                        {
                                                        ChuculataSum = 0;
                                                        Console.WriteLine("You Refused All Chuculata");
                                                    }
                                                    ChuculataTotal = ChuculataSum * Chuculata;
                                                    Console.WriteLine($" {ChuculataSum} Chuculata -  {ChuculataTotal} Dinnar    ");
                                                    break;
                                                case 6:
                                                        Console.WriteLine("How Many Patato do you want To Refuse ? ");
                                                        int PatatoRefuse = Convert.ToInt32(Console.ReadLine());
                                                        PatatoSum = PatatoSum - PatatoRefuse;
                                                        if (PatatoSum <= 0)
                                                        {
                                                        PatatoSum = 0;
                                                        Console.WriteLine("You Refused All Patato");
                                                    }
                                                    PatatoTotal = PatatoSum * Patato;
                                                    Console.WriteLine($" {PatatoSum} Patato -  {PatatoTotal} Dinnar    ");
                                                    break;
                                                case 7:
                                                        Console.WriteLine("How Many Bayjan do you want To Refuse ? ");
                                                        int BayjanRefuse = Convert.ToInt32(Console.ReadLine());
                                                        BayjanSum = BayjanSum - BayjanRefuse;
                                                        if (BayjanSum <= 0)
                                                        {
                                                        BayjanSum = 0;
                                                        Console.WriteLine("You Refused All Bayjan");
                                                    }
                                                    BayjanTotal = BayjanSum * Bayjan;
                                                    Console.WriteLine($" {BayjanSum} Bayjan -  {BayjanTotal} Dinnar");
                                                    break;
                                                case 8:
                                                        Console.WriteLine("How Many Flafle do you want To Refuse ? ");
                                                        int FlaflRefuse = Convert.ToInt32(Console.ReadLine());
                                                        FlafleSum = FlafleSum - FlaflRefuse;
                                                        if (FlafleSum <= 0)
                                                        {
                                                        FlafleSum = 0;
                                                        Console.WriteLine("You Refused All Flafle");
                                                    }
                                                    FlafleTotal = FlafleSum * Flafle;
                                                    Console.WriteLine($" {FlafleSum} Flafle -  {FlafleTotal} Dinnar    ");
                                                    break;
                                                case 9:
                                                        Console.WriteLine("How Many Hambargr do you want To Refuse ? ");
                                                        int HambargrRefuse = Convert.ToInt32(Console.ReadLine());
                                                        HambargrSum = HambargrSum - HambargrRefuse;
                                                        if (HambargrSum <= 0)
                                                        {
                                                        HambargrSum = 0;
                                                        Console.WriteLine("You Refused All Hambargr");
                                                    }
                                                    HambargrTotal = HambargrSum * Hambargr;
                                                    Console.WriteLine($" {HambargrSum} Hambargr -  {HambargrTotal} Dinnar    ");
                                                    break;
                                                case 10:
                                                        Console.WriteLine("How Many Nysk do you want To Refuse ? ");
                                                        int NyskRefuse = Convert.ToInt32(Console.ReadLine());
                                                        NyskSum = NyskSum - NyskRefuse;
                                                        if (NyskSum <= 0)
                                                        {
                                                        NyskSum = 0;
                                                        Console.WriteLine("You Refused All Nysk");
                                                    }
                                                    NyskTotal = NyskSum * Nysk;
                                                    Console.WriteLine($" {NyskSum} Nysk -  {NyskTotal} Dinnar    ");
                                                    break;
                                                case 11:
                                                        Console.WriteLine("How Many Sup do you want To Refuse ? ");
                                                        int SupRefuse = Convert.ToInt32(Console.ReadLine());
                                                        SupSum = SupSum - SupRefuse;
                                                        if (SupSum <= 0)
                                                        {
                                                        SupSum = 0;
                                                        Console.WriteLine("You Refused All Sup");
                                                    }
                                                    SupTotal = SupSum * Sup;
                                                    Console.WriteLine($" {SupSum} Sup -  {SupTotal} Dinnar    ");
                                                    break;
                                                case 12:
                                                        Console.WriteLine("How Many Nok do you want To Refuse ? ");
                                                        int NokRefuse = Convert.ToInt32(Console.ReadLine());
                                                        NokSum = NokSum - NokRefuse;
                                                        if (NokSum <= 0)
                                                        {
                                                        NokSum = 0;
                                                        Console.WriteLine("You Refused All Nok");
                                                    }
                                                    NokTotal = NokSum * Nok;
                                                    Console.WriteLine($" {NokSum} Nok -  {NokTotal} Dinnar    ");
                                                    break;
                                                case 13:
                                                        Console.WriteLine("How Many Gazi mrishk do you want To Refuse ? ");
                                                        int Gaz_mrishkRefuse = Convert.ToInt32(Console.ReadLine());
                                                        GazimrishkSum = GazimrishkSum - Gaz_mrishkRefuse;
                                                        if (GazimrishkSum <= 0)
                                                        {
                                                        GazimrishkSum = 0;
                                                        Console.WriteLine("You Refused All Gazi mrishk");
                                                    }
                                                    GazimrishkTotal = GazimrishkSum * Gazimrishk;
                                                    Console.WriteLine($" {GazimrishkSum} Gazi mrishk -  {GazimrishkTotal} Dinnar    ");
                                                    break;
                                                case 14:
                                                        Console.WriteLine("How Many Gazi Gosht do you want To Refuse ? ");
                                                        int Gaz_GoshtRefuse = Convert.ToInt32(Console.ReadLine());
                                                        GazigoshtSum = GazigoshtSum - Gaz_GoshtRefuse;
                                                        if (GazigoshtSum <= 0)
                                                        {
                                                        GazigoshtSum = 0;
                                                        Console.WriteLine("You Refused All Gazi gosht");
                                                    }
                                                    GazigoshtTotal = GazigoshtSum * Gazigosht;
                                                    Console.WriteLine($" {GazigoshtSum} Gazi Gosht -  {GazigoshtTotal} Dinnar    ");
                                                    break;
                                                case 15:
                                                        Console.WriteLine("How Many Shla w brnj do you want To Refuse ? ");
                                                        int shlawbrnjRefuse = Convert.ToInt32(Console.ReadLine());
                                                        ShlawbrnjSum = ShlawbrnjSum - shlawbrnjRefuse;
                                                        if (ShlawbrnjSum <= 0)
                                                        {
                                                        ShlawbrnjSum = 0;
                                                        Console.WriteLine("You Refused All Shla w brnj");
                                                    }
                                                    ShlawbrnjTotal = ShlawbrnjSum * Shlawbrnj;
                                                    Console.WriteLine($" {ShlawbrnjSum} Shla w brnj -  {ShlawbrnjTotal} Dinnar    ");
                                                    break;
                                                case 16:
                                                        Console.WriteLine("How Many Shla w gosht do you want To Refuse ? ");
                                                        int shlawgoshtRefuse = Convert.ToInt32(Console.ReadLine());
                                                        ShlawgoshtSum = ShlawgoshtSum - shlawgoshtRefuse;
                                                        if (ShlawgoshtSum <= 0)
                                                        {
                                                        ShlawgoshtSum = 0;
                                                        Console.WriteLine("You Refused All Shla w gosht");
                                                    }
                                                    ShlawgoshtTotal = ShlawgoshtSum * Shlawgosht;
                                                    Console.WriteLine($" {ShlawgoshtSum} Shla w gosht -  {ShlawgoshtTotal} Dinnar    ");
                                                    break;
                                                case 17:
                                                        Console.WriteLine("How Many Bryani do you want To Refuse ? ");
                                                        int BryaniRefuse = Convert.ToInt32(Console.ReadLine());
                                                        BryaniSum = BryaniSum - BryaniRefuse;
                                                        if (BryaniSum <= 0)
                                                        {
                                                        BryaniSum = 0;
                                                        Console.WriteLine("You Refused All Bryani");
                                                    }
                                                    BryaniTotal = BryaniSum * Bryani;
                                                    Console.WriteLine($" {BryaniSum} Bryani -  {BryaniTotal} Dinnar     ");
                                                    break;
                                                default:
                                                    Console.WriteLine("Sorry You may be didnt Print right Number Please Try Again ");
                                                    //If User Print  Ivaild Number The program will Tell USer That He/She Didint Print Right Numbe                                                    
                                                    break;
                                            }
                                          
                                        }catch
                                        //Catching the issur of Our Program
                                        {
                                            Console.WriteLine("You Entered Eroor Number ");
                                            //and tell User which He/She Entered Some Wrong Number 
                                        }
                                        }
                                    break;
                                default:
                                    //default for any another Number user print
                                    Console.WriteLine("Ivaild Number Please Try again \n  - please Enter Number which avaliable in the list");
                                    //tell user who he/she didnt print right Number 
                                    break;
                            }
                            //the cases of the food will be End here                          
                                if (Order != 0 )
                                // if value of Order didnt equl to 0
                            {
                                if (Order !=18)
                                // And if value of Order didnt equl to 18
                                {
                                    if (Order !=20)
                                    // if value of Order didnt equl to 20
                                    {
                                        Console.Write("\n -press 0 to cancel All your Order  ");
                                        Console.Write(" | press 18 to Order your Foods and drinks  ");
                                        Console.WriteLine(" | press 19 to see Your Order List  ");
                                        Console.WriteLine("- press 20 If you Want to refuse any iteam of your Order");
                                        // So if it wast tell User to press 0 To cancel the Order and Stop the loop
                                        //and press 18 to Order the foods and drinks and make sure that he/she Order the food / drink
                                        // and press 20 just to tell them the prices of the food 
                                        // But if User did Order Number 0 oe 18 or 20 We should not tell user to print them because he/she printed that 
                                    }
                                }
                            }

                        }
                        catch
                        //and if the Program crushed we will catch it
            {

                            Console.WriteLine("Sorry Something went Worng please try again ... ");
                            // and apolgize to User which Some thing went Worng it may be USer didnt print int in the int my she/he print string or character 
            }
        }
                // the loop end here if user Wanted to stop the loop 
                Console.Write(" - press 0 To Exit press 1 To Order Another New Food OR Drinks : ");
                    //and tell user too press 0 to Exit the Program and press 1 To Order new food or drinks
                int LastTime = Convert.ToInt32(Console.ReadLine());
                    // and at the last time we Convert it to int  
                if (LastTime == 0)
                        //if user print 0 
                {       
                        Console.Clear();
                        //All lists and Order Will be clear 
                        break;
                        // and the loop will be End 
                }
                else if (LastTime == 1)
                        // if user print 1
                {                       
                        Console.Clear();
                        //All lists and Order Will be clear
                        Console.WriteLine(" - Your list Has been refreashed\n");
                        //and Tell USer which Every things has been Refreashed and creared
                        continue;
                        //and he can Coutinues 
                }
            }
            }
            catch
            // and catching the bugs or crushes
            {
                Console.WriteLine("Sorry Something went Worng !!");
                //tell user Some things Gone worng 
                Console.ReadKey();
                // and Program will be stop
            }
            List();
            Console.ReadKey();
            /*la kotayyda la 6/3/2022 katzhmer 19:15 xulak aw assignmentam tawaw krd datwanm blem yakek bw la gawratryn aw karanay ka la Programing da anjamm dawa
              waku bleynt awa yakam Projecti mn bww la Programing ba taybati la C# dazanm aw Projecta shti halay tyada zor sht mawa ka bas bkret w karakanm asan tr bkat
              balam kati mawa ka bakari bhenin awanish method w Class w Object bwn ka pem wabet damtwani babakar henani awan la jey away 17 jar blem water w coffee hata dway
            Rastaw Xo Classekyan bo drwst bkayn , taka kesha ka lerada hastm pe krd awish zori Linakana ka awish ba brway mn yekek la hokarakani awabw ka dawakaran zor bwn 
            ka 17 dawakari bwn hokari aw zoriash bo awa dagaretawa ka caftriay bashi zanst w andazyari 17 jori xwardn w xwardawayan haya boya banachari 17 jor dawakarim nwy
            wa hokareki trish bo zori linakant awabw ka class w method w Objetm bakar nahenawa , hawlm da ta ba kamtryn Line Codakanm bnwsm balam har dabwaya ka awanda xataya bakar benm bo Aw assignmentayam .             
            lakotayda hokari habzharni zmani Englizy lanaw Commentakan w dawakaryakan : 
            bo awa dagaretawa ka zmani englizy zyatr rwn tr wa fonti zmani kurdi babashi kari nadakrd wa harwaha zmani englizy zyatr academy tra w zmani zansta yani labar 
            away codakan hamw Engilizya boya zmani Englizm halbzhard 

             qutabi Shad Arf Sadiq 
            xosh7al dabm ba FeedBackek agadarm bkaytawa ka halakanm chi bwn chi nabwm 
            */
        }
        static void List()
        {
            Console.WriteLine("\t   Foods          |  Price / dinner ");
            Console.WriteLine("--------------------------|-----------------------------\n\t 1- Water         |        250       \n\t 2- Coffee        |        500       \n\t 3- Tea           |        250       \n\t 4- Capuchnu      |        500       \n\t 5- Chuculata     |        500       \n\t 6- Patato        |        500       \n\t 7- Baynjan       |        500       \n\t 8- Flafl         |        750       \n\t 9- Hambargr      |        1000      \n\t 10- Nysk         |        1000      \n\t 11- Sup          |        1000      \n\t 12- Nok          |        1000      \n\t 13- Gazi mrishk  |        1250      \n\t 14- Gazi gosht   |        1250      \n\t 15- Shla w brnj  |        2000      \n\t 16- Shla w gosht |        3000      \n\t 17- Bryani       |        3000      ");
            // the list of the food before User Order any food he/she Should know The price of the food So first user can watch the list of the food 

        }
        static void Cases (int WaterSum , int CoffeeSum , int TeaSum , int CapuchnuSum , int ChuculataSum , int PatatoSum , int BayjanSum , int FlafleSum , int HambargrSum , int NyskSum , int BryaniSum , int ShlawgoshtSum , int ShlawbrnjSum , int GazigoshtSum ,int GazimrishkSum ,int NokSum ,int SupSum,int WaterTotal,int CoffeeTotal  ,int TeaTotal  ,int CapuchnuTotal  ,int ChuculataTotal  ,int PatatoTotal  ,int BayjanTotal  ,int FlafleTotal  , int HambargrTotal  , int NyskTotal  , int SupTotal  , int NokTotal  , int GazimrishkTotal  , int GazigoshtTotal  , int ShlawbrnjTotal  , int ShlawgoshtTotal  , int BryaniTotal)
        {

            // all of food Or drinks Number of Order will be refreashing if User Want to refreash them Or rest them
         
            
            //all of foods and drinks price will be refreashing if User cancel them
            // Now we indentfy the varible of foods and drinks Sum and price and Total Price 
            
            int Total = BryaniTotal + ShlawgoshtTotal + ShlawbrnjTotal + GazigoshtTotal + GazimrishkTotal + NokTotal + WaterTotal + CoffeeTotal + TeaTotal + CapuchnuTotal + ChuculataTotal + PatatoTotal + BayjanTotal + FlafleTotal + HambargrTotal + NyskTotal + SupTotal;
            //we Total of the Foods Total here So we addition all of them in One variable                                  
            Console.WriteLine("\n  Your Order     |   Prices ");
            Console.WriteLine("-----------------------------");
            //again we created another list for User if User press 19 HE/She can see what did she/he Ordered 
            if (WaterTotal > 0)
            {
                Console.WriteLine($"{WaterSum}  Water         |  {WaterTotal}");
            }
            if (CoffeeTotal > 0)
            {
                Console.WriteLine($"{CoffeeSum}  Coffee        |  {CoffeeTotal}");
            }
            if (TeaTotal > 0)
            {
                Console.WriteLine($"{TeaSum}  Tea           |  {TeaTotal}");
            }
            if (CapuchnuTotal > 0)
            {
                Console.WriteLine($"{CapuchnuSum}  Capuchnu      |  {CapuchnuTotal}");
            }
            if (ChuculataTotal > 0)
            {
                Console.WriteLine($"{ChuculataSum}  Chuculata     |  {ChuculataTotal}");
            }
            if (PatatoTotal > 0)
            {
                Console.WriteLine($"{PatatoSum}  Patato        |  {PatatoTotal}");
            }
            if (BayjanTotal > 0)
            {
                Console.WriteLine($"{BayjanSum}  Bayjan        |  {BayjanTotal}");
            }
            if (FlafleTotal > 0)
            {
                Console.WriteLine($"{FlafleSum}  Flafle        |  {FlafleTotal}");
            }
            if (HambargrTotal > 0)
            {
                Console.WriteLine($"{HambargrSum}  Hambargr      |  {HambargrTotal}");
            }
            if (NyskTotal > 0)
            {
                Console.WriteLine($"{NyskSum}  Nysk          |  {NyskTotal}");
            }
            if (SupTotal > 0)
            {
                Console.WriteLine($"{SupSum}  Sup           |  {SupTotal}");
            }
            if (NokTotal > 0)
            {
                Console.WriteLine($"{NokSum}  Nok           |  {NokTotal}");
            }
            if (GazimrishkTotal > 0)
            {
                Console.WriteLine($"{GazimrishkSum}  Gazimrishk    |  {GazimrishkTotal}");
            }
            if (GazigoshtTotal > 0)
            {
                Console.WriteLine($"{GazigoshtSum}  Gazigosht     |  {GazigoshtTotal}");
            }
            if (ShlawbrnjTotal > 0)
            {
                Console.WriteLine($"{ShlawbrnjSum}  Shlawbrnj     |  {ShlawbrnjTotal}");
            }
            if (ShlawgoshtTotal > 0)
            {
                Console.WriteLine($"{ShlawgoshtSum}  Shlawgosht    |  {ShlawgoshtTotal}");
            }
            if (BryaniTotal > 0)
            {
                Console.WriteLine($"{BryaniSum}  Bryani        |  {BryaniTotal}");
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-  Total         |  " + Total + " Dinnar ");

            //we Total of the Foods Total here So we addition all of them in One variable

            //So Order Number 19 tell User How Much the Total price is he/she Ordered and what did he/she Ordered before and Total of price of the iteams

        }
    }


}
