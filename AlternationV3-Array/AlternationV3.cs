using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternationV3_Array
{
    public class AlternationV3
    {/// <summary>
    /// Позволяет проверить чередование +/- элементов
    /// </summary>
    /// <param name="mas">Входная вещественная матрица</param>
    /// <returns></returns>
        public static bool ElementAlternationCheck(double[] mas)
        {
            bool sequence = true;//Прувер для идентификации соответствия условию
            if (mas[0] < 0)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (mas[i] >= 0)
                        {
                            sequence = false;
                            break;
                        }
                    }
                    else
                    {
                        if (mas[i] < 0)
                        {
                            sequence = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (mas[i] < 0)
                        {
                            sequence = false;
                            break;
                        }
                    }
                    else
                    {
                        if (mas[i] >= 0)
                        {
                            sequence = false;
                            break;
                        }
                    }
                }
            }            
            if (sequence)  return true;//Возврат относительно имеющихся данных
            else return false;
        }
    }
}
