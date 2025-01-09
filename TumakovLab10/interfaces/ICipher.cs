namespace HomeWork9.interfaces;
// Создать интерфейс ICipher, который определяет методы поддержки шифрования строк.
// В интерфейсе объявляются два метода encode() и decode(), которые используются для шифрования и дешифрования строк
public interface ICipher 
{
    string Encode(string input); 
    string Decode(string input);
}
