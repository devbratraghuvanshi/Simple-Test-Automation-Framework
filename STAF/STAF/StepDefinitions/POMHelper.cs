using STAF.PageObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace STAF.StepDefinitions
{
	public partial class BaseStepDefinitions
	{
        [Then(@"User is on/(redirected to) {string} view/page")]
        public void ThenUserIsOnWebPage(string pageForElement)
        {
            page = GetInstance(pageForElement);
        }

        public IWebPage GetInstance(string typeName)
        {
            Type type = null;

            Assembly assembly = this.GetType().Assembly;
            foreach (var typeInfo in assembly.DefinedTypes)
            {
                if (typeInfo.Name.ToLower()== typeName.ToLower())
                {
                    type = assembly.GetType(typeInfo.FullName);
                }
            }
           
            if (type != null)
                return (IWebPage)Activator.CreateInstance(type);

            throw new Exception($"Not able to find any page named as {typeName}, Make sure you have created a class for you Page.");
        }


    }
}
