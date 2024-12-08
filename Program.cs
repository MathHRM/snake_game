using System;

class Program
{
    public static bool gameOver;
    public static int score = 0;
    public static int width = 20;
    public static int height = 20;
    public static int x, y, fruitX, fruitY;
    public static int[] tailX = new int[100];
    public static int[] tailY = new int[100];
    public static int nTail = 0;
    public static Random random = new Random();
    public static bool stopping = false;
    public enum eDirection
    {
        STOP = 0,
        LEFT,
        RIGHT,
        UP,
        DOWN
    }
    public static eDirection dir;

    public static void Setup()
    {
        Console.Clear();
        x = width / 2;
        y = height / 2;
        SetFruitPosition();
        gameOver = false;
        score = 0;
    }

    public static void Draw()
    {
        Console.Clear();
        bool printed = false;
        for (int i = 0; i < height + 1; i++)
        {
            for (int j = 0; j < width + 2; j++)
            {
                if (i == 0 || j == 0 || i == height || j == width + 1)
                {
                    Console.Write("#");
                }
                else if (x == j && y == i)
                {
                    Console.Write("O");
                }
                else if (fruitX == j && fruitY == i)
                {
                    Console.Write('@');
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public static void Input()
    {
        if (Console.KeyAvailable)
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.LeftArrow:
                    dir = eDirection.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    dir = eDirection.RIGHT;
                    break;
                case ConsoleKey.UpArrow:
                    dir = eDirection.UP;
                    break;
                case ConsoleKey.DownArrow:
                    dir = eDirection.DOWN;
                    break;
                case ConsoleKey.Escape:
                    gameOver = true;
                    break;
                default:
                    break;
            }
        }

    }

    public static void Logic()
    {
        switch (dir)
        {
            case eDirection.LEFT:
                x--;
                break;
            case eDirection.RIGHT:
                x++;
                break;
            case eDirection.UP:
                y--;
                break;
            case eDirection.DOWN:
                y++;
                break;
            default:
                break;
        }
    }

    public static void SetFruitPosition()
    {
        fruitX = random.Next(1, width);
        fruitY = random.Next(1, height);
    }

    static void Main(string[] args)
    {
        Setup();
        while (!gameOver)
        {
            Draw();
            Input();
            Logic();
            Thread.Sleep(100);
        }
    }
}
