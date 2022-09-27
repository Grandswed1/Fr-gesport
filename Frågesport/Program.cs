//Question 1: When did the MK1 tank enter battle for the first time?
//correct answe 1: 15 September 1916
//wrong answer 1: 12 october 1917
//wrong answer 1: 24 june 1914

//Question 2: What year did the Soviet Union collapse?
//correct answe 2: 26 december 1991
//wrong answer 2: 10 january 2000
//wrong answer 2: 19 may 1976

//Question 3: What year did Germany unite?
//correct answe 3: 3 october 1990
//wrong answer 3: 1 january 1933
//wrong answer 3: 10 september 1987

//Question 4: What year did D-Day take place?
//correct answe 4: 6 juni 1944
//wrong answer 4: 10 may 1942
//wrong answer 4: 17 september 1945

//Question 5: What is Swedens National Anthem?
//correct answe 5: Du Gamla Du Fria
//wrong answer 5: Das Deutschlandlied
//wrong answer 5: Karamelldansen 

//Question 6: what continent is Russia in?
//correct answe 6: Eurasia
//wrong answer 6: Europe
//wrong answer 6: Asia

int score = 0;

Console.WriteLine("Welcome to the most braindead quiz in the whole wide world. Here you will be asked about everything from tanks to countries");
Console.WriteLine("Press enter to proceed.");
Console.ReadLine();

Console.WriteLine("Now that you chose to proceed we will begin with the first question");
Console.WriteLine("Answer all questions in capital A,B or C.");
Console.WriteLine("When did the MK1 tank enter battle for the first time?");
Console.WriteLine("A) 24 June 1914");
Console.WriteLine("B) 15 September 1916");
Console.WriteLine("C) 12 October 1917");
string q1 = Console.ReadLine();



if (q1 == "B")
{
    Console.WriteLine("Congratulations. You picked the right one. Either you are super lucky or you are actually good. I think you still suck tho no matter what.");
    score = score + 1;
}
else if (q1 == "C")
{
    Console.WriteLine("Wow you are actually trash. How in the world did you just pick the wrong one. You are dumb.");
}
else if (q1 == "A")
{
    Console.WriteLine("Wow you are actually trash. How in the world did you just pick the wrong one. You are dumb.");
}
Console.WriteLine("Press enter to proceed");
Console.ReadLine();

Console.WriteLine("Now we go to the second question.");
Console.WriteLine("What year did the Soviet Union collapse?");
Console.WriteLine("A) 26 december 1991");
Console.WriteLine("B) 19 may 1976");
Console.WriteLine("C) 10 january 2000");
string q2 = Console.ReadLine();

if (q2 == "A")
{
    Console.WriteLine("Congratulations. You picked the right one. Either you are super lucky or you are actually good. I think you still suck tho no matter what.");
    score = score + 1;
}
else if (q2 == "B")
{
    Console.WriteLine("Wow you are actually trash. How in the world did you just pick the wrong one. You are dumb.");
}
else if (q2 == "C")
{
    Console.WriteLine("Wow you are actually trash. How in the world did you just pick the wrong one. You are dumb.");
}
Console.WriteLine("Press enter to proceed");
Console.ReadLine();

Console.WriteLine("Now we go to the third question.");
Console.WriteLine("What year did Germany unite?");
Console.WriteLine("A) 1 january 1933");
Console.WriteLine("B) 10 september 1987");
Console.WriteLine("C) 3 october 1990");
string q3 = Console.ReadLine();

if (q3 == "C")
{
    Console.WriteLine("Congratulations. You picked the right one. Either you are super lucky or you are actually good. I think you still suck tho no matter what.");
    score = score + 1;
}
else if (q3 == "A")
{
    Console.WriteLine("Wow you are actually trash. How in the world did you just pick the wrong one. You are dumb.");
}
else if (q3 == "B")
{
    Console.WriteLine("Wow you are actually trash. How in the world did you just pick the wrong one. You are dumb.");
}
Console.WriteLine("Press enter to proceed");
Console.ReadLine();

Console.WriteLine("Now we go to the fourth question.");
Console.WriteLine("What year did D-Day take place?");
Console.WriteLine("A) 6 juni 1944");
Console.WriteLine("B) 10 may 1942");
Console.WriteLine("C) 17 september 1945");
string q4 = Console.ReadLine();

if (q4 == "A")
{
    Console.WriteLine("Congratulations. You picked the right one. Either you are super lucky or you are actually good. I think you still suck tho no matter what.");
    score = score + 1;
}
else if (q4 == "B")
{
    Console.WriteLine("Wow you are actually trash. How in the world did you just pick the wrong one. You are dumb.");
}
else if (q4 == "C")
{
    Console.WriteLine("Wow you are actually trash. How in the world did you just pick the wrong one. You are dumb.");
}
Console.WriteLine("Press enter to proceed");
Console.ReadLine();

Console.WriteLine("Now we go to the fifth question.");
Console.WriteLine("What is Swedens National Anthem?");
Console.WriteLine("A) Karamelldansen");
Console.WriteLine("B) Du Gamla Du Fria");
Console.WriteLine("C) Das Deutschlandlied");
string q5 = Console.ReadLine();

if (q5 == "B")
{
    Console.WriteLine("Good you got the easiest one right. Congrats.");
    score = score + 1;
}
else if (q5 == "C")
{
    Console.WriteLine("This is just sad.... How did you get this one wrong. The other ones sure but this... Daym I feel bad for you....");
}
else if (q5 == "A")
{
    Console.WriteLine("Think your funny huh. Punk. Well you are dumb. Don't pick this. Damn dude....");
}
Console.WriteLine("Press enter to proceed");
Console.ReadLine();

Console.WriteLine("Now we go to the final question.");
Console.WriteLine("what continent is Russia in?");
Console.WriteLine("A) Asia");
Console.WriteLine("B) Europe");
Console.WriteLine("C) Eurasia");
string q6 = Console.ReadLine();

if (q6 == "C")
{
    Console.WriteLine("Congratulations. You picked the right one. Either you are super lucky or you are actually good. I think you still suck tho no matter what.");
    score = score + 1;
}
else if (q6 == "B")
{
    Console.WriteLine("Wow you are actually trash. How in the world did you just pick the wrong one. You are dumb.");
}
else if (q6 == "A")
{
    Console.WriteLine("Wow you are actually trash. How in the world did you just pick the wrong one. You are dumb.");
}
Console.WriteLine("Press enter to proceed");
Console.ReadLine();

Console.WriteLine("Welcome to the end. You made it. If you did bad as hell or pretty good only you know. I am but a messenger passing on to you what I have been told to say. Press enter to get your score....");
Console.ReadLine();

Console.WriteLine($"Here is your score child of the devil. your score is {score} / 6, congrats on this result. I would score better tho");
Console.ReadLine();


