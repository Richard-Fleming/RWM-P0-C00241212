using NUnit.Framework;
using UnityEngine;

namespace Tests
{
  public class DiffTest
  {
    [Test]
    public void DiffSimple()
    {
      int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
      int[] output = Diff.diffs(input);
      int[] expected = { 4, 2, 6, 5, 6, 5, 6, 5, 6, 5 };

      CollectionAssert.AreEqual(expected, output);
    }
  }
}
