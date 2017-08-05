using System.Collections.Generic;

namespace Aurochses.Runtime.Tests.Fakes
{
    public class ObjectHelpersValueEqualsMemberDataListModel
    {
        public List<ObjectHelpersValueEqualsMemberDataListItemModel> Items { get; set; }

        public class ObjectHelpersValueEqualsMemberDataListItemModel
        {
            public string Value { get; set; }
        }
    }
}