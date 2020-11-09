using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeExample
{
    //    Given a matrix consists of 0 and 1, find the distance of the nearest 0 for each cell.
    
    //The distance between two adjacent cells is 1.
    
    //Example 1:
    
    //Input:
    //[[0,0,0],
    // [0,1,0],
    // [0,0,0]]
    // Output:
    //[[0,0,0],
    // [0,1,0],
    // [0,0,0]]

    public class Matrix01
    {
        private class Point
        {
            public int x { get; set; }
            public int y { get; set; }
            public int val { get; set; }

            public Point(int x, int y, int val)
            {
                this.x = x;
                this.y = y;
                this.val = val;
            }
        }

        // bread first aproatch of solvint the problem
        public int[][] UpdateMatrix(int[][] matrix)
        {
            bool[,] visited = new bool[matrix.Length, matrix[0].Length];
            Queue<Point> queuePoints = PutInitialVariablesInQueue(ref matrix, ref visited);

            while (queuePoints.Count != 0)
            {
                Point point = queuePoints.Dequeue();
                CheckAndPutPointsInQueue(point.x, point.y, point.val + 1, ref queuePoints, ref visited, ref matrix);
            }

            return matrix;
        }

        // proces of functionality UpdateMatrix -->  PutInitiealVariablesInQueue --> CheckAndPutPointsInQueue --> PutInQueue
        // then we go back to UpdateMatrix 
        // UpdateMatrix --> CheckAndPutPointsInQueue --> PutInQueue;


        // Looks at the initial points around the 0-s
        private Queue<Point> PutInitialVariablesInQueue(ref int[][] matrix, ref bool[,] visited)
        {
            Queue<Point> queuePoints = new Queue<Point>();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        CheckAndPutPointsInQueue(i, j, 1, ref queuePoints, ref visited, ref matrix);
                    }
                }
            }

            return queuePoints;
        }

        // Looks around the specific points to put the points in queue
        private void CheckAndPutPointsInQueue(int i, int j, int val, ref Queue<Point> queuePoints, ref bool[,] visited, ref int[][] matrix)
        {
            if (i > 0 && matrix[i - 1][j] == 1 && visited[i - 1, j] == false)
            {
                PutInQueue(i - 1, j, val, ref queuePoints, ref visited, ref matrix);
            }
            if (i < matrix.Length - 1 && matrix[i + 1][j] == 1 && visited[i + 1, j] == false)
            {
                PutInQueue(i + 1, j, val, ref queuePoints, ref visited, ref matrix);
            }
            if (j > 0 && matrix[i][j - 1] == 1 && visited[i, j - 1] == false)
            {
                PutInQueue(i, j - 1, val, ref queuePoints, ref visited, ref matrix);
            }
            if (j < matrix[i].Length - 1 && matrix[i][j + 1] == 1 && visited[i, j + 1] == false)
            {
                PutInQueue(i, j + 1, val, ref queuePoints, ref visited, ref matrix);
            }
        }

        // just makes the final 
        private void PutInQueue(int i, int j, int val, ref Queue<Point> queuePoints, ref bool[,] isVisited, ref int[][] matrix)
        {
            isVisited[i, j] = true;
            queuePoints.Enqueue(new Point(i, j, val));
            matrix[i][j] = val;
        }
    }
}
