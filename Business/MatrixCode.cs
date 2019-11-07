namespace Business
{
    public class MatrixCode
    {
        public static int[,] GetBinaryMatrixNumber(int number)
        {
            switch (number)
            {
                case 0:

                    return new int[,] {
                            { 0, 1, 0 },
                            { 1, 0, 1 },
                            { 0, 0, 0 },
                            { 1, 0, 1 },
                            { 0, 1, 0 }};

                case 1:

                    return new int[,] {
                            { 0, 0, 0 },
                            { 0, 0, 1 },
                            { 0, 0, 0 },
                            { 0, 0, 1 },
                            { 0, 0, 0 }};

                case 2:

                    return new int[,] {
                            { 0, 1, 0 },
                            { 0, 0, 1 },
                            { 0, 1, 0 },
                            { 1, 0, 0 },
                            { 0, 1, 0 }};

                case 3:

                    return new int[,] {
                            { 0, 1, 0 },
                            { 0, 0, 1 },
                            { 0, 1, 0 },
                            { 0, 0, 1 },
                            { 0, 1, 0 }};

                case 4:

                        return new int[,] {
                            { 0, 0, 0 },
                            { 1, 0, 1 },
                            { 0, 1, 0 },
                            { 0, 0, 1 },
                            { 0, 0, 0 }};

                case 5:

                        return new int[,] {
                            { 0, 1, 0 },
                            { 1, 0, 0 },
                            { 0, 1, 0 },
                            { 0, 0, 1 },
                            { 0, 1, 0 }};

                case 6:

                        return new int[,] {
                            { 0, 1, 0 },
                            { 1, 0, 0 },
                            { 0, 1, 0 },
                            { 1, 0, 1 },
                            { 0, 1, 0 }};

                case 7:

                        return new int[,] {
                            { 0, 1, 0 },
                            { 0, 0, 1 },
                            { 0, 1, 0 },
                            { 0, 0, 1 },
                            { 0, 0, 0 }};

                case 8:

                        return new int[,] {
                            { 0, 1, 0 },
                            { 1, 0, 1 },
                            { 0, 1, 0 },
                            { 1, 0, 1 },
                            { 0, 1, 0 }};

                case 9:

                        return new int[,] {
                            { 0, 1, 0 },
                            { 1, 0, 1 },
                            { 0, 1, 0 },
                            { 0, 0, 1 },
                            { 0, 1, 0 }};

                default:

                        return new int[,]  {
                            { 0, 0, 0 },
                            { 0, 0, 0 },
                            { 0, 0, 0 },
                            { 0, 0, 0 },
                            { 0, 0, 0 }};
            }
        }
    }
}
