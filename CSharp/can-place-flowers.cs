/*
 * @lc app=leetcode id=605 lang=csharp
 *
 * [605] Can Place Flowers
 * Link: https://leetcode.com/problems/can-place-flowers/description/
 */

// @lc code=start
public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        for (int i = 0; i < flowerbed.Length; i++) {
            if (flowerbed[i] == 0) {
                bool emptyLeft = (i == 0) || (flowerbed[i - 1] == 0);
                bool emptyRight = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);
                
                if (emptyLeft && emptyRight) {
                    flowerbed[i] = 1; 
                    n--;
                }
            }
        }
        return n <= 0;
    }
}
// @lc code=end

