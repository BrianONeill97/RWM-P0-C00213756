public class XOR21
{
    public static int[] XORFunc(int[] array)
    {
        int XORNum = 21;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] ^ XORNum;
        }

        return array;
    }
}
