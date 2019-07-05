using KellermanSoftware.CompareNetObjects;

namespace Aurochses.Runtime
{
    /// <summary>
    /// Object Helpers.
    /// </summary>
    public static class ObjectHelpers
    {
        /// <summary>
        /// Deep equals the specified object to other object.
        /// </summary>
        /// <param name="obj">The current object.</param>
        /// <param name="objTo">The object to compare.</param>
        /// <returns><c>true</c> if objects are equal, <c>false</c> otherwise.</returns>
        public static bool DeepEquals(this object obj, object objTo)
        {
            return new CompareLogic()
                .Compare(obj, objTo)
                .AreEqual;
        }
    }
}