using System.Security.Cryptography.X509Certificates;

namespace CollectionHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
          
            string[] words =
                   Console.ReadLine()
                       .Split(" ", StringSplitOptions.RemoveEmptyEntries);


            int removeCnt = int.Parse(Console.ReadLine());


            IAddCollection<string> addCollection = new AddCollection<string>(); 
            IAddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();   
            IMyList<string> myList = new MyList<string>();


            AddToCollection(words, addCollection);
            AddToCollection(words, addRemoveCollection);
            AddToCollection(words, myList);


            RemoveFromCollection(removeCnt, addRemoveCollection);
            RemoveFromCollection(removeCnt, myList);


        }

        public static void AddToCollection(string[] words, IAddCollection<string> collection)
        {
            foreach (string word in words)
            {
                Console.Write(collection.Add(word) + " ");
            }

            Console.WriteLine();
        }


        public static void RemoveFromCollection(int removeCnt, IAddRemoveCollection<string> collection)
        {
            for (int i = 0; i < removeCnt; i++)
            {
                Console.Write(collection.Remove() + " ");
            }

            Console.WriteLine();
        }
    }
}
