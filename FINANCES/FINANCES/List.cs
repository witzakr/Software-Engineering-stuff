using System;

public class ListItem
{
    public string? Name { get; set; }
    public decimal Amount { get; set; }

    public override string ToString()
    {
        return $"{Name}: {Amount:C}";
    }
}
