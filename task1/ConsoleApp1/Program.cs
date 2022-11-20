
string sentence = "i HAve nOt FAilEd. i'Ve JuSt FOund 10,000 wAYs THat wON't WOrK.";

static void ToUpFirstLetters(string sentence)
{

    string ToLowSentence = sentence.ToLower();
    string[] SplitSentence = ToLowSentence.Split();
    string Words = string.Empty;
    
    foreach(string item in SplitSentence)
    {
        //Console.WriteLine(item);
        string remove = item.Remove(0,1);
        //Console.WriteLine(remove);
        string FirstLetter = item.Remove(1);//0. index qalir.
        //Console.WriteLine(remove2);
        string ToUpFirstLetter = FirstLetter.ToUpper();//0. index boyuyur.
        //Console.WriteLine(toupper);
        string ReplaceLetters = item.Replace(FirstLetter, ToUpFirstLetter);//0. indexler yerlerini deyisir.
        //Console.WriteLine(replace);
        Words += (ReplaceLetters+" ");
    }
    Console.WriteLine(Words);
}

ToUpFirstLetters(sentence);