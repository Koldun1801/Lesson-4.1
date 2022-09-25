
int l, w;
int Asumm=0, Bsumm=0, Csumm=0;
string ls, ws;
Random rnd = new Random() ;       //создал необходимые переменные     

ls = Console.ReadLine();
ws = Console.ReadLine();
try
{
    l= int.Parse(ls);
    w= int.Parse(ws);
}
catch
{
    Console.WriteLine("некорректно введены размеры матриц");
    Console.ReadKey();
    return;
}                           //поместил длину и ширину матриц в соответствующие целочисленные переменные

int[,] A = new int[l, w];
int[,] B = new int[l, w];
int[,] C = new int[l, w];
for (int i = 0; i < l; i++)
{
    for(int j = 0; j < w; j++)
    {
        A[i,j] = rnd.Next(-100, 200);
        B[i,j] = rnd.Next(-100, 200);
        C[i, j] = A[i, j] + B[i, j];
        Asumm += A[i, j];
        Bsumm += B[i, j];               //заполнил матрицы А и В, в этом же цикле сложил их для заполнения матрицы С
        Csumm += C[i, j];               //так же добавил суммирование в отдельные переменные, чтобы получить суммы всех элементов матриц
    }                               

    Console.Write(" | ");
    for (int j = 0; j < w; j++)
    {
        Console.Write("{0}\t", A[i, j]);
    }
    Console.Write("|\t| ");
    for (int j = 0; j < w; j++)
    {
        Console.Write("{0}\t", B[i, j]);
    }
    Console.Write("|\t| ");
    for (int j = 0; j < w; j++)
    {
        Console.Write("{0}\t", C[i, j]);
    }
    Console.Write("|\n\n"); // вывод сделал построчным, чтобы не делать нагромождения циклов for
}

Console.Write("\n Сумма матриц:\n A = {0}\n B = {1}\n C = {2}",Asumm,Bsumm,Csumm);
Console.ReadKey();

// Я мог бы сделать всё на одном трёхмерном массиве, что упростило бы вывод, но усложнило бы читаемость кода
