
string str = "i HAve nOt FAilEd. i'Ve JuSt FOund 10,000 wAYs THat wON't WOrK.";

static void correcting(string str)
{

    string tolower = str.ToLower();
    string[] split = tolower.Split();
    
    foreach(string item in split)
    {
        //Console.WriteLine(item);
        string remove = item.Remove(0,1);
        //Console.WriteLine(remove);
        string remove2 = item.Remove(1);
        //Console.WriteLine(remove2);
        string toupper = remove2.ToUpper();
        //Console.WriteLine(toupper);
        string replace = item.Replace(remove2, toupper);
        Console.WriteLine(replace);

    }
}

correcting(str);