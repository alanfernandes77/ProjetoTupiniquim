using projeto_tupiniquim.Entities;

Console.Write("Area max size (X, Y): ");
string[] areaMaxPos = Console.ReadLine().Split(' ');
Area area = new(Convert.ToInt32(areaMaxPos[0]), Convert.ToInt32(areaMaxPos[1]));
Console.WriteLine();

Console.Write("Enter the number of robots you want to use: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= n; i++)
{
    Console.Write($"Robot ({i}) initial position (X, Y, Compass): ");
    string[] robotPos = Console.ReadLine().Split(' ');
    Robot robot = new(Convert.ToInt32(robotPos[0]), Convert.ToInt32(robotPos[1]), Convert.ToChar(robotPos[2]));

    Console.Write($"Commands for the robot ({i}): ");
    char[] commands = Console.ReadLine().ToUpper().ToCharArray();

    for (int j = 0; j < commands.Length; j++)
    {
        switch (commands[j])
        {
            case 'E':
                robot.MoveToLeft();
                break;

            case 'D':
                robot.MoveToRight();
                break;

            case 'M':
                robot.MoveForward();
                break;
        }
    }
    Console.WriteLine($"Coordinates of the robot ({i}): {robot}");
    Console.WriteLine();
}