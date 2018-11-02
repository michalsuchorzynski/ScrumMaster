using Microsoft.Extensions.Localization;
using ScrumMasterResource;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using Xunit;
using System.Linq;

namespace ScrumMasterXUnitTest
{
    public class ResourcesUnitTest
    {
        private List<ResourceManager> _resources;
        private List<string> _supportedCultures;

        public ResourcesUnitTest()
        {
            _resources = new List<ResourceManager>();
            _resources.Add(new ResourceManager(typeof(ScrumMasterResource.Resources.SharedResource)));

            _supportedCultures = new List<string>()
            {
               "pl",
               "en"
            };
        }

        [Fact]
        public void SharedResourcesTest()
        {
            bool isEqual = true;
            if (_supportedCultures.Count == 0 || _resources.Count == 0)
            {
                Assert.False(true);
            }

            foreach (ResourceManager resource in _resources)
            {
                int resourceLenght = 0;
                foreach (string culture in _supportedCultures)
                {
                    ResourceSet resourceSet = resource.GetResourceSet(new CultureInfo(culture), true, true);
                    var currentResourceLenght = (resourceSet.Cast<DictionaryEntry>()).Count();

                    if (resourceLenght == 0 && currentResourceLenght != 0)
                    {
                        resourceLenght = currentResourceLenght;
                    }
                    else if (currentResourceLenght == 0 || resourceLenght != currentResourceLenght)
                    {
                        isEqual = false;
                        break;
                    }
                }
            }
            Assert.True(isEqual);
        }
    }
}
