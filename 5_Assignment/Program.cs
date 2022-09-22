//Un-comment below code and fix the issues
//Push to github


    uint FibNum = 0, FibNum1 = 1, FibNum2,i;
    int FibbyMan = 37;

    Console.WriteLine("Do you want to see the first 40 Fibonacci numbers?");
    Console.ReadLine();
    Console.WriteLine("Of course you do :)");
    Console.WriteLine("It goes like this:");
    Console.Write(FibNum + "," + FibNum1);

    /*
    Fibonacci koden som jeg kun mildt hakkede fra internettet, jeg vidste godt hvordan koden burde virke, og at den burde være virkelig simpel,
    men blev forvirret af alt den anden kode rundt om, så ledte efter bekræftelse på mine storhjernede idéer på internettet
    */

    for(i=0;i<=FibbyMan;++i){

        FibNum2 = FibNum1 + FibNum;
        Console.Write("," + FibNum2);
        Thread.Sleep(500);
        FibNum = FibNum1;
        FibNum1 = FibNum2;
    }
    Console.WriteLine("");
    Console.WriteLine("Did you like the Fibonacci numbers?");
    Console.ReadLine();
    Console.WriteLine("Want the first 36 numbers again, but in longitude now?");
    string LongitudeTime = Console.ReadLine();

    if(LongitudeTime == "yes"){
        FibNum = 0; FibNum1 = 1; FibNum2 = i; //Resetter værdierne for fremtidig brug
        Console.WriteLine("GREAT! You had no choice anyways");
        Console.WriteLine("Here's the numbers:");
        Thread.Sleep(500);
        Console.WriteLine("0:     " + FibNum);
        Thread.Sleep(500);
        Console.WriteLine("1:     " + FibNum1);
        Thread.Sleep(500);
        
        for(i=2;i<FibbyMan;++i){
            FibNum2 = FibNum1 + FibNum;
            Console.WriteLine(i + ":     " + FibNum2);
            Thread.Sleep(500);
            FibNum = FibNum1;
            FibNum1 = FibNum2;
         }
    }
    else{
        Console.WriteLine("Too bad :(");
        Thread.Sleep(1000);
        Console.WriteLine("Here's some more numbers! :)");
        
        FibNum = 0; FibNum1 = 1; FibNum2 = i; //Resetter værdierne for fremtidig brug igen
        Thread.Sleep(500);
        Console.WriteLine("0:     " + FibNum);
        Thread.Sleep(500);
        Console.WriteLine("1:     " + FibNum1);
        Thread.Sleep(500);
        
        for(i=2;i<FibbyMan;++i){
            Console.Write(i + ":     ");
            FibNum2 = FibNum1 + FibNum;
            Console.WriteLine(FibNum2);
            Thread.Sleep(500);
            FibNum = FibNum1;
            FibNum1 = FibNum2;
         }
    }

Console.WriteLine("Thanks for looking at my numbers :D Now go away.");

Console.ReadLine();

