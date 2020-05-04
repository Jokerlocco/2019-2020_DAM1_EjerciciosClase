//Pablo Conde - 01/05/2020
//Reto 4.03 - Vestigium (Google Code Jam 2020, Problem 1)

/*
Problem

Vestigium means "trace" in Latin. In this problem we work with Latin squares 
and matrix traces.

The trace of a square matrix is the sum of the values on the main diagonal 
(which runs from the upper left to the lower right).

An N-by-N square matrix is a Latin square if each cell contains one of N 
different values, and no value is repeated within a row or a column. In this 
problem, we will deal only with "natural Latin squares" in which the N values 
are the integers between 1 and N.

Given a matrix that contains only integers between 1 and N, we want to compute 
its trace and check whether it is a natural Latin square. To give some 
additional information, instead of simply telling us whether the matrix is a 
natural Latin square or not, please compute the number of rows and the number 
of columns that contain repeated values.

Input

The first line of the input gives the number of test cases, T. T test cases 
follow. Each starts with a line containing a single integer N: the size of the 
matrix to explore. Then, N lines follow. The i-th of these lines contains N 
integers Mi,1, Mi,2 ..., Mi,N. Mi,j is the integer in the i-th row and j-th 
column of the matrix.

Output

For each test case, output one line containing Case #x: k r c, where x is the 
test case number (starting from 1), k is the trace of the matrix, r is the 
number of rows of the matrix that contain repeated elements, and c is the 
number of columns of the matrix that contain repeated elements.

Sample

Input
 	
3
4
1 2 3 4
2 1 4 3
3 4 1 2
4 3 2 1
4
2 2 2 2
2 3 2 3
2 2 2 3
2 2 2 2
3
2 1 3
1 3 2
1 2 3

Output
  
Case #1: 4 0 0
Case #2: 9 4 4
Case #3: 8 0 2

*/


using System;
using System.Collections.Generic;

class Vistigium
{
    static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        int trace, repRows, repCols;

        for (int numCases = 1; numCases <= cases; numCases++)
        {
            int matrixSize = Convert.ToInt32(Console.ReadLine());
            int[,] myMatrix = new int[matrixSize, matrixSize];

            trace = 0;
            repRows = 0;
            repCols = 0;

            for (int row = 0; row < matrixSize; row++)
            {
                List<int> rowList = new List<int>();
                string[] readingRow = Console.ReadLine().Split(' ');

                for (int col = 0; col < matrixSize; col++)
                {
                    myMatrix[row, col] = Convert.ToInt32(readingRow[col]);

                    if (!rowList.Contains(myMatrix[row, col]))
                     rowList.Add(myMatrix[row, col]);
                    if (row == col)
                        trace += myMatrix[row, col];   
                }
                if(rowList.Count != matrixSize)
                    repRows ++;
            }

            int[,] myMatrixT = new int[matrixSize, matrixSize];
            
            //Transponsed matrix
            for (int row = 0; row < matrixSize; row++)
            {
                List<int> colList = new List<int>();
       
                for (int col = 0; col < matrixSize; col++)
                {
                    myMatrixT[row, col] = myMatrix[col, row];

                    if (!colList.Contains(myMatrixT[row, col]))
                        colList.Add(myMatrixT[row, col]);
                }
                if(colList.Count != matrixSize)
                    repCols ++;
            }

            Console.WriteLine("Case #" + numCases + ": " + trace + " " 
                + repRows + " " + repCols);
        }
    }
}
