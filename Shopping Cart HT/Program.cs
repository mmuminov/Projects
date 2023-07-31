//using System.Xml.Linq;

//Shopping Cart - Online do'kon korzinkasi dasturini tuzing

//- mahsulotlar uchun Product tipini yarating
//- Product tipida Id ( unique value ), Name fieldlari bo'lsin
//- sotib olinayotgan mahsulotlarni boshqarish uchun ShoppingCart tipini yarating
//- unda mahsulotlar va ularni nechta sotib olinayotganini saqlovchi Items kolleksiyasi bo'lsin
//- Items kolleksiyasi o'zida mahsulot va uning sonini saqlab turadi
//- ShoppingCart da Add va Remove methodlari bo'lsin

//  Add - bu mahsulotlarni korzinkaga qo'shish uchun
//  - bu method hech nima qaytarmaydi
//  - uni product nomli Product tipidagi parameteri bo'lsin
//  - agar Items kolleksiyasida ushbu mahsulot allaqachon bo'lsa uni soni oshirilsin, aks holda yangi qo'shilsin

//  Remove - bu mahsulotlarni korzinkadan o'chirish uchun
//  - bu method boolean qiymat qaytaradi
//  - uni product nomli Product tipidagi parameteri bo'lsin
//  - agar Items kolleksiyasida ushbu mahsulot allaqachon bo'lsa uni soni kamaytirilsin va true qaytarilsin, aks holda false qaytsin

//1. Korzinka ni ishga tushirish
//- dastur boshida Product tipidan 3 ta object yarating
//- 3 ta product - mahsulotni ShoppingCartga qo'shing


using System;
using System.Text.RegularExpressions;

//- mahsulotlar uchun Product tipini yarating
public class Product
{
    public Guid guid;
    public string name;

    public void ShoppingCart(string names, int numbers)
    {
        
    }


}







