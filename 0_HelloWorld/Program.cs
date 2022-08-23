string val;
int res;
int result;
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

//Liste som jeg ikke har brugt til noget

var impostor = new List<string>();
impostor.Add("Island Boi");
impostor.Add("WallBoi");
impostor.Add("Epstein didn't kill himself");
impostor.Add("Not a Sussy Baka");
impostor.Add(null);

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

    bool continueLoop = true;
    while(continueLoop){

    String theBigQuestion = Console.ReadLine();

    switch(theBigQuestion){
        case "Island Boi":
        Console.WriteLine("----------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Island Boi");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Was Ejected");
        Console.WriteLine("----------------------------------------------------");
        Thread.Sleep(2000);
        Console.WriteLine("...");
        Console.ForegroundColor = ConsoleColor.Blue;
        Thread.Sleep(2000);
        Console.Write("Island Boi");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Was Not The Impostor");
        /* 
        Originalt var "Why did you vote theBigQuestion ..." ude for switchen, så den ville aktivere uanset hvem du valgte
        Dog virkede det ikke længere da jeg satte while(true) funktionen på da theBigQuestion ville blive sat ud af de originale brackets
        Så nu har jeg gjort tingene på en mindre effektiv måde :)
        */
        Thread.Sleep(1000);
        Console.WriteLine("Why did you vote " + theBigQuestion + " if he wasn't the Impostor?");
        continueLoop = false;
        break;
        case "WallBoi":
        Console.WriteLine("----------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("WallBoi");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Was Ejected");
        Console.WriteLine("----------------------------------------------------");
        Thread.Sleep(2000);
        Console.WriteLine("...");
        Console.ForegroundColor = ConsoleColor.Red;
        Thread.Sleep(2000);
        Console.Write("WallBoi");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Was Not The Impostor");
        Thread.Sleep(1000);
        Console.WriteLine("Why did you vote " + theBigQuestion + " if he wasn't the Impostor?");
        continueLoop = false;
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
        Thread.Sleep(1000);
        Console.WriteLine("Why did you vote " + theBigQuestion + " if he wasn't the Impostor?");
        continueLoop = false;
        break;
        case ("Not a Sussy Baka"):
        Console.WriteLine("----------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("Not a Sussy Baka");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Was Ejected");
        Console.WriteLine("----------------------------------------------------");
        Thread.Sleep(2000);
        Console.WriteLine("...");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Thread.Sleep(2000);
        Console.Write("Not a Sussy Baka");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Was Not The Impostor");
        Thread.Sleep(1000);
        continueLoop = false;
        Console.WriteLine("Why did you vote " + theBigQuestion + " if he wasn't the Impostor?");
        break;
        default:
        Console.WriteLine("Try and write the name of another player, nerd");
        break;
    }
    
 }

}
else
{
    Console.WriteLine("So what you're saying is that you're the impostor?");
    Thread.Sleep(1000);
    Console.WriteLine("Welp, bye then");
    for (int i = 10; i > 0; i--){
        Thread.Sleep(1000);
        Console.WriteLine(i);
    }
    Console.WriteLine("----------------------------------------------------");
        Console.WriteLine(bigBoiName + " was ejected");
        Console.WriteLine("----------------------------------------------------");
        Thread.Sleep(1000);
    Console.Write(bigBoiName);
    Thread.Sleep(2000);
    Console.Write(" was");
    Thread.Sleep(2000);
    Console.WriteLine(" the Impostor Among Us");
    Console.ReadLine();
    Environment.Exit(0);
}
Continue:
Console.ReadLine();
Thread.Sleep(1000);
Console.WriteLine("Good Point!");
Thread.Sleep(1000);
Console.WriteLine("But you're still sus, so answer my riddle and we'll decide your fate");
Thread.Sleep(1000);
Console.WriteLine("----------------------------------------------------");
Thread.Sleep(1000);
Console.Write("what ");
Thread.Sleep(1000);
Console.Write("is "); 
Thread.Sleep(1000);
Random rnd = new Random();
int num1 = rnd.Next(1, 32000);
Console.Write(num1);
Thread.Sleep(1000);
Console.Write(" * ");
Thread.Sleep(1000);
int num2 = rnd.Next(1, 32000);
Console.WriteLine(num2 + "?");
int value = Convert.ToInt32(Console.ReadLine());


if(num1 * num2 == value){

    Console.WriteLine("L+Ratio+UrBald");
    Thread.Sleep(2000);
    Console.WriteLine("Also we don't trust anyone who can do that calculation, so we'll just eject you");

}
else{
    Console.WriteLine("Bruh");
    Thread.Sleep(2000);
    Console.WriteLine("Imagine not being able to do simple math.");
    Thread.Sleep(1000);
    Console.WriteLine("We're gonna eject you now.");
}
Thread.Sleep(1000);
 Console.WriteLine("----------------------------------------------------");
        Console.WriteLine(bigBoiName + " was ejected");
        Console.WriteLine("----------------------------------------------------");
        Thread.Sleep(1000);
    Console.Write(bigBoiName);
    Thread.Sleep(2000);
    Console.Write(" was");
    Thread.Sleep(2000);
    Console.WriteLine(" the Impostor Among Us");

for (int i = 3; i > 0; i--){
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
    }
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Hello there!");
Console.WriteLine("I'm the void :)");
Console.WriteLine("My friends call me Jeff though, so just call me that");
Console.WriteLine("Would you be interested in seeing my list of my favorite Moviestars?");
Console.ForegroundColor = ConsoleColor.White;
string BigJeffLove = Console.ReadLine();
if(BigJeffLove == "yes"){
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("AWESOME!");
List<string> actors = new List<string>(5);
actors.Add("Ryan Reynolds");
actors.Add("Donald Trump");
actors.Add("Elon Musk");
actors.Add("Will Smith (Post Slap)");
foreach (string a in actors)
Console.WriteLine(a);
Console.ForegroundColor = ConsoleColor.White;
Thread.Sleep(1000);
Console.WriteLine("You made Jeff Happy! Big Success");

}
else{

    Thread.Sleep(1000);
    Console.Write("You made Jeff cry");
    Thread.Sleep(1000);
    Console.WriteLine("He offered you friendship, and you gave him pain.");
    Thread.Sleep(1000);
    Console.Write("You better be happy...");
    Thread.Sleep(2000);
    Console.WriteLine("Bitch");
    Environment.Exit(0);
}


Console.ReadLine();