using HomeWork9.interfaces;

namespace HomeWork9.classes;

// Создать класс BCipher, реализующий интерфейс ICipher.
// Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й
// позиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца  алфавита.
public class BCipher : ICipher
{
    public string Encode(string input)
    {
        char[] encoded = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char letter = input[i];
            if (char.IsLetter(letter))
            {
                if (char.IsUpper(letter))
                {
                    encoded[i] = (char)('Я' - (letter - 'А'));
                }
                else
                {
                    encoded[i] = (char)('я' - (letter - 'а'));
                }
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
        return Encode(input);
    }
}
