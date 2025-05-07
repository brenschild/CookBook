﻿namespace CookBookSolution.DataAccess;

public abstract class StringsRepository : IStringsRepository
{
    public List<string> Read(string filePath)
    {
        if (!File.Exists(filePath))
            return new List<String>();

        var fileContents = File.ReadAllText(filePath);
        return TextToStrings(fileContents);
    }

    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath, StringsToText(strings));
    }

    protected abstract string StringsToText(List<string> strings);
    protected abstract List<string> TextToStrings(string fileContents);
}
