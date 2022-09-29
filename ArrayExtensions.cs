public static class ArrayExtensions{
    public static void Swap(this int[] arr, int index1, int index2){
        if (index1 >= 0 && index1 < arr.Length && index2 >= 0 && index2 < arr.Length){
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
    
    //For k <= arr.Length
    public static int KthLargestElement(this int[] arr, int start, int end, int k){
        int index = arr.Partition(start, end);

        if (index == arr.Length - k)
            return arr[index];
        else if (index < arr.Length - k)
            return arr.KthLargestElement(index + 1, end, k);
        else
            return arr.KthLargestElement(start, index, k);
    }

    private static int Partition(this int[] arr, int start, int end){
        int j = new Random().Next(start, end + 1);    
        arr.Swap(start, j);

        int left = start;
        int right = end;
        while (left < right){
            if (arr[left + 1] < arr[left]){
                arr.Swap(left + 1, left);
                left++;
            }
            else if (arr[right] >= arr[left])
                right--;
            else
                arr.Swap(left + 1, right);
        }

        return left;
    }
}
