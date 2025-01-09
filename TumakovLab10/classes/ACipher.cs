using HomeWork9.interfaces;

namespace HomeWork9.classes;

// Создать класс ACipher, реализующий интерфейс ICipher. Класс шифрует строку посредством сдвига
// каждого символа на одну «алфавитную» позицию выше.
public class ACipher : ICipher
{
    public string Encode(string input)
    {
        char[] encoded = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char letter = input[i];
            if (char.IsLetter(letter))
            {
                if (letter == 'Я') encoded[i] = 'А';
                else if (letter == 'я') encoded[i] = 'а';
                else encoded[i] = (char)(letter + 1);
            }
            else
            {
                encoded[i] = letter; 
            }
        }
        return new string(encoded);
    }
    public string Decode(string input)
    {
        char[] decoded = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char letter = input[i];
            if (char.IsLetter(letter))
            {
                if (letter == 'А') decoded[i] = 'Я';
                else if (letter == 'а') decoded[i] = 'я';
                else decoded[i] = (char)(letter - 1);
            }
            else
            {
                decoded[i] = letter; 
            }
        }
        return new string(decoded);
    }
}
