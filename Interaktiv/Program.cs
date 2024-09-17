Console.WriteLine("Du kommer hem efter skolan och är ganska trött men du har basket träning och måste gå om två timmar, vad väljer du att äta eller sova?");
string choice = Console.ReadLine();

if (choice == "äta")
{
    Console.WriteLine("Du äter och du är inte lika trött som du va innan du åt.");
    Console.WriteLine("Nu har du lite tid över för att plugga inför ett prov du har imorgon innan du går och tränar,");
    Console.WriteLine("vad väljer du plugga eller sova");
}
else if (choice == "sova")
{
    Console.WriteLine("Du väljer att sova men du vaknar upp 40 min innan din träning,");
    Console.WriteLine("vilket betyder att du kommer komma lite sent,");
    Console.WriteLine("väljer du att gå eller stanna hemma?");
}

choice = Console.ReadLine(); 
choice = choice.ToLower(); 

if (choice == "plugga")
{
    Console.WriteLine("Du väljer att plugga inför provet");
    Console.WriteLine("och du hinner till din basket träningen och så får du bra betyg på ditt prov.");
}
else if (choice == "sova")
{
    Console.WriteLine("Du väljer att sova och vila upp dig innan träningen istället för att plugga,");
    Console.WriteLine("så du har en bra träning eftersom du vilade upp dig,");
    Console.WriteLine("men du blev inte helt förberd för provet och fick inget bra betyg på det.");
}
else if (choice == "gå")
{
    Console.WriteLine("Du väljer att gå men eftersom du kom sent så får du som straff att springa i tio minuter.");
    Console.WriteLine("Men efter att du har sprungit i tio minuter så har du en gnaska bra träning,");
    Console.WriteLine("men eftersom du inte pluggade så fick du inte bra betyg på ditt prov du hade dagen efter.");
}
else if (choice == "stanna hemma")
{
    Console.WriteLine("Du väljer att stanna hemma och skippa träningen.");
    Console.WriteLine("Eftersom du inte gick på träningen så får du inte spela matchen på helgen");
    Console.WriteLine("Men du stannade hemma och pluggade eftersom du inte hade nått annat att göra så du fick bra betyg på ditt prov.");
}




Console.ReadLine();
