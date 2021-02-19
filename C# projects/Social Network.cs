using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sololearn
{
  
  class Post
  {
    string model;  

    private Post()
    {
      model = "New post"; 
    }

    static void Main(string[] args)
    {
        string str;
        str= Console.ReadLine();
        Post Show= new Post();  
        Console.WriteLine(Show.model);  
        Console.Write("{0}\n", str);
    }
  }
}