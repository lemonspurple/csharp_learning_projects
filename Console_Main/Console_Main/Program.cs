namespace Console_Main;
class Program
{
    static void Main(string[] args)
    {
        

char valueToDetect = 's';

string[] words = { "aLorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy",
"eirmod atempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et",
"accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem"};

string[] words2 = { "aLorem aipsum adolor asit aamet, consetetur asadipscing elitr, sed diam nonumy",
"eirmod atempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et",
"accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem"};


DoesItStartWithX.LoopThatDetectsIfSomethingStartsWithX(words2, valueToDetect);
DoesItStartWithX.LoopThatDetectsIfSomethingStartsWithX(words2, 'a');






























    }
}
