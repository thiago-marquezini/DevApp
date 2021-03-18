using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Localization;

namespace DevApp.ComponentOverride
{
    public class CustomBarLocalizer : BarLocalizer
    {
        public override string GetLocalizedString(BarString id)
        {
            if (id == BarString.RibbonSearchItemNullText)
                return "Procurar";
            if (id == BarString.RibbonSearchItemNoMatchesFound)
                return "Nada encontrado..";
            return base.GetLocalizedString(id);
        }
    }
}
