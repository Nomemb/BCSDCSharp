using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using _28Partial;


class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new /*_28Partial.*/Player();

        // partial 전부 사용가능
        NewPlayer.Func1();
        NewPlayer.Damage();
        NewPlayer.EventStart();
    }
}

