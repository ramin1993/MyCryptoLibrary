# MyCryptoLibrary
A simple and efficient C# encryption library using AES-256.
This project is a simple encryption and decryption library written in C#.
var encryptedText = CryptoHelper.Encrypt("This is my library!", "mySecretKey");
var decryptedText = CryptoHelper.Decrypt(encryptedText, "mySecretKey");
Console.WriteLine(decryptedText); // This is my library!
