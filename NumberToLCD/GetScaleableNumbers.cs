namespace NumberToLCD
{
    public class GetScaleableNumbers
    {
        public string[] GetScaledNine(int numberHeight, int numberWidth)
        {
            List<string> nine = new();
            for (int i = 0; i < numberHeight; i++)
            {
                for (int j = 0; j < numberWidth; j++)
                {
                    if (i == 0 || i == (numberHeight - 1) || i == (numberHeight / 2))
                    {
                        if (j == 0 || j == (numberWidth - 1))
                        {
                            nine.Add(" ");
                        }
                        else
                        {
                            nine.Add("_");
                        }
                    }
                    else if (j == (numberWidth - 1) || (j == 0 && i < (numberHeight / 2)))
                    {
                        nine.Add("|");
                    }
                    else
                    {
                        nine.Add(" ");
                    }
                }
                nine.Add("%");
            }
            string nineAsJoinedString = string.Join("", nine);
            string[] ListOfNineElements = nineAsJoinedString.Split(new char[] { '%' });
            return ListOfNineElements;
        }

        public string[] GetScaledEight(int numberHeight, int numberWidth)
        {
            List<string> eight = new();
            for (int i = 0; i < numberHeight; i++)
            {
                for (int j = 0; j < numberWidth; j++)
                {
                    if (i == 0 || i == (numberHeight - 1) || i == (numberHeight / 2))
                    {
                        if (j == 0 || j == (numberWidth - 1))
                        {
                            eight.Add(" ");
                        }
                        else
                        {
                            eight.Add("_");
                        }
                    }
                    else if (j == (numberWidth - 1) || j == 0)
                    {
                        eight.Add("|");
                    }
                    else
                    {
                        eight.Add(" ");
                    }
                }
                eight.Add("%");
            }
            string eightAsJoinedString = string.Join("", eight);
            string[] ListOfEightElements = eightAsJoinedString.Split(new char[] { '%' });
            return ListOfEightElements;
        }

        public string[] GetScaledSeven(int numberHeight, int numberWidth)
        {
            List<string> seven = new();
            for (int i = 0; i < numberHeight; i++)
            {
                for (int j = 0; j < numberWidth; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0 || j == (numberWidth - 1))
                        {
                            seven.Add(" ");
                        }
                        else
                        {
                            seven.Add("_");
                        }
                    }
                    else if (j == (numberWidth - 1))
                    {
                        seven.Add("|");
                    }
                    else
                    {
                        seven.Add(" ");
                    }
                }
                seven.Add("%");
            }
            string sevenAsJoinedString = string.Join("", seven);
            string[] ListOfSevenElements = sevenAsJoinedString.Split(new char[] { '%' });
            return ListOfSevenElements;
        }

        public string[] GetScaledSix(int numberHeight, int numberWidth)
        {
            List<string> six = new();
            for (int i = 0; i < numberHeight; i++)
            {
                for (int j = 0; j < numberWidth; j++)
                {
                    if (i == 0 || i == (numberHeight - 1) || i == (numberHeight / 2))
                    {
                        if (j == 0 || j == (numberWidth - 1))
                        {
                            six.Add(" ");
                        }
                        else
                        {
                            six.Add("_");
                        }
                    }
                    else if (j == 0 || (j == (numberWidth - 1) && i > (numberHeight / 2)))
                    {
                        six.Add("|");
                    }
                    else
                    {
                        six.Add(" ");
                    }
                }
                six.Add("%");
            }
            string sixAsJoinedString = string.Join("", six);
            string[] ListOfSixElements = sixAsJoinedString.Split(new char[] { '%' });
            return ListOfSixElements;
        }

        public string[] GetScaledFive(int numberHeight, int numberWidth)
        {
            List<string> five = new();
            for (int i = 0; i < numberHeight; i++)
            {
                for (int j = 0; j < numberWidth; j++)
                {
                    if (i == 0 || i == (numberHeight - 1) || i == (numberHeight / 2))
                    {
                        if (j == 0 || j == (numberWidth - 1))
                        {
                            five.Add(" ");
                        }
                        else
                        {
                            five.Add("_");
                        }
                    }
                    else if (j == 0 && i < (numberHeight / 2))
                    {
                        five.Add("|");
                    }
                    else if (j == (numberWidth - 1) && i > (numberHeight / 2))
                    {
                        five.Add("|");
                    }
                    else
                    {
                        five.Add(" ");
                    }
                }
                five.Add("%");
            }
            string fiveAsJoinedString = string.Join("", five);
            string[] ListOfFiveElements = fiveAsJoinedString.Split(new char[] { '%' });
            return ListOfFiveElements;
        }

        public string[] GetScaledFour(int numberHeight, int numberWidth)
        {
            List<string> four = new();
            for (int i = 0; i < numberHeight; i++)
            {
                for (int j = 0; j < numberWidth; j++)
                {
                    if (i == (numberHeight / 2))
                    {
                        if (j == 0 || j == (numberWidth - 1))
                        {
                            four.Add(" ");
                        }
                        else
                        {
                            four.Add("_");
                        }
                    }
                    else if ((j == (numberWidth - 1) || (j == 0 && i < (numberHeight / 2))) && i != 0)
                    {
                        four.Add("|");
                    }
                    else
                    {
                        four.Add(" ");
                    }
                }
                four.Add("%");
            }
            string fourAsJoinedString = string.Join("", four);
            string[] ListOfFourElements = fourAsJoinedString.Split(new char[] { '%' });
            return ListOfFourElements;
        }

        public string[] GetScaledThree(int numberHeight, int numberWidth)
        {
            List<string> three = new();
            for (int i = 0; i < numberHeight; i++)
            {
                for (int j = 0; j < numberWidth; j++)
                {
                    if (i == 0 || i == (numberHeight - 1) || i == (numberHeight / 2))
                    {
                        if (j == 0 || j == (numberWidth - 1))
                        {
                            three.Add(" ");
                        }
                        else
                        {
                            three.Add("_");
                        }
                    }
                    else if (j == (numberWidth - 1))
                    {
                        three.Add("|");
                    }
                    else
                    {
                        three.Add(" ");
                    }
                }
                three.Add("%");
            }
            string threeAsJoinedString = string.Join("", three);
            string[] ListOfThreeElements = threeAsJoinedString.Split(new char[] { '%' });
            return ListOfThreeElements;
        }

        public string[] GetScaledTwo(int numberHeight, int numberWidth)
        {
            List<string> two = new();
            for (int i = 0; i < numberHeight; i++)
            {
                for (int j = 0; j < numberWidth; j++)
                {
                    if (i == 0 || i == (numberHeight - 1) || i == (numberHeight / 2))
                    {
                        if (j == 0 || j == (numberWidth - 1))
                        {
                            two.Add(" ");
                        }
                        else
                        {
                            two.Add("_");
                        }
                    }
                    else if (j == 0 && i > (numberHeight / 2))
                    {
                        two.Add("|");
                    }
                    else if (j == (numberWidth - 1) && i < (numberHeight / 2))
                    {
                        two.Add("|");
                    }
                    else
                    {
                        two.Add(" ");
                    }
                }
                two.Add("%");
            }
            string twoAsJoinedString = string.Join("", two);
            string[] ListOfTwoElements = twoAsJoinedString.Split(new char[] { '%' });
            return ListOfTwoElements;
        }

        public string[] GetScaledOne(int numberHeight, int numberWidth)
        {
            List<string> one = new();
            for (int i = 0; i < numberHeight; i++)
            {
                for (int j = 0; j < numberWidth; j++)
                {
                    if (j == (numberWidth / 2) && i != 0)
                    {
                        one.Add("|");
                    }
                    else
                    {
                        one.Add(" ");
                    }
                }
                one.Add("%");
            }
            string oneAsJoinedString = string.Join("", one);
            string[] ListOfOneElements = oneAsJoinedString.Split(new char[] { '%' });
            return ListOfOneElements;
        }

        public string[] GetScaledZero(int numberHeight, int numberWidth)
        {
            List<string> zero = new();
            for (int i = 0; i < numberHeight; i++)
            {
                for (int j = 0; j < numberWidth; j++)
                {
                    if (i == 0 || i == (numberHeight - 1))
                    {
                        if (j == 0 || j == (numberWidth - 1))
                        {
                            zero.Add(" ");
                        }
                        else
                        {
                            zero.Add("_");
                        }
                    }
                    else if (j == 0 || j == (numberWidth - 1))
                    {
                        zero.Add("|");
                    }
                    else
                    {
                        zero.Add(" ");
                    }
                }
                zero.Add("%");
            }
            string zeroAsJoinedString = string.Join("", zero);
            string[] ListOfZeroElements = zeroAsJoinedString.Split(new char[] { '%' });
            return ListOfZeroElements;
        }
    }
}