
public class JOLeskeUtility
{
    public static int AtoI(string numberscrtring)
    {
        int output = 0;
        for (int i = 0; i< numberscrtring.Length; i++)
        {
            output = output * 10;
            output += (int)(numberscrtring[i] - '0');
        }
        return output;
    }
}