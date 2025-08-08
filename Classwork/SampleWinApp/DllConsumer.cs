using System;
using Samplelib;

//when u consume, u must add the refernce of the DLL into the application . DLLS cant run themselves , they must be part of the EXE
//right click on references and browse to location of dll and add it 
namespace SampleWinApp
{
    internal class DllConsumer
    {
        static void Main(string[] args)
        {
            var mathComp = new MathClass { FirstValue = 30, SecondValue = 24};
            var addRes = mathComp.addFunc();
            var subRes= mathComp.subFunc();
            var mulRes= mathComp.mulFunc();
            var divRes= mathComp.divFunc();
            Console.WriteLine($"add res:{addRes}, sub res:{subRes}, mul res;{mulRes}, div res:{divRes}");



        }
    }
}
