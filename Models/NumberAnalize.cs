using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberFun.Models
{
   
        public class NumberAnalize
        {
        public int num { get; set; }
        public NumberAnalize( int input)
            {
            num = input;
            }

            public bool isPerfect()
            {
                int sum = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        sum = sum + i;
                    }
                }
                if (sum == num)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool isPrime(int num)
            {
                int modCount = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        modCount++;
                    }
                }
                if (modCount == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            public bool isSquareful()
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        if (isPrime(i) == true)
                        {

                            if (num % (i * i) == 0)
                            {
                                return true;
                            }

                        }
                    }
                }
                return false;
            }

            public bool isSquarefull()
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        if (isPrime(i) == true)
                        {
                            if (num % (i * i) != 0)
                            {
                                return false;
                            }

                        }
                    }
                }
                return true;
            }

            public bool isPalindrome()
            {

                int remainder = 0;
                int reverse = 0;
                int temp = 0;

                temp =  num;
                while (num > 0)
                {
                    remainder = num % 10;
                    reverse = reverse * 10 + remainder;
                    num /= 10;
                }

                if (temp == reverse)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
        }
    }


