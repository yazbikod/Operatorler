// Operatörler TOPLAMA ÇIKARMA ÇARPMA BÖLME MOD ALMA

Console.WriteLine("Dört tane sayı giriniz...");
int sayi1 = Convert.ToInt32(Console.ReadLine());
int sayi2 = Convert.ToInt32(Console.ReadLine());
int sayi3 = Convert.ToInt32(Console.ReadLine());
int sayi4 = Convert.ToInt32(Console.ReadLine());


int sonuc = ((sayi1 * sayi2) + (sayi3 / sayi4)) - (2);
Console.WriteLine("a*b + b/c -2 Sonuç: " + sonuc);


Console.WriteLine("1. ve 2. Sayı Mod Alma Kalan Sayı = " + sayi1 % sayi2);


// ARTIRMA AZALTMA

Console.WriteLine("Lütfen bir sayı giriniz...");
int sayi = Convert.ToInt32(Console.ReadLine());
sayi++;
Console.WriteLine("Sayı değeri 1 artıyor ; " + sayi);

sayi--;
Console.WriteLine("Sayi değeri 1 azalıyor ; " + sayi);

sayi -= 5;
Console.WriteLine("Sayı değeri 5 azalıyor ; " + sayi);

sayi += 8;
Console.WriteLine("Sayı değeri 8 artıyor ; " + sayi);

sayi *= 3;
Console.WriteLine("Sayı değeri 3 ile çarpılıyor ; " + sayi);

sayi /= 2;
Console.WriteLine("Sayı değeri 2 ile bölünüyor ; " + sayi);



// ATAMA OPERATÖRÜ

int kutu = 28; // 28 kutu içine atanıyor

// EŞİTTİR OPERATÖRÜ

int num1 = 4;
int num2 = 2;

bool kontrolet = num1 == num2;
Console.WriteLine(kontrolet);
// False

// EŞİT DEĞİLDİR OPERATÖRÜ

bool kontrolet2 = num1 != num2;
Console.WriteLine(kontrolet2);
// True

// BÜYÜK EŞİTTİR KÜÇÜK EŞİTTİR 

bool kontrolet3 = num1 >= num2;
Console.WriteLine(kontrolet3);
// True

bool kontrolet4 = num1 <= num2;
Console.WriteLine(kontrolet4);
// False

// MANTIKSAL OPERATÖRLER VE && . VEYA || (PİPİNG) . DEĞİL !
// Her bir koşul true olmalıdır.
int num3 = 6;
bool kontrolet5 = num1 == num2 && num2 < num3;
Console.WriteLine(kontrolet5);
//False 

// En az bir true değeri dönerse sonuç true döner.
bool kontrolet6 = num1 >= num2 || num2 < num3;
Console.WriteLine(kontrolet6);
// True

// Var olan bir değerin zıttını alır.
bool z = true;
Console.WriteLine(!z);
// False

