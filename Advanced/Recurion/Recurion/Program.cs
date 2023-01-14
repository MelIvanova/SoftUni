using System.Data;

namespace Recurion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] maze = new string[4, 6];
            string[] arguments = { "0", "1", "0", "0", "0", "1", "0", "1", "0", "1", "0", "E", "0", "1",
                "0", "1", "0", "0", "0", "0", "0", "0", "0", "0" };
            maze = FillUp(maze, arguments);
            string path = "";
            int row = 0;
            int col = 0;
            FindeAllPaths(maze, new bool[maze.GetLength(0), maze.GetLength(1)],path, row, col);
        }

        private static void FindeAllPaths(string[,] maze, bool[,] visited,
            string path, int row, int col)
        {
            if (maze[row,col]=="E")
            {
                Console.WriteLine(path);
                return;
            }
            visited[row, col] = true;

            if (IsSafe(maze, row+1, col, visited))
            {
                FindeAllPaths(maze, visited, path+"D", row +1, col);
            }
            if (IsSafe(maze, row-1, col, visited))
            {
                FindeAllPaths(maze, visited, path+"U", row -1, col);
            }
            if (IsSafe(maze, row, col+1, visited))
            {
                FindeAllPaths(maze, visited, path+"R", row, col+1);
            }
            if (IsSafe(maze, row, col-1, visited))
            {
                FindeAllPaths(maze, visited, path+"L", row, col - 1);
            }

            visited[row, col] = false;
        }

        private static bool IsSafe(string[,] maze, int row, int col, bool[,] visited)
        {
            if (row < 0 || row >= maze.GetLength(0) || col < 0 || col >= maze.GetLength(1))
            {
                return false;
            }
            if (maze[row,col]=="1" || visited[row,col])
            {
                return false;
            }
            
            return true;
        }

        private static string[,] FillUp(string[,] maze, string[] arguments)
        {
            int index = 0;
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int coll = 0; coll < maze.GetLength(1); coll++)
                {
                    maze[row, coll] = arguments[index++];
                }
            }

            return maze;
        }
    }
}