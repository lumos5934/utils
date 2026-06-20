namespace LLib.Utils
{
    public static class BitUtil
    {
        /// <summary>
        /// 해당 비트가 포함되어 있는지 확인합니다.
        /// </summary>
        public static bool Has(int current, int flag)
        {
            return (current & flag) == flag;
        }

        /// <summary>
        /// 해당 비트가 하나라도 겹치는지 확인합니다.
        /// </summary>
        public static bool Any(int current, int flag)
        {
            return (current & flag) != 0;
        }

        /// <summary>
        /// 비트가 하나도 없는 상태인지 확인합니다.
        /// </summary>
        public static bool IsNone(int current)
        {
            return current == 0;
        }

        /// <summary>
        /// 비트가 하나만 켜져 있는 상태인지 확인합니다.
        /// </summary>
        public static bool IsSingle(int current)
        {
            return current != 0 && (current & (current - 1)) == 0;
        }

        /// <summary>
        /// 비트를 추가합니다.
        /// </summary>
        public static int Add(int current, int flag)
        {
            return current | flag;
        }

        /// <summary>
        /// 비트를 제거합니다.
        /// </summary>
        public static int Remove(int current, int flag)
        {
            return current & ~flag;
        }

        /// <summary>
        /// 비트를 토글합니다.
        /// </summary>
        public static int Toggle(int current, int flag)
        {
            return current ^ flag;
        }

        /// <summary>
        /// 여러 비트를 합칩니다.
        /// </summary>
        public static int Combine(params int[] flags)
        {
            int result = 0;
            for (int i = 0; i < flags.Length; i++)
            {
                result |= flags[i];
            }

            return result;
        }

        /// <summary>
        /// bit index를 flag로 변환합니다. (1 << index)
        /// </summary>
        public static int Flag(int index)
        {
            return 1 << index;
        }

        /// <summary>
        /// 켜져 있는 비트의 개수를 반환합니다.
        /// </summary>
        public static int Count(int current)
        {
            int count = 0;

            while (current != 0)
            {
                current &= (current - 1);
                count++;
            }

            return count;
        }
    }
}