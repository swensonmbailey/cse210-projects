using System;

class Program
{
    static void Main(string[] args)
    {
        List<string[]> scripturePassages = new List<string[]>();
        scripturePassages.Add(new string[] {"And as Moses lifted up the serpent in the wilderness, even so must the Son of man be lifted up: That whosoever believeth in him should not perish, but have eternal life. For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.", "John 3: 14-16"});

        scripturePassages.Add(new string[] {"To him that overcometh will I grant to sit with me in my throne, even as I also overcame, and am set down with my Father in his throne.", "Revelation 3: 21"});

        scripturePassages.Add(new string[] {"I glory in plainness; I glory in truth; I glory in my Jesus, for he hath redeemed my soul from hell.", "2Nephi 33: 6"});

        scripturePassages.Add(new string[] {"And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.", "Mosiah 2: 41"});
    
        Random rand = new Random();
            
        string[] scripturePicked;

        int index = scripturePassages.Count -1;

        while(true)
        {
        
            
            scripturePicked = scripturePassages[index];

            if(index == 0)
            {
                index = scripturePassages.Count -1;
            }else
            {
                index--;
            }

            Console.WriteLine("Do you want to memorize this scripture?");
            
            Console.WriteLine($"{scripturePicked[1]} \n {scripturePicked[0]}");
            
            string response;

            do
            {
                Console.Write("Enter 'y' or 'n': ");
                response = Console.ReadLine().ToLower();
            }
            while(response != "y" && response != "n");
            
            Console.Clear();

            if(response == "y"){
                break;
            }

        }

        Scripture scripture = new Scripture(scripturePicked[0], scripturePicked[1]);
        
        string input;
        do
        {
            scripture.DisplayScripture();
            input = Console.ReadLine();

            if(input != "quit")
            {
                bool allHidden;
                allHidden = scripture.HideWord();

                if(allHidden)
                {
                    break;
                }
            }
        }
        while(input != "quit");

    }    
}