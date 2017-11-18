using System;
using System.Globalization;
using System.Linq;

public class TodoItem
{
    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }

    // Example: 123456-H
    // Example: 123456-M
    // Example: 123456-L
    public string TaskPriority { get; set; }

    private readonly char[] _validCategories = { 'H', 'M', 'L' };
    private const int CategoryLength = 8;
    private const int NumberLength = 6;

    public bool IsValid()
    {
        if (TaskPriority is null)
        {
            throw new ArgumentNullException(paramName: nameof(TaskPriority));
        }

        if (TaskPriority.Length != CategoryLength)
        {
            return false;
        }

        var numberPart = TaskPriority.Substring(0, NumberLength);
        if (!int.TryParse(numberPart, NumberStyles.None, null, out int _))
        {
            return false;
        }

        var schemeIdentifier = TaskPriority.Last();
        return _validCategories.Contains(schemeIdentifier);
    }

}