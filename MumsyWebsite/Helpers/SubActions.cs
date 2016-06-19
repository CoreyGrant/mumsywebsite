using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Reflection;

namespace MumsyWebsite.Helpers
{
	public class SubActionAttribute : Attribute
	{
		public string Text { get; private set; }

		public SubActionAttribute(){ }

		public SubActionAttribute(string text)
		{
			Text = text;
		}

	}

	public static class SubActions
	{
		public static string ActionLinkList(
			this HtmlHelper helper,
			string controller)
		{
			var controllerNamespace = "MumsyWebsite.Controllers.";
			var type = Type.GetType(controllerNamespace + controller + "Controller");
			var methods = type.GetMethods();
			var subActionLinks = methods
				.Where(x => x.GetCustomAttributes<SubActionAttribute>().Any())
				.Select(x =>
				{
					var attribute = x.GetCustomAttribute<SubActionAttribute>();
					var linkName = string.IsNullOrEmpty(attribute.Text)
						? x.Name
						: attribute.Text;
					return helper.ActionLink(linkName, x.Name, controller);
				});

			var listItemModel = "<li>{0}</li>";
			var listModel = "<ul>{0}</ul>";
			var listInner = subActionLinks.Aggregate("", (prev, cur) =>
			{
				return prev + string.Format(
					listItemModel,
					cur);
			});
			return string.Format(listModel, listInner);
		}
	}
}