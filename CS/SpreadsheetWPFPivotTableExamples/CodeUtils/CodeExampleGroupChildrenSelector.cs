using DevExpress.Xpf.Grid;
using System.Collections;

namespace SpreadsheetWPFPivotTableExamples
{
    public class CodeExampleGroupChildrenSelector : IChildNodesSelector
    {
        IEnumerable IChildNodesSelector.SelectChildren(object item)
        {
            if (item is CodeExampleGroup)
                return ((CodeExampleGroup)item).Examples;
            return null;
        }
    }
}
