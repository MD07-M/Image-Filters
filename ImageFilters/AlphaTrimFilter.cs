using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
    class AlphaTrimFilter
    {
        static void countingSort(byte[] arr)
        {
            int mx = arr.Max();
            byte[] countArr = new byte[++mx];
            for (int i = 0; i < mx; i++)
            {
                countArr[i] = 0;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                countArr[arr[i]]++;
            }
            for (int i = 0, j = 0; i < mx; i++)
            {
                while (countArr[i] > 0)
                {
                    arr[j] = (byte)i;
                    j++;
                    countArr[i]--;
                }
            }
        }

        static byte[] kSort(byte[] arr, int k)
        {
            int newArrSize = (arr.Length) - (k * 2);
            byte[] newArr = new byte[newArrSize];
            bool[] visited = new bool[arr.Length];
            for (int i = 0; i < k; i++)
            {
                int min = (int)1e9, minindex = 0, max = (int)-1e9, maxindex = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (!visited[j] && arr[j] < min)
                    {
                        min = arr[j];
                        minindex = j;
                    }
                }
                visited[minindex] = true;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (!visited[j] && arr[j] > max)
                    {
                        max = arr[j];
                        maxindex = j;
                    }
                }
                visited[maxindex] = true;
            }
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (!visited[i])
                {
                    newArr[j++] = arr[i];
                }
            }
            return newArr;
        }

        static byte[] getWindow(byte[,] img, byte[] window, int i, int j, int windowSize)
        {
            for (int a = i, k = 0; a <= (i + windowSize - 1); a++)
            {
                for (int b = j; b <= (j + windowSize - 1); b++)
                {
                    window[k] = img[a, b];
                    k++;
                }
            }
            return window;
        }

        static int calculateNewPixel(byte[] window, int t, int algorithmType)
        {
            int newPixel = 0;
            if (algorithmType == 1)
            {
                for (int i = t; i < (window.Length) - t; i++)
                {
                    newPixel += window[i];
                }
                newPixel /= (window.Length) - (t * 2);
            }
            else
            {
                for (int i = 0; i < window.Length; i++)
                {
                    newPixel += window[i];
                }
                newPixel /= window.Length;
            }
            return newPixel;
        }

        static byte[,] padding(byte[,] img, int windowSize)
        {
            int pad = windowSize / 2;

            byte[,] arrayZeroPad = new byte[img.GetLength(0) + (pad * 2), img.GetLength(1) + (pad * 2)];

            for (int i = 0; i < arrayZeroPad.GetLength(0); i++)
            {
                for (int j = 0; j < arrayZeroPad.GetLength(1); j++)
                {
                    if (i < pad || i > (arrayZeroPad.GetLength(0) - 1 - pad) || j < pad || j > (arrayZeroPad.GetLength(1) - 1 - pad))
                        arrayZeroPad[i, j] = 0;
                    else
                        arrayZeroPad[i, j] = img[i - pad, j - pad];
                }
            }
            return arrayZeroPad;
        }

        public static byte[,] alphaTrimFilter(byte[,] img, int windowSize, int t, int algorithmType)
        {
            byte[] window = new byte[windowSize * windowSize];
            byte[,] imgPad = padding(img, windowSize);
            int imgWidth = imgPad.GetLength(0), imgLength = imgPad.GetLength(1);
            for (int i = 0; (i + windowSize - 1) < imgWidth; i++)
            {
                for (int j = 0; (j + windowSize - 1) < imgLength; j++)
                {
                    window = getWindow(imgPad, window, i, j, windowSize);
                    int newPixel;
                    if (algorithmType == 1)
                    {
                        countingSort(window);
                        newPixel = calculateNewPixel(window, t, algorithmType);
                    }
                    else
                    {
                        byte[] sortedWindow = kSort(window, t);
                        newPixel = calculateNewPixel(sortedWindow, t, algorithmType);
                    }
                    img[i, j] = (byte)newPixel;
                }
            }
            return img;
        }
    }
}
