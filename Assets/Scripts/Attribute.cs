using UnityEngine;

public class Attribute {
	public delegate void SubValueHandler();
	public SubValueHandler HandleSubValue;

	public Attribute(int max) {
		Max = max;
		Current = Max;
	}

	private int max;
	public int Max {
		get {return max;}
		set {
			max = value;
			if (Current > max) {
				Current = max;
			}	
		}
	}

	private float current;
	public float Current {
		get { return current; }
		set {
			current = value;
			if (current <= 0) {
				current = 0;
				if (HandleSubValue != null) 
				{
					HandleSubValue();
				}
			}
		}
	}
}
