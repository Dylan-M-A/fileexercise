using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace FileExercises
{
    internal class Game
    {
        //running the serialize class
        public void Run()
        {
            SerializeIO serialize = new SerializeIO();
            serialize.Run();
        }
    }
}
