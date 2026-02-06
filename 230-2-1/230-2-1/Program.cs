namespace _230_2_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter yearly income: ");

            double income = 0.0;
            string strIncome = Console.ReadLine();

            try
            {

                income = double.Parse(strIncome);

                // From $1.00 to $4461.99 - Nil

                if (income >= 1.00 && income <= 4461.99)
                {
                    Console.WriteLine("Tax total: $0.00");
                }

                // From $4462.00 to $17 893.99 - Nil plus 30 cents for each $ in excess of $4462.00

                else if (income >= 4462.00 && income <= 17893.99)
                {

                    double taxTotal = 0.30 * (income - 4462.00);
                    Console.WriteLine("Tax total: {0:C}", taxTotal);

                }

                // From $17 894.00 to $29 499.99 - $4119.00 plus 35 cents for each $ in excess of $17 894.00 

                else if (income >= 17894.00 && income <= 29499.99)
                {

                    double taxTotal = 0.35 * (income - 17894.00) + 4119.00;
                    Console.WriteLine("Tax total: {0:C}", taxTotal);

                }

                // From $29 500.00 to $45 787.99 - $8656.00 plus 46 cents for each $ in excess of $29 500.00

                else if (income >= 29500.00 && income <= 45787.99)
                {

                    double taxTotal = 0.46 * (income - 29500.00) + 8656;
                    Console.WriteLine("Tax total: {0:C}", taxTotal);

                }

                // $45 788.00 and over - $11 179.00 plus 60 cents for each $ in excess of $45 788.00

                else if (income >= 45788.00)
                {

                    double taxTotal = 0.60 * (income - 45788.00) + 11179;
                    Console.WriteLine("Tax total: {0:C}", taxTotal);

                }

                // Other

                else
                {

                    Console.WriteLine("Please enter a value over $0.99 to use tax calculator.");

                }

                // Print out the output with a label and the corresponding amount

            }


            catch (FormatException)
            {

                Console.WriteLine("Please enter a number for taxable income.");

            }


        }
    }

}


