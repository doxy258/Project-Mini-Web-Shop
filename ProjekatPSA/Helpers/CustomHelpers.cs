using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjekatPSA.Helpers
{
    public class CustomHelpers
    {
        public static MvcHtmlString CustomButton(string buttonText)
        {
            string buttonHtml = $"<button type='button'>{buttonText}</button>";
            return MvcHtmlString.Create(buttonHtml);
        }
    }
}