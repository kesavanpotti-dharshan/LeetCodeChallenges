/*
 * @lc app=leetcode id=1071 lang=csharp
 *
 * [1071] Greatest Common Divisor of Strings
 * Link: https://leetcode.com/problems/greatest-common-divisor-of-strings/description/
 */

// @lc code=start
public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        int previousShortest = str1.Length;
        int previousRemainder = str2.Length;
        int remainder = previousShortest % previousRemainder;
        
         if (str1.Length == 0 ||
            str2.Length == 0 ||
            str1 + str2 != str2 + str1)
        {
            return string.Empty;
        }

        while (remainder != 0)
        {
            previousShortest = previousRemainder;
            previousRemainder = remainder;
            remainder = previousShortest % previousRemainder;
        }

        return str1.Substring(0, previousRemainder);     
    }
}
// @lc code=end

