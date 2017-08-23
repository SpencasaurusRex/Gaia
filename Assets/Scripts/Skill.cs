using UnityEngine;

public class Skill {
	
	private const float a = 1000000f / 9999f;
	
	public Skill() {
		Experience = 0;
	}

	private int experience;
	public int Experience 
	{
		get { return experience; }
		set 
		{
			experience = value;
			Level = LevelFromExperience(value);
		}
	}

	public int Level {
		private set;
		get;
	}

	public static int LevelFromExperience(int xp) 
	{
		return Mathf.FloorToInt(Mathf.Sqrt((xp + a) / a));
	}

	public static int ExperienceFromLevel(int level) 
	{
		return Mathf.CeilToInt(a * level * level - a);
	}

	public static int ExperienceToNextLevel(int xp) 
	{
		return ExperienceFromLevel(LevelFromExperience(xp) + 1) - xp;
	}
}