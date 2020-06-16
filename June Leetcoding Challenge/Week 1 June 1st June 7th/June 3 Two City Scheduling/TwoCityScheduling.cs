        public class Solution
        {
            public int TwoCitySchedCost(int[][] costs)
            {
                int cheapest;
                int count = costs.GetLength(0);
                sorting candidates = new sorting(costs, count);
                cheapest = candidates.balance(costs, count);
                return cheapest;
            }
        }

        public class Person
        {
            public int cityA;
            public int cityB;
            public int dif;
            public int min;
            public char minCity;

            public Person(int a, int b)
            {
                cityA = a;
                cityB = b;
                dif = Math.Abs(a - b);
                min = Math.Min(a, b);
                if (a < b)
                {
                    minCity = 'a';
                }
                else
                    minCity = 'b';
            }
        }

        public class sorting
        {
            public List<Person> people = new List<Person>();
            public int[] min;
            public char[] corCity;
            public int[] alts;
            public char betterCity;
            public int betterCityCount;
            public List<int> minAlts = new List<int>();
            public int peopleCount;
            public int x = 0;

            public sorting(int[][] costs, int count)
            {
                peopleCount = count;
                min = new int[count];
                corCity = new char[count];
                alts = new int[count];

                for (int i = 0; i < count; ++i)
                {
                    people.Add(new Person(costs[i][0], costs[i][1]));
                    min[i] = people[i].min;
                    corCity[i] = people[i].minCity;
                    alts[i] = people[i].dif;
                }


                for (var i = 0; i < count; ++i)
                {
                    if (corCity[i] == 'a')
                        ++x;
                }

                if (x > count / 2)
                {
                    betterCity = 'a';
                    betterCityCount = x;
                }
                else
                {
                    betterCity = 'b';
                    betterCityCount = count - x;
                }
                
                if (betterCity == 'a')
                {
                    for (var i = 0; i < count; ++i)
                    {
                        if(corCity[i] == 'a')
                            minAlts.Add(alts[i]);
                    }
                }

                if (betterCity == 'b')
                {
                    for (var i = 0; i < count; ++i)
                    {
                        if(corCity[i] == 'b')
                            minAlts.Add(alts[i]);
                    }
                }
            }
            public int balance(int[][] costs, int count)
            {
                var sum = min.Sum();
                while (betterCityCount > peopleCount / 2)
                {
                    sum += minAlts.Min();
                    minAlts.Remove(minAlts.Min());
                    --betterCityCount;
                }
                return sum;
            }
        }