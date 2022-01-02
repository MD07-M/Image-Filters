using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
    class AdaptiveMedianFilter
    {
        static double R1, R2;
        static int Zxy;

        static void CountingSort(byte[] arr)
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
        public static int Partition(byte[] Array, int left, int right)
        {
            byte last = Array[right];
            byte Temp;
            int index = left;
            for (int i = left; i < right; i++)
            {
                if (Array[i] <= last)
                {
                    Temp = Array[i];
                    Array[i] = Array[index];
                    Array[index++] = Temp;
                }
            }
            Temp = Array[index];
            Array[index] = Array[right];
            Array[right] = Temp;
            return index;
        }
        public static byte[] QUICK_SORT(byte[] Array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(Array, left, right);
                QUICK_SORT(Array, left, pivot - 1);
                QUICK_SORT(Array, pivot + 1, right);
            }
            return Array;
        }
       

        static void OneDWindow(byte[,] img, byte[] window, int i, int j, int windowSize)
        {
            for (int a = i, k = 0; a <= (i + windowSize - 1); a++)
            {
                for (int b = j; b <= (j + windowSize - 1); b++)
                {
                    window[k] = img[a, b];
                    k++;
                }
            }
        }

        static int NewPixel(byte[] window, int ws, bool sort)
        {
            R1 = Environment.TickCount & Int32.MaxValue;
            int Zmedian;
            int Zmin;
            int Zmax;
            int newpixelval = 0;
            int windowSize = ws;
            int newwindowsize=windowSize;
            
            if (newwindowsize > windowSize)
            {
                windowSize += 2;
            }
      
            Zxy = window[((windowSize * windowSize) - 1) / 2];


            if (sort)
            {
                QUICK_SORT(window, 0, ((windowSize * windowSize) - 1));
            }
            else CountingSort(window);

            Zmedian = window[((windowSize * windowSize) - 1) / 2];
            Zmin = window[0];
            Zmax = window[(windowSize * windowSize) - 1];

            int A1 = Zmedian - Zmin;
            int A2 = Zmax - Zmedian;

            if (A1 > 0 && A2 > 0)
            {
                int B1 = Zxy - Zmin;
                int B2 = Zmax - Zxy;
                if (B1 > 0 && B2 > 0)
                {
                    newpixelval = Zxy;
                }
                else
                {
                    newpixelval = Zmedian;
                }
            }
            else
            {
                newwindowsize += 2;

                if (newwindowsize <= ws)
                {
                    NewPixel(window, ws, sort);
                }
                else
                    newpixelval = Zmedian;

            }
            
            R2= Environment.TickCount & Int32.MaxValue;
            return newpixelval;
        }

       public static double GetRunTime()
        {
            double result = (R2 - R1)/1000;
            return result;
        }

        static byte[,] Padding(byte[,] img, int windowSize)
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


        public static byte[,] AdaptivemedianFilter(byte[,] img, int windowSize,  bool Sort)
        {
            byte[] window = new byte[windowSize * windowSize];
            byte[,] imgPad = Padding(img, windowSize);
            int imgWidth = imgPad.GetLength(0), imgLength = imgPad.GetLength(1);
           

            for (int i = 0; (i + windowSize - 1) < imgWidth; i++)
            {
                for (int j = 0; (j + windowSize - 1) < imgLength; j++)
                {
                    OneDWindow(imgPad, window, i, j, windowSize);
                    int newPixel = NewPixel(window,windowSize, Sort);
                    img[i, j] = (byte)newPixel;
                }
            }
            return img;
        }
    }
}