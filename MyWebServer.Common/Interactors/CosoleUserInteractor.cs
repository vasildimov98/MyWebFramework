﻿namespace MyWebFramework.Common.Interactors 
{
    public class CosoleUserInteractor : IUserInteractor
    {
        public void AddNewline()
        {
            Console.WriteLine();
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}