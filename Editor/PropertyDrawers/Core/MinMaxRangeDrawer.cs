using UnityEditor;

namespace Obsidize.RangeInput.EditorTools
{
	[CustomPropertyDrawer(typeof(MinMaxRange))]
	public class MinMaxRangeDrawer : MinMaxDrawerBase<MinMaxRange, float>
	{
	}
}
