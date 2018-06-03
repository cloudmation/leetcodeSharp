namespace Solutions
{
    using System;

    public class MaximalRectangle
    {
        public int MaximalBruteForce(char[,] matrix)
        {
            int maxArea = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == '0') continue;
                    maxArea = Math.Max(maxArea, this.GetMaxArea(matrix, i, j));
                }
            }

            return maxArea;
        }

        private int GetMaxArea(char[,] matrix, int upperX, int upperY)
        {
            int maxArea = 0;
            int boundX = matrix.GetLength(0);
            int boundY = matrix.GetLength(1);
            for (int i = upperX; i < boundX; i++)
            {
                for (int j = upperY; j < boundY; j++)
                {
                    if (matrix[i, j] == '0')
                    {
                        boundY = j;
                        j = upperY;
                        continue;
                    }

                    var rec = new Rectangle(upperX, upperY, i, j);
                    maxArea = Math.Max(maxArea, rec.Area());
                }
            }

            return maxArea;
        }

        public class Rectangle
        {
            public Rectangle(int upperX, int upperY, int lowerX, int lowerY)
            {
                this.upperX = upperX;
                this.upperY = upperY;
                this.lowerX = lowerX;
                this.lowerY = lowerY;
            }

            public int lowerX { get; set; }

            public int lowerY { get; set; }

            public int upperX { get; set; }

            public int upperY { get; set; }

            public int Area()
            {
                var area = (this.lowerY - this.upperY + 1) * (this.lowerX - this.upperX + 1);
                if (area > 0)
                {
                    // Console.WriteLine($"area:{area} coord: [{upperX},{upperY}], [{lowerX},{lowerY}]");
                    return area;
                }

                return 0;
            }
        }
    }
}