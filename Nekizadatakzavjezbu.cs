using System;

class KlasaC
{
    public int Zbroj(int[] niz)
    {
        int zbroj = 0;
        foreach (int broj in niz)
        {
            zbroj += broj;
        }
        return zbroj;
    }

    public double Prosjek(int[] niz)
    {
        int zbroj = Zbroj(niz);
        return (double)zbroj / niz.Length;
    }
}

class Sort
{
    public void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(arr, left, right);
            if (pivotIndex > 1)
                QuickSort(arr, left, pivotIndex - 1);
            if (pivotIndex + 1 < right)
                QuickSort(arr, pivotIndex + 1, right);
        }
    }

    private int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {
            while (arr[left] < pivot)
                left++;
            while (arr[right] > pivot)
                right--;

            if (left < right)
            {
                if (arr[left] == arr[right]) return right;
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
            else
            {
                return right;
            }
        }
    }
}

class Search
{
    public int BinarySearch(int[] arr, int x)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == x)
                return mid;
            else if (arr[mid] < x)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}

class Program
{
    static void Main()
    {
        // KlasaC
        KlasaC objektC = new KlasaC();
        int[] unosC = new int[5];
        Console.WriteLine("Unesite 5 cijelih brojeva:");
        for (int i = 0; i < 5; ++i)
        {
            Console.Write($"Broj {i + 1}: ");
            unosC[i] = Convert.ToInt32(Console.ReadLine());
        }
        int zbrojC = objektC.Zbroj(unosC);
        double prosjekC = objektC.Prosjek(unosC);
        Console.WriteLine($"Zbroj elemenata: {zbrojC}");
        Console.WriteLine($"Prosjek elemenata: {prosjekC}");

        // Sort
        Sort objektSort = new Sort();
        int[] nizSort = { 3, 5, 1, 8, 6, 4, 7, 9, 2 };
        objektSort.QuickSort(nizSort, 0, nizSort.Length - 1);
        Console.WriteLine("Sortirani niz:");
        foreach (int broj in nizSort)
        {
            Console.Write(broj + " ");
        }
        Console.WriteLine();

        // Search
        Search objektSearch = new Search();
        int[] neparni = new int[100];
        int neparniBroj = 1;
        for (int i = 0; i < 100; i++)
        {
            neparni[i] = neparniBroj;
            neparniBroj += 2;
        }
        int indeks = objektSearch.BinarySearch(neparni, 75);
        Console.WriteLine($"Indeks broja 75 u nizu je: {indeks}");

        Console.ReadLine();
    }
}
