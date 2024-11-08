using System.ComponentModel;

namespace GenericCollections
{
    public class Word
    {
        public string English { get; set; }
        public List<string> French { get; set; }
    }
    public class FrenchDictionary
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        public FrenchDictionary(Word[] arr)
        {
            for(int i = 0;i < arr.Length;i++)
                dict.Add(arr[i].English, arr[i].French);
        }

        public void Add(string key, string value)
        {
            if (dict.ContainsKey(key))
            {
                dict[key].Add(value); 
            }
            else
            {
                dict.Add(key, new List<string> { value });
            }
        }


        public void Remove(string key)
        {
            dict.Remove(key);
        }

        public void Print()
        {
            foreach (var entry in dict) 
            {
                string englishWord = entry.Key; 
                List<string> frenchWords = entry.Value; 

                Console.WriteLine($"English word: {englishWord} - French translations: {string.Join(", ", frenchWords)}");
            }
        }

        public void RemoveOneTranslation(string key,string value)
        {
            if (dict.ContainsKey(key))
                dict[key].Remove(value);
        }

        public void ChangeEnglishWord(string key)
        {
            if (dict.ContainsKey(key))
            {
                Console.WriteLine("New english word:");
                string newEnglish = Console.ReadLine();

                List<string> french = dict[key];

                dict.Remove(key);
                dict.Add(newEnglish, french);
            }
        }

        public void ChangeTranslation(string key,string value)
        {
            if (dict.ContainsKey(key))
            {
                if (dict[key].Contains(value))
                {
                    Console.WriteLine("Change translation:");
                    
                    string newTranslation = Console.ReadLine();
                    dict[key].Remove(value);
                    dict[key].Add(newTranslation);
                }
            }
        }

        public void SearchWord(string key)
        {
            if (dict.ContainsKey(key)){
                Console.WriteLine($"Translations:{string.Join("", dict[key])}");
            }
        }
    }
}
