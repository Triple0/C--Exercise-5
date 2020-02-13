using System;
using System.Collections.Generic;

namespace CSharp_Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome!!");
            var userList = new List<string>{"Pineapple","Red","Four","Apple","Peach","Original", "Mickey","Mango","Strawberry", "Lemon"};
            var shortList = new List<string>();
            var longList = new List<string>();
            
            string temp1;
            //userList.Sort();
            for(int i = 0; i < 10; i++){
                for(int j = 0; j < 10-1; j++){
                    if (userList[j].Length > userList[j+1].Length){
                        temp1 = userList[j];
                        userList[j] = userList[j+1];
                        userList[j+1] = temp1;   

                    //shortList.Add(userList[i]);
                    }
                }             
            
            }
            //shortList = userList.Reverse();
            for(int i = 0; i < 5; i++){
                shortList.Add(userList[i]);
            }

            for(int x = 5; x < 10; x++){
                longList.Add(userList[x]);
            }

            Console.WriteLine("********In User List*******");
            foreach(var y in userList){
                Console.WriteLine(y);
            }
            Console.WriteLine("********In Short List*******");
            for(int i = 0; i < 5; i++){
                Console.WriteLine("Index {0} is: {1}", i, shortList[i]);
            }
            Console.WriteLine("********In Long List*******");
            foreach(var y in longList){
                Console.WriteLine("Length {0} is: {1}", y.Length, y);
            }

        }
    }
}
