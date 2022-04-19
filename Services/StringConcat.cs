using System.Text;

public class StringConcat
{
    private string GivenName = "Felipe";
    private string FathersName = "Paulo";

    public string ConcatUsingFormat() => string.Format("Welcome {0}, {1}' child!", GivenName, FathersName);
    public string ConcatUsingPlusSignalConcat() => "Welcome " + GivenName + ", " + FathersName + "'s child!";
    public string ConcatUsingStringInterpolation() => $"Welcome {GivenName}, {FathersName}'s child!";
    public string ConcatUsingStringBuilder() => new StringBuilder().Append("Welcome ").Append(GivenName).Append(", ").Append(FathersName).Append("' child!").ToString();
}