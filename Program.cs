string input;
bool weapon = false;

Console.WriteLine("Welcome to the Adventure Game!");
Console.WriteLine("==============================");
Console.WriteLine("As an avid traveler, you have decided to visit the Catacombs of Paris.");
Console.WriteLine("However, during your exploration, you find yourself lost.");
Console.WriteLine("You can choose to walk in multiple directions to find a way out.");
Console.WriteLine("Let's start with your name: ");
string name = Console.ReadLine()!;
Console.WriteLine($"Good luck {name}");
IntroScene();

void IntroScene()
{
    Console.WriteLine("You are at a crossroads, and you can choose to go down any of the four hallways. Where would you like to go? ");
    Console.WriteLine("Options: north/east/south/west ");
    input = Console.ReadLine()!;
    if (input == "west")
    {
        ShowShadowFigure();
    }
    else if (input == "south")
    {
        HauntedRoom();
    }
    else if (input == "east")
    {
        ShowSkeletons();
    }
    else if (input == "north")
    {
        Portal();
    }
}

void ShowShadowFigure()
{
    Console.WriteLine("You see a dark shadowy figure appear in the distance. You are creped out. Where would you like to go? ");
    Console.WriteLine("Options: north/east/south ");
    input = Console.ReadLine()!;

    if (input == "north")
    {
        CameraScene();
    }
    else if (input == "south")
    {
        Portal();
    }
    else if (input == "east")
    {
        IntroScene();
    }
    else if (input == "west")
    {
        while (input == "west")
        {
            Console.WriteLine("Invalid input, try again!");
            input = Console.ReadLine()!;
        }
    }
}

void CameraScene()
{
    Console.WriteLine("You see a camera that has been dropped on the ground. Someone has been here recently. Where would you like to go? ");
    Console.WriteLine("Options: north/south ");
    input = Console.ReadLine()!;

    if (input == "north")
    {
        Free();
    }
    else if (input == "south")
    {
        ShowShadowFigure();
    }
    else if (input == "east" || input == "west")
    {
        while (input == "east" || input == "west")
        {
            Console.WriteLine("Invalid input, try again!");
            input = Console.ReadLine()!;
        }
    }

}

void HauntedRoom()
{
    Console.WriteLine("You hear strange voices. You think you have awoken some of the dead. Where would you like to go? ");
    Console.WriteLine("Options: north/east/west ");
    input = Console.ReadLine()!;

    if (input == "north")
    {
        IntroScene();
    }
    else if (input == "south")
    {
        while (input == "south")
        {
            Console.WriteLine("Invalid input, try again!");
            input = Console.ReadLine()!;
        }
    }
    else if (input == "east")
    {
        Free();
    }
    else if (input == "west")
    {
        DeadRoomWestOfHauntedRoom();
    }

}

void ShowSkeletons()
{
    Console.WriteLine("You see a wall of skeletons as you walk into the room. Someone is watching you. Where would you like to go? ");
    Console.WriteLine("Options: north/east/west ");
    input = Console.ReadLine()!;

    if (input == "north")
    {
        DeadEndWithWeapon();
    }
    else if (input == "south")
    {
        while (input == "south")
        {
            Console.WriteLine("Invalid input, try again!");
            input = Console.ReadLine()!;
        }
    }
    else if (input == "east")
    {
        StrangeCreature();
    }
    else if (input == "west")
    {
        IntroScene();
    }

}

void DeadRoomWestOfHauntedRoom()
{
    Console.WriteLine("Multiple Ghoul-like creatures start emerging as you enter the room. You are killed. ");
    Console.WriteLine(" Your are dead! Do you want to try again? yes/no ");
    input = Console.ReadLine()!;
    if (input == "yes")
    {
        IntroScene();
    }
    else if (input == "no")
    {
        return;
    }
}

void Portal()
{
    Console.WriteLine("Its portal! ");
    Console.WriteLine("Options:north/south ");
    input = Console.ReadLine()!;

    if (input == "north")
    {
        ShowSkeletons();
    }
    else if (input == "south")
    {
        ShowShadowFigure();
    }
    else if (input == "east" || input == "west")
    {
        while (input == "east" || input == "west")
        {
            Console.WriteLine("Invalid input, try again!");
            input = Console.ReadLine()!;
        }
    }
}

void DeadEndWithWeapon()
{
    Console.WriteLine("You find that this door opens into a wall. You open some of the drywall to discover a knife. ");
    Console.WriteLine("Options: north/east/west ");
    input = Console.ReadLine()!;

    weapon = true;
    if (input == "north")
    {
        Console.WriteLine("You have been in this room before! ");
        while (input == "north")
        {
            Console.WriteLine("Invalid input, try again!");
            input = Console.ReadLine()!;
        }
    }
    else if (input == "east")
    {
        StrangeCreature();
    }
    else if (input == "west")
    {
        IntroScene();
    }
}

void Free()
{
    Console.WriteLine("You are free! Do you want to try it again? yes/no ");
    input = Console.ReadLine()!;
    if (input == "yes")
    {
        IntroScene();
    }
    else if (input == "no")
    {
        return;
    }
}

void StrangeCreature()
{
    Console.WriteLine("A strange Ghoul-like creature has appeared. You can either run or fight it. What would you like to do? ");
    Console.WriteLine("Options:fight/flee");
    input = Console.ReadLine()!;

    if (input == "flee")
    {
        ShowSkeletons();
    }
    else if (input == "fight")
    {
        if (weapon == true)
        {
            Console.WriteLine("You kill the ghoul with the knife you found earlier.");
            Console.WriteLine("Options:west/south");
            input = Console.ReadLine()!;
            if (input == "south")
            {
                Free();
            }
            else if (input == "west")
            {
                ShowSkeletons();
            }
            else if (input == "east" || input == "north")
            {
                while (input == "north" || input == "east")
                {
                    Console.WriteLine("Invalid input, try again!");
                    input = Console.ReadLine()!;
                }
            }
        }
        else if (weapon == false)
        {
            Console.WriteLine(" Your are dead! Do you want to try again? yes/no ");
            input = Console.ReadLine()!;
            if (input == "yes")
            {
                IntroScene();
            }
            else if (input == "no")
            {
                return;
            }
        }
    }
}

