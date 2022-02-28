// 22 Найти расстояние между точками в пространстве 2D/3D

int[] arrA = { 5, 3, 8 };
int[] arrB = { 6, 4, 2 };

if (arrA[0] < arrB[0]) 
{
    int x = (arrB[0] - arrA[0]);
}
else 
{
    int x = (arrA[0] - arrB[0]);
}

/*
if (arrA[1] < arrB[1]) distantY = arrB[1] - arrA[1];
else distantY = arrA[1] - arrB[1];

if (arrA[2] < arrB[2]) distantZ = arrB[2] - arrA[2];
else distantZ = arrA[2] - arrB[2];


Console.WriteLine(distantX + distantY + distantZ);
*/
Console.WriteLine(x);