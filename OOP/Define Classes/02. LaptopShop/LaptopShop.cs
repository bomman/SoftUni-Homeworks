using System;



class LaptopShop
{
    static void Main()
    {
        var laptopOne = new Laptop("Lenovo Yoga 2 Pro", 541.2531);
        var laptopTwo = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5), "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8, "Intel HD Graphics 4400", "128GB SSD", "13.3(33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", 2259.002124);

        Console.WriteLine(laptopOne);
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine(laptopTwo);
    }
}

