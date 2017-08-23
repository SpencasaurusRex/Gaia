using UnityEngine;

public class Character {
	public Attribute Health;		
	public Attribute Stamina;
	public Attribute Hunger;
	public Attribute Thirst;

	public Skill Farming;

	public Character()
	{
		Health = new Attribute(100);
		Stamina = new Attribute(100);
		Hunger = new Attribute(100);
		Thirst = new Attribute(100);
	}
}
