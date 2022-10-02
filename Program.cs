namespace ThreeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {-1,0,1,2,-1,-4};

            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort(nums);

            int start = 0, left, right;

            int target;

            while (start<nums.Length-2)
            {
                target = nums[start] * -1;
                left = start + 1;
                right = nums.Length - 1;

               
                while (left < right)
                {
                    
                    if (nums[left] + nums[right] > target)
                    {
                        --right;
                    }

                    
                    else if (nums[left] + nums[right] < target)
                    {
                        ++left;
                    }
                    /*If none of those are true, then it means that nums[l]+nums[r] = our desired value */
                    else
                    {
                        
                        List<int> OneSolution = new List<int>() { nums[start], nums[left], nums[right] };
                        result.Add(OneSolution);

                        
                        while (left < right && nums[left] == OneSolution[1])
                            ++left;
                        while (left < right && nums[right] == OneSolution[2])
                            --right;
                    }

                }
                
                int currentStartNumber = nums[start];
                while (start < nums.Length - 2 && nums[start] == currentStartNumber)
                    ++start;
            }
            foreach (var r in result)
                Console.WriteLine(string.Join(" ",r));

        }


    }
}