//Starten på amogus spil
Console.Title = "Real Amogus";
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("----------------------------------------------------");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("             The Impostors Among Us");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("----------------------------------------------------");
Thread.Sleep(1000);
Console.WriteLine("Type 'Start' to start the game");

string start = Console.ReadLine();

if (start == "Start"){
    Console.WriteLine("What's your name?");

}
else{
    Console.WriteLine(start + " That's not 'Start' D:");
    Console.ReadLine();
    Environment.Exit(0);
}

string bigBoiName = Console.ReadLine();
Console.WriteLine(bigBoiName + " are you the impostor amogus?");
string impostorMan = Console.ReadLine();

if(impostorMan == "no"){

    Console.Write("Well then " + bigBoiName + " who is it?");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(" Island Boi");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(", ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("WallBoi");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(", ");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("Epstein didn't kill himself");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" or ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Not a Sussy Baka");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("?");

    String theBigQuestion = Console.ReadLine();

    switch(theBigQuestion){
        case "Island Boi":
        Console.WriteLine("----------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Island Boi");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Was Ejected");
        Console.WriteLine("----------------------------------------------------");
        break;
        case "WallBoi":
        Console.WriteLine("----------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("WallBoi");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Was Ejected");
        Console.WriteLine("----------------------------------------------------");
        break;
        case "Epstein didn't kill himself":
        Console.WriteLine("----------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Epstein didn't kill himself");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Was Ejected [He still did not kill himself]");
        Console.WriteLine("----------------------------------------------------");
        Thread.Sleep(2000);
        Console.WriteLine("...");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Thread.Sleep(2000);
        Console.Write("Epstein didn't kill himself");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Was Not The Impostor");
        break;
        case ("Not a Sussy Baka"):
        Console.WriteLine("----------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("Not a Sussy Baka");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Was Ejected");
        Console.WriteLine("----------------------------------------------------");
        break;
        default:
        Console.WriteLine("Too bad I guess");
        Console.ReadLine();
        Environment.Exit(0);
        break;
    }
}

Console.ReadLine();