using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SerializationPractice
{
    [Serializable]

    class Tutorial
    {
        public int ID;
        public String Name;

    }


    class Program
    {
        static void Main(string[] args)
        {
            Tutorial obj = new Tutorial();
            obj.ID = 1;
            obj.Name = ".Net";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"c:\ExampleNew.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();
        }
    }


    interface IMusic
    {
        void Play();
    }

    interface IGame
    {
        void Play();
    }

    class DoSomething : IMusic, IGame
    {
        void IMusic.Play()
        {
            //code
        }

        void IGame.Play()
        {
            //code
        }
    }

}
