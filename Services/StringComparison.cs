using System.Text;

public class StringComparison
{
    private string lowerString = "felipe";
    private string upperString = "FELIPE";

    public bool CompareUsingEqualitySignalAndLowerOnce() => lowerString == upperString.ToLower();
    public bool CompareUsingEqualitySignalAndLowerBoth() => lowerString.ToLower() == upperString.ToLower();
    public bool CompareUsingEqualitySignalAndUpperOnce() => lowerString == upperString.ToUpper();
    public bool CompareUsingEqualitySignalAndUpperBoth() => lowerString.ToUpper() == upperString.ToUpper();
    public bool StringCompareMethodOrdinalIgnoreCase() => string.Compare(lowerString, upperString, System.StringComparison.OrdinalIgnoreCase) == 0;
    public bool StringCompareMethodCurrentCultureIgnoreCase() => string.Compare(lowerString, upperString, System.StringComparison.CurrentCultureIgnoreCase) == 0;
    public bool StringCompareMethodInvariantCultureIgnoreCase() => string.Compare(lowerString, upperString, System.StringComparison.InvariantCultureIgnoreCase) == 0;
    public bool CompareUsingEqualsMethodOrdinalIgnoreCase() => lowerString.Equals(upperString, System.StringComparison.OrdinalIgnoreCase);
    public bool CompareUsingEqualsMethodCurrentCultureIgnoreCase() => lowerString.Equals(upperString, System.StringComparison.CurrentCultureIgnoreCase);
    public bool CompareUsingEqualsMethodInvariantCultureIgnoreCase() => lowerString.Equals(upperString, System.StringComparison.InvariantCultureIgnoreCase);
}