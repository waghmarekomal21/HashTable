namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a option.\n1.Ability to Find Frequency of Large in a Sentence like “To be or not to be.\n2.Ability to Find Frequency of Words in a Large Paragraph Phrase.\n3.Remove Avoidable word from the Phrase");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (option)
            {
                case 1:
                    HashTable1<string, int> hashtable1 = new HashTable1<string, int>(6);
                    string words = "to be or not to be";
                    string[] arr = words.Split(' ');
                    LinkedList<string> linklist1 = new LinkedList<string>();
                    foreach (string element in arr)
                    {
                        int count12 = 0;
                        foreach (string match in arr)
                        {
                            if (element == match)
                            {
                                count12++;
                                if (linklist1.Contains(element))
                                {
                                    break;
                                }
                            }
                        }
                        if (linklist1.Contains(element))
                        {
                            continue;
                        }
                        linklist1.AddLast(element);
                        hashtable1.Add(element, count12);
                    }
                    Console.WriteLine("Frequency of the word");
                    hashtable1.Display();
                    break;
                case 2:
                    HashTable2<string, int> hashtable2 = new HashTable2<string, int>(6);
                    string large = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    string[] largearray = large.Split(' ');
                    LinkedList<string> linklist = new LinkedList<string>();
                    foreach (string element in largearray)
                    {
                        int count = 0;
                        foreach (string match in largearray)
                        {
                            if (element == match)
                            {
                                count++;
                                if (linklist.Contains(element))
                                {
                                    break;
                                }
                            }
                        }
                        if (linklist.Contains(element))
                        {
                            continue;
                        }
                        linklist.AddLast(element);
                        hashtable2.Add(element, count);
                    }
                    Console.WriteLine("Frequency of the word");
                    hashtable2.Display();
                    break;
                case 3:
                    HashTable3<string, int> hash = new HashTable3<string, int>(6);
                    string remove = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    string[] removearray = remove.Split(' ');
                    LinkedList<string> checkForDuplication = new LinkedList<string>();
                    foreach (string element in removearray)
                    {
                        int count = 0;
                        foreach (string match in removearray)
                        {
                            if (element == match)
                            {
                                count++;
                                if (checkForDuplication.Contains(element))
                                {
                                    break;
                                }
                            }
                        }
                        if (checkForDuplication.Contains(element))
                        {
                            continue;
                        }
                        checkForDuplication.AddLast(element);
                        hash.Add(element, count);
                    }
                    Console.WriteLine("Frequency of the word");
                    hash.Display();
                    int freq = hash.Get("avoidable");
                    Console.WriteLine("Frequency of the word Avoidable: " + freq);
                    hash.Remove("avoidable");
                    freq = hash.Get("avoidable");
                    Console.WriteLine("Frequency of the word Avoidable after removing: " + freq);
                    //hash.Display();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
