using System;


Arrows flecha = new Arrows("obsidian", "turkey feathers", 60, 0);
class Arrows
{
    public string arrowheads;
    public string fletching;
    public int shaft;
    public float arrow_price;

    public Arrows(string arrowheads, string fletching, int shaft, double arrow_price)
    {
        if (arrowheads == "steel")
        {
            arrow_price += 10;
            Console.WriteLine($"You have selected {arrowheads} for your arrowhead");
        }
        else if (arrowheads == "wood")
        {
            arrow_price += 3;
            Console.WriteLine($"You have selected {arrowheads} for your arrowhead");
        }

        else if (arrowheads == "obsidian")
        {
            arrow_price += 5;
            Console.WriteLine($"You have selected {arrowheads} for your arrowhead");
        }

        //fletching
        if (fletching == "plastic")
        {
            Console.WriteLine($"You have selected {fletching} for your arrowhead");
            arrow_price += 10;
        }

        else if (fletching == "turkey feathers")
        {
            Console.WriteLine($"You have selected {fletching} for your arrowhead");
            arrow_price += 5;
        }
        else if (fletching == "goose feathers")
        {
            Console.WriteLine($"You have selected {fletching} for your arrowhead");
            arrow_price += 3;
        }
        //shaft price
        if (shaft < 60 || shaft > 100)
            Console.WriteLine($"Sorry, {shaft} is not available size, enter a number between 60 - 100");
        else
            arrow_price += shaft * .05;
            Console.WriteLine($"Your shaft is {shaft}cm");


        Console.WriteLine($"The price is {arrow_price}.");
    }

}
/* arrowheads:
     * steel = 10 gold
     * wood = 3 gold
     * obsidian = 5 gold
     * 
     * fletching:
     *  plastic 10
     *  turkey feathers 5 gold
     *  goose feathers 3 gold
     *  
     *  shaft = .05 per cm (size can be between 60cm and 100cm)
    */

    /*if arrow head == steel:
     * arrow price += 10;
     * else if arrowhead == wood:
     * arrow price += 3...
     */
