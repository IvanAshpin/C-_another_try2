Console.Write("Enter a coordX: ");
int coordX = int.Parse(Console.ReadLine()!);
Console.Write("Enter a coordY: ");
int coordY = int.Parse(Console.ReadLine()!);
if(coordX > 0 && coordY > 0){Console.WriteLine("I coordinate quarter");}
if(coordX < 0 && coordY > 0){Console.WriteLine("II coordinate quarter");}
if(coordX < 0 && coordY < 0){Console.WriteLine("III coordinate quarter");}
if(coordX > 0 && coordY < 0){Console.WriteLine("VI coordinate quarter");}

// if(!coordX && !coordY){Console.WriteLine("on the x or y axis");}