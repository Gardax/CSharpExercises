public class Chef
{
	public void Cook()
    {
		Bowl bowl;
		bowl = GetBowl();
		
        Potato potato = GetPotato();
		Peel(potato);
		Cut(potato);
		bowl.Add(potato);
		
        Carrot carrot = GetCarrot();
		Peel(carrot);
		Cut(carrot);
        bowl.Add(carrot);
    }
	
    private Bowl GetBowl()
    {   
        //... 
    }
	
	private Potato GetPotato()
    {
        //...
    }
	
    private Carrot GetCarrot()
    {
        //...
    }
	
    private void Cut(Vegetable potato)
    {
        //...
    }    
}
