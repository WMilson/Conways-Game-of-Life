using System;
using System.Data.Common;

namespace Life
{
    internal class Population
    {
        private static readonly Random Random = new Random();

        private readonly bool[,] cells;
        private readonly int size;

        public int Size
        {
            get { return size; }
        }

        public int InitialCount 
        { 
            get; 
            private set; 
        }

        public Population(int initialCount, int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size), "Размер поля должен быть положительным.");
            }

            if (initialCount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(initialCount), "Количество клеток не может быть отрицательным.");
            }

            this.size = size;
            this.InitialCount = initialCount;
            cells = new bool[size, size];
            PlaceRandomCells(initialCount);
        }

        // Приватный конструктор для создания следующего поколения из готового массива
        private Population(bool[,] cells)
        {
            this.cells = cells;
            size = cells.GetLength(0);
        }

        // индексатор - сахар синтаксический
        public bool this[int row, int column]
        {
            get { return cells[row, column]; }
            set { cells[row, column] = value; }
        }

        // можно вывести число соседей
        public Population CalculateNextState()
        {
            bool[,] next = new bool[size, size]; //

            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    int neighbors = CountNeighbors(row, column);
                    bool isAlive = cells[row, column];

                    bool willBeAlive = (isAlive && (neighbors == 2 || neighbors == 3)) ||
                                       (!isAlive && neighbors == 3);

                    next[row, column] = willBeAlive;
                }
            }

            return new Population(next);
        }

        public int CountNeighbors(int row, int column)
        {
            int neighbors = 0;

            for (int deltaRow = -1; deltaRow <= 1; deltaRow++)
            {
                for (int deltaColumn = -1; deltaColumn <= 1; deltaColumn++)
                {
                    if (deltaRow == 0 && deltaColumn == 0)
                    {
                        continue;
                    }
                    
                    int neighborRow = WrapIndex(row + deltaRow);
                    int neighborColumn = WrapIndex(column + deltaColumn);

                    if (cells[neighborRow, neighborColumn])
                    {
                        neighbors++;
                    }
                }
            }

            return neighbors;
        }

        private void PlaceRandomCells(int count)
        {
            if (count >= size * size)
            {
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                        cells[i, j] = true;

                return;
            }

            int placed = 0;
            while (placed < count)
            {
                int row = Random.Next(size);
                int column = Random.Next(size);

                if (!cells[row, column])
                {
                    cells[row, column] = true;
                    placed++;
                }
            }
        }

        private int WrapIndex(int index)
        {
            if (index < 0)
                return size - 1;

            if (index >= size)
                return 0;

            return index;
        }
    }
}