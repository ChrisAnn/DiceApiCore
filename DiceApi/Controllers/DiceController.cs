using System;
using Microsoft.AspNetCore.Mvc;

namespace DiceApi.Controllers
{
    public class DiceController : Controller
    {
        private readonly Random _random = new Random();
        
        public int Get(int i)
        {
            return _random.Next(1, i);
        }
    }
}