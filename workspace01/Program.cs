
using System.Collections;
using System.Text;

/* https://stackoverflow.com/questions/10815565/which-is-better-array-arraylist-or-listt-in-terms-of-performance-and-speed
 List<T> generally seems to be preferred over arraylist. Arraylist seems be good for initial collection but after that
 makes sense to just use List<T> 
 
 Also when i went through...ArrayList are just annoying to convert to an different type!
 */


// Arraylist is generic (auto defined)
 ArrayList Merge(string word, string more) {
    ArrayList sentence = new ArrayList();
    foreach (var w in word)
        sentence.Add(w);
    foreach (var w in more)
        sentence.Add(w);
    return sentence;
 }
 
 //having this hurts
 string Print(ArrayList i) {
     StringBuilder s = new StringBuilder(i.Count);
     foreach (var c in i) {
         s.Append(c);
     }
     return s.ToString();
 }

// See https://aka.ms/new-console-template for more information <---- I hate this

 var value = Merge("hello","world");
 Console.WriteLine(Print(value));
