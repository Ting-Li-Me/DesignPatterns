namespace ProxyPattern.Models
{
    using System;
    class AccessValidator
    {
        public bool Validate(string userId)
        {
            Console.WriteLine("Validating userId...");
            if (userId=="validUser")
            {
                Console.WriteLine($"{userId} is a valid user");
                return true;
            }
            else
            {
                Console.WriteLine($"{userId} is not a valid user");
                return false;
            }
        }
    }
}
