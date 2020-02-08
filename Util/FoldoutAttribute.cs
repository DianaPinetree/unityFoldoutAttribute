using UnityEngine;
public class FoldoutAttribute : PropertyAttribute
{
	public string name;
	public bool foldEverything;
	public FoldoutAttribute(string name, bool foldEverything = false)
	{
		this.foldEverything = foldEverything;
		this.name           = name;
	}
}