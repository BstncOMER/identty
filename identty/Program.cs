Console.WriteLine(" kediniz mi var bizi takip edin ");
int sayi = 10;
int sayi2 = 20;
sayi = sayi2;
sayi2 = 22;
Console.WriteLine(sayi);
int[] sayilar1 = new int[] {10,20,30};
int[] sayilar2  = new int[] {100,200,300};
sayilar1 =sayilar2;
sayilar2[0] = 999;
Console.WriteLine(sayilar1[0]);

// int decimal flood double , bool  bunlar  = değer tipi 
// array class interface  = referans tipi 

// stock  değer tipleri ile ilgili işlevleri alır
// ilk yazılan koddaki mantık şudur

// stock da değerler sayi 1 = 10 sayi2 = 20 olarak tutulur 
//  sonra sayi biri eşitle sayı ikiye dersen sayi birin değeri silinir 
//sayi ikinin değeri her iki alanda da verilir 30 olur
// sonra bağıntı kopar ve sayi ikiyi 22 tanımlaman sayi bir üzerinde 
//bir değişim olması anlamına gelmez 

//array için de heap da bir veri tutulur 
//sayilar bir   örn 190. heap da tutulur 
//sayilar2 de   örn 191 . hapda dursun
// bunları sayi1  = sayi2 şeklinde eşitlemek ikisini de  191. heapa almak demek
//bu durum  neticesinde artık sayılar bir ve iki aynı array da
// aynı noktayı değiştirir ya da okur 
