/*MIT License

Copyright(c) 2017 Jeiel Aranal

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*/
#if !ODIN_INSPECTOR
using UnityEngine;

namespace Pixeye.Actors
{
	/// <summary>
	/// Display a List/Array as a sortable list in the inspector
	/// </summary>
	public class ReorderableAttribute : PropertyAttribute
	{
		public string ElementHeader { get; protected set; }
		public bool HeaderZeroIndex { get; protected set; }
		public bool ElementSingleLine { get; protected set; }

		/// <summary>
		/// Display a List/Array as a sortable list in the inspector
		/// </summary>
		public ReorderableAttribute()
		{
			ElementHeader = string.Empty;
			HeaderZeroIndex = false;
			ElementSingleLine = false;
		}

		/// <summary>
		/// Display a List/Array as a sortable list in the inspector
		/// </summary>
		/// <param name="headerString">Customize the element name in the inspector</param>
		/// <param name="isZeroIndex">If false, start element list count from 1</param>
		/// <param name="isSingleLine">Try to fit the array elements in a single line</param>
		public ReorderableAttribute(string headerString = "", bool isZeroIndex = true, bool isSingleLine = false)
		{
			ElementHeader = headerString;
			HeaderZeroIndex = isZeroIndex;
			ElementSingleLine = isSingleLine;
		}
	}
}
#endif
