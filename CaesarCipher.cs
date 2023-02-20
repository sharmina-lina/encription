using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.WriteLine("Write your message");
      string message = Console.ReadLine();
      //Console.WriteLine(message);
      char[] secretMessage = message.ToCharArray();
      char[] encryptedMessage = new char[message.Length];
      for ( int i = 0; i< secretMessage.Length; i++ ){
        char letter = secretMessage[i];
        int letterPosition = Array.IndexOf(alphabet,letter);
      int newPosition = (letterPosition+3)% alphabet.Length;
      char newLetter = alphabet[newPosition];
      encryptedMessage[i] =newLetter;
 }
    string msgString = String.Join("",encryptedMessage);
      Console.WriteLine(msgString);
      
    }
  }
}
