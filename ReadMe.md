Семинар 6. 06.06.2023
double [] InAr (string array)
{
    string [] Nums = array.Split(" ");
    double [] NumDoub = new double[Nums.Length];
    for (int i = 0; i<Nums.Length; i++) NumDoub[i]=double.Parse(Nums[i]);
    return NumDoub;
