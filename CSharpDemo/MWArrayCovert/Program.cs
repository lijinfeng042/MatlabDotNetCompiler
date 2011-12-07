using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using TypeConvert;

namespace MWArrayCovert {
    class Program {
        static void Main(string[] args) {

            MWArray In=null;
            MWArray Out=null;
            try {
                DiffTpye testMethod=new DiffTpye(); //创建一个实例
                In=4;//此处发生隐式转换

                //double数组
                Out=testMethod.magicDouble(In);
                Console.WriteLine("The doubleArray result is :\n{0}\n",(MWNumericArray)Out);

                //char数组
                Out=testMethod.magicChar(In);
                Console.WriteLine("The CharArray result is :\n{0}\n",Out);

                //cell数组
                Out=testMethod.magicCell(In);
                //Return Out.ToArray()
                //    {object[1, 1]}
                //      [0, 0]: {double[4, 4]}

                Console.WriteLine("The CellArray result is :\n{0}\n",Out);
               //Return ((MWCellArray)Out).ToArray().GetValue(0,0) 
               //{double[4, 4]}

                //struct数组
                Out=testMethod.magicStruct(In);

                Console.WriteLine("The StructArray result is :\n{0}",((MWStructArray)Out).GetField("value"));
                //Return ((MWStructArray)Out).GetField("value").ToArray()
                //   {double[4, 4]}
            } catch(Exception e) {
                Console.WriteLine(e);

            } finally {
                Console.Read();
            }
        }
    }
}
