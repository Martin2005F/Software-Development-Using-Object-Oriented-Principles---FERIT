using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Classes
{
    public class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random generator;

        private MatrixGenerator()
        {
            this.generator = new Random();
        }

        public static MatrixGenerator GetInstance()
        {
            if(instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }

        public double[][] FillMatrix(int rows, int columns)
        {
            double[][] matrix = new double[rows][];

            for(int i=0; i<rows; i++)
            {
                matrix[i] = new double[columns];

                for (int j = 0; j < columns; j++) {
                    matrix[i][j] = this.generator.NextDouble(); 
                }
            }

            return matrix;
        }

    }
}
