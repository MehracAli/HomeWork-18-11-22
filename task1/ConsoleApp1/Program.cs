
string str = "haMisi ZEmaneDENDi";

static void correcting(string str)
{

    string tolower = str.ToLower();
    string[] split = tolower.Split();
    string words = string.Empty;
    
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
        //Console.WriteLine(replace);
        words += (replace+" ");
    }
    Console.WriteLine(words);
}

correcting(str);