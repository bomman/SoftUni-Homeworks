using System;

class SpiralMatrix
{
    static void Main()
    {
        int sizeOfMatrix = int.Parse(Console.ReadLine());
        char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];
        string input = Console.ReadLine();
        string direction = "right";
        int index = 0;
        int row = 0; // row of matrix
        int col = 0; // colon of matrix

        for (int i = 0; i < sizeOfMatrix*sizeOfMatrix; i++)
        {
            if(direction == "right")
            {
                matrix[row, col] = input[index];
                index++;
                col++;
                if (col == sizeOfMatrix || matrix[row, col] != 0)
                {
                    col--;
                    
                    row++;
                    direction = "down";
                }
                if (index == input.Length)
                {
                    index = 0;
                }
            }
            else if(direction == "down")
            {
                matrix[row, col] = input[index];
                index++;
                row++;
                if (row == sizeOfMatrix || matrix[row, col] != 0)
                {
                    row--;
                   
                    col--;
                    direction = "left";
                }
                if (index == input.Length)
                {
                    index = 0;
                }
            }
            else if (direction == "left")
            {
                matrix[row, col] = input[index];
                index++;
                col --;
                if (col == -1 || matrix[row, col] != 0)
                {
                    row--;
                    
                    col++;
                    direction = "up";
                }
                if (index == input.Length)
                {
                    index = 0;
                }
            }
            else if (direction == "up")
            {
                matrix[row, col] = input[index];
                row--;
                index++;
                if (matrix[row, col] != 0)
                {
                    row++;
                    
                    col++;
                    direction = "right";
                }
                if (index == input.Length)
                {
                    index = 0;
                }

            }
            
           
        }

        int[] weightOfRow = new int[sizeOfMatrix];
        int max = 0;
        for (int line = 0; line < sizeOfMatrix ; line++)
        {
            for (int position = 0; position < sizeOfMatrix ; position++)
            {
                weightOfRow[line] += GetValueOfLetter(matrix[line, position]);
            }
            if(weightOfRow[line] > max)
            {
                row = line;
                max = weightOfRow[line];
            }

          
        }
        Console.WriteLine(row +  " " + "-" + " "  + max);



       
    }

    private static int GetValueOfLetter(char letter)
    {
        int alphabeticalNumber = 0;
        if(letter < 91)
        {
            alphabeticalNumber = (letter - 64) * 10;
        }
        else
        {
            alphabeticalNumber = (letter - 96) * 10;
        }
        return alphabeticalNumber;
    }
}

