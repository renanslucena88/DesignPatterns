﻿using System;

namespace Singleton
{
    public sealed class Singleton
    {
        //Create an object of the type Singleton 
        private static Singleton conn = null;

        public static Singleton GetInstance
        {
            get
            {
                if (conn == null)
                {
                    conn = new Singleton();
                    Console.WriteLine("******************* INSTANTIATED ************************");
                }
                return conn;

            }
        }

        public void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
