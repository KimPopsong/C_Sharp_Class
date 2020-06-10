using System;
public class GBB_Check
{
    public static int Inp()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int Rnd()
    {
        Random rnd = new Random(); //랜덤 객체 rnd생성
        return rnd.Next(1, 101);
    }

    public static int Check(int me, int answer)
    {
        if (me == answer) //같을 때
        {
            return 1;
        }

        else if (me > answer) //입력 값이 클 때
        {
            return 2;
        }

        else //입력 값이 작을 때
        {
            return 0;
        }
    }
}