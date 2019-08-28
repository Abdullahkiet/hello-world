using System;

namespace ds_lab_2_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] bub = {3,87,56};
            //int arzi;

            //for (int i = 0; i < bub.Length; i++)
            //{
            //    for (int j = 0; j < bub.Length-1; j++)
            //    {
            //        if (bub[j] < bub[j+1])
            //        {
            //            arzi = bub[j + 1];
            //            bub[j + 1] = bub[j];
            //            bub[j] = arzi;
            //        }
            //    }
            //}

            //foreach (var item in bub)
            //{
            //    Console.WriteLine(item);
            //}


            int[] sel = {54,5,8,845 };
            int arzi, choti;

            for (int i = 0; i < sel.Length; i++)
            {

                choti = i;
                for (int j = i+1; j < sel.Length-1; j++)
                {
                    if (sel[j] < sel[choti])
                    {
                        choti = j;
                    }
                }

                arzi = sel[choti];
                sel[choti] = sel[i];
                sel[i] = arzi;


            }

            foreach (var item in sel)
            {
                Console.WriteLine(item);
            }
        }
    }
}
