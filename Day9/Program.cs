var lines = File.ReadAllLines(@"../../../input.txt");
var visited = new HashSet<string>();
visited.Add("0,0");
var currentHeadX = 0;
var currentHeadY = 0;
var currentPart1X = 0;
var currentPart1Y = 0;
var currentPart2X = 0;
var currentPart2Y = 0;
var currentPart3X = 0;
var currentPart3Y = 0;
var currentPart4X = 0;
var currentPart4Y = 0;
var currentPart5X = 0;
var currentPart5Y = 0;
var currentPart6X = 0;
var currentPart6Y = 0;
var currentPart7X = 0;
var currentPart7Y = 0;
var currentPart8X = 0;
var currentPart8Y = 0;
var currentTailX = 0;
var currentTailY = 0;

foreach (var line in lines)
{
    var split = line.Split(' ');
    switch (split[0])
    {
        case "U":
            for (var i = 0; i < Convert.ToInt32(split[1]); i++)
            {
                currentHeadY++;
                CheckIfPartNeedsToMove(currentHeadX, currentHeadY, ref currentPart1X, ref currentPart1Y);
                CheckIfPartNeedsToMove(currentPart1X, currentPart1Y, ref currentPart2X, ref currentPart2Y);
                CheckIfPartNeedsToMove(currentPart2X, currentPart2Y, ref currentPart3X, ref currentPart3Y);
                CheckIfPartNeedsToMove(currentPart3X, currentPart3Y, ref currentPart4X, ref currentPart4Y);
                CheckIfPartNeedsToMove(currentPart4X, currentPart4Y, ref currentPart5X, ref currentPart5Y);
                CheckIfPartNeedsToMove(currentPart5X, currentPart5Y, ref currentPart6X, ref currentPart6Y);
                CheckIfPartNeedsToMove(currentPart6X, currentPart6Y, ref currentPart7X, ref currentPart7Y);
                CheckIfPartNeedsToMove(currentPart7X, currentPart7Y, ref currentPart8X, ref currentPart8Y);
                CheckIfTailNeedsToMove(currentPart8X, currentPart8Y, currentTailX, currentTailY);
            }
            break;
        case "D":
            for (var i = 0; i < Convert.ToInt32(split[1]); i++)
            {
                currentHeadY--;
                CheckIfPartNeedsToMove(currentHeadX, currentHeadY, ref currentPart1X, ref currentPart1Y);
                CheckIfPartNeedsToMove(currentPart1X, currentPart1Y, ref currentPart2X, ref currentPart2Y);
                CheckIfPartNeedsToMove(currentPart2X, currentPart2Y, ref currentPart3X, ref currentPart3Y);
                CheckIfPartNeedsToMove(currentPart3X, currentPart3Y, ref currentPart4X, ref currentPart4Y);
                CheckIfPartNeedsToMove(currentPart4X, currentPart4Y, ref currentPart5X, ref currentPart5Y);
                CheckIfPartNeedsToMove(currentPart5X, currentPart5Y, ref currentPart6X, ref currentPart6Y);
                CheckIfPartNeedsToMove(currentPart6X, currentPart6Y, ref currentPart7X, ref currentPart7Y);
                CheckIfPartNeedsToMove(currentPart7X, currentPart7Y, ref currentPart8X, ref currentPart8Y);
                CheckIfTailNeedsToMove(currentPart8X, currentPart8Y, currentTailX, currentTailY);
            }
            break;
        case "L":
            for (var i = 0; i < Convert.ToInt32(split[1]); i++)
            {
                currentHeadX--;
                CheckIfPartNeedsToMove(currentHeadX, currentHeadY, ref currentPart1X, ref currentPart1Y);
                CheckIfPartNeedsToMove(currentPart1X, currentPart1Y, ref currentPart2X, ref currentPart2Y);
                CheckIfPartNeedsToMove(currentPart2X, currentPart2Y, ref currentPart3X, ref currentPart3Y);
                CheckIfPartNeedsToMove(currentPart3X, currentPart3Y, ref currentPart4X, ref currentPart4Y);
                CheckIfPartNeedsToMove(currentPart4X, currentPart4Y, ref currentPart5X, ref currentPart5Y);
                CheckIfPartNeedsToMove(currentPart5X, currentPart5Y, ref currentPart6X, ref currentPart6Y);
                CheckIfPartNeedsToMove(currentPart6X, currentPart6Y, ref currentPart7X, ref currentPart7Y);
                CheckIfPartNeedsToMove(currentPart7X, currentPart7Y, ref currentPart8X, ref currentPart8Y);
                CheckIfTailNeedsToMove(currentPart8X, currentPart8Y, currentTailX, currentTailY);
            }
            break;
        case "R":
            for (var i = 0; i < Convert.ToInt32(split[1]); i++)
            {
                currentHeadX++;
                CheckIfPartNeedsToMove(currentHeadX, currentHeadY, ref currentPart1X, ref currentPart1Y);
                CheckIfPartNeedsToMove(currentPart1X, currentPart1Y, ref currentPart2X, ref currentPart2Y);
                CheckIfPartNeedsToMove(currentPart2X, currentPart2Y, ref currentPart3X, ref currentPart3Y);
                CheckIfPartNeedsToMove(currentPart3X, currentPart3Y, ref currentPart4X, ref currentPart4Y);
                CheckIfPartNeedsToMove(currentPart4X, currentPart4Y, ref currentPart5X, ref currentPart5Y);
                CheckIfPartNeedsToMove(currentPart5X, currentPart5Y, ref currentPart6X, ref currentPart6Y);
                CheckIfPartNeedsToMove(currentPart6X, currentPart6Y, ref currentPart7X, ref currentPart7Y);
                CheckIfPartNeedsToMove(currentPart7X, currentPart7Y, ref currentPart8X, ref currentPart8Y);
                CheckIfTailNeedsToMove(currentPart8X, currentPart8Y, currentTailX, currentTailY);
            }
            break;
    }
}
Console.WriteLine($"Result: {visited.Count}");

void CheckIfPartNeedsToMove(int headX, int headY, ref int tailX, ref int tailY)
{
    //check diagonals
    //top right
    if ((headX - tailX > 1 && headY - tailY == 1) ||
        (headX - tailX == 1 && headY - tailY > 1 ) ||
        (headX - tailX > 1 && headY - tailY > 1 ))
    {
        tailX++;
        tailY++;
    }
    //top left
    else if((headX - tailX < -1 && headY - tailY == 1) ||
            (headX - tailX == -1 && headY - tailY > 1) ||
            (headX - tailX < -1 && headY - tailY > 1))
    {
        tailX--;
        tailY++;
    }

    //bottom right
    else if((headX - tailX > 1 && headY - tailY == -1) ||
            (headX - tailX == 1 && headY - tailY < -1) ||
            (headX - tailX > 1 && headY - tailY < -1))
    {
        tailX++;
        tailY--;
    }

    //bottom left
    else if((headX - tailX < -1 && headY - tailY == -1) ||
            (headX - tailX == -1 && headY - tailY < -1) ||
            (headX - tailX < -1 && headY - tailY < -1))
    {
        tailX--;
        tailY--;
    }

    //check cardinals
    //up
    else if(headY - tailY > 1)
    {
        tailY++;
    }

    //down
    else if(headY - tailY < -1)
    {
        tailY--;
    }

    //left
    else if(headX - tailX < -1)
    {
        tailX--;
    }

    //right
    else if(headX - tailX > 1)
    {
        tailX++;
    }
}

void CheckIfTailNeedsToMove(int headX, int headY, int tailX, int tailY)
{
    //check diagonals
    //top right
    if ((headX - tailX > 1 && headY - tailY == 1) ||
        (headX - tailX == 1 && headY - tailY > 1) ||
        (headX - tailX > 1 && headY - tailY > 1))
    {
        currentTailX++;
        currentTailY++;
        visited.Add($"{currentTailX},{currentTailY}");
    }
    //top left
    else if((headX - tailX < -1 && headY - tailY == 1) ||
            (headX - tailX == -1 && headY - tailY > 1) ||
            (headX - tailX < -1 && headY - tailY > 1))
    {
        currentTailX--;
        currentTailY++;
        visited.Add($"{currentTailX},{currentTailY}");
    }

    //bottom right
    else if((headX - tailX > 1 && headY - tailY == -1) ||
            (headX - tailX == 1 && headY - tailY < -1) ||
            (headX - tailX > 1 && headY - tailY < -1))
    {
        currentTailX++;
        currentTailY--;
        visited.Add($"{currentTailX},{currentTailY}");
    }

    //bottom left
    else if((headX - tailX < -1 && headY - tailY == -1) ||
            (headX - tailX == -1 && headY - tailY < -1) ||
            (headX - tailX < -1 && headY - tailY < -1))
    {
        currentTailX--;
        currentTailY--;
        visited.Add($"{currentTailX},{currentTailY}");
    }

    //check cardinals
    //up
    else if(headY - tailY > 1)
    {
        currentTailY++;
        visited.Add($"{currentTailX},{currentTailY}");
    }

    //down
    else if(headY - tailY < -1)
    {
        currentTailY--;
        visited.Add($"{currentTailX},{currentTailY}");
    }

    //left
    else if(headX - tailX < -1)
    {
        currentTailX--;
        visited.Add($"{currentTailX},{currentTailY}");
    }

    //right
    else if(headX - tailX > 1)
    {
        currentTailX++;
        visited.Add($"{currentTailX},{currentTailY}");
    }
}