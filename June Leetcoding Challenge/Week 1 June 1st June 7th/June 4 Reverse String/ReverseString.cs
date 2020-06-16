public class Solution
{
    public void ReverseString(char[] s)
        {
            int count = s.Length / 2;
            int subOne = s.Length - 1;
            int dif;
            for(int i = 0; i < count; ++i)
            {
                dif = (int)s[i] - (int)s[subOne - i];                  
                s[subOne - i] = (char)((int)s[subOne - i] + dif);
                s[i] = (char)((int)(s[i]) - dif);
            }
        }
}