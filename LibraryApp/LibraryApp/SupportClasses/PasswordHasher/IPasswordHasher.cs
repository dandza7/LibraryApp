﻿namespace LibraryApp.SupportClasses.PasswordHasher
{
    public interface IPasswordHasher
    {
        string HashPassword(string password, out byte[] salt);
        bool VerifyPassword(string password, string hash, byte[] salt);
    }
}
