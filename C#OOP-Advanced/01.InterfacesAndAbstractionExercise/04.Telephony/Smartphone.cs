using System;
using System.Text.RegularExpressions;
using _04.Telephony.Interfaces;

public class Smarthphone : ICallable, IBrowsable
{
    public string Call(string phoneNumber)
    {
        Regex regex = new Regex("^\\d+$");

        if (regex.IsMatch(phoneNumber))
        {
            return $"Calling... {phoneNumber}";
        }
        else
        {
            throw new ArgumentException("Invalid number!");
        }
    }

    public string Browse(string url)
    {
        Regex regex = new Regex("\\d");

        if (regex.IsMatch(url))
            throw new ArgumentException("Invalid URL!");
        else
        {
            return $"Browsing: {url}!";
        }
    }
}