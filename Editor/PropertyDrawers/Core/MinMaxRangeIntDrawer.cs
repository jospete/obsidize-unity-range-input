using UnityEditor;

namespace Obsidize.RangeInput.EditorTools
{
	[CustomPropertyDrawer(typeof(MinMaxRangeInt))]
	public class MinMaxRangeIntDrawer : MinMaxDrawerBase<MinMaxRangeInt, int>
	{
	}
}
