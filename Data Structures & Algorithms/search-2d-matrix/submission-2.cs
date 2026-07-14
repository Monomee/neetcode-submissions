public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int cols = matrix[0].Length;
        int rows = matrix.Length;
        
        int low = 0;
        int high = rows * cols - 1;


        while (low <= high){
            int mid = high - (high - low) / 2;

            int r = mid / cols;
            int l = mid % cols;

            if (matrix[r][l] == target) return true;

            if (matrix[r][l] < target) low = mid + 1;
            else high = mid - 1;
        }

        return false;
    }

}
