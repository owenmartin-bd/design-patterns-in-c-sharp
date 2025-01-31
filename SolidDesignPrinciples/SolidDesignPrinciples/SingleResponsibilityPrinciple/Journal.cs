using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciples.SingleResponsibilityPrinciple;

internal class Journal
{
    private readonly List<string> entries = [];
    private static int count = 0;

    public int AddEntry(string text)
    {
        entries.Add($"{++count}: {text}");
        return count; // memento pattern!
    }

    public void RemoveENtry(int index)
    {
        entries.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, entries);
    }
}
