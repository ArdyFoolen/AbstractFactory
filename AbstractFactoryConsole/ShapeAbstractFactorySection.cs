using AbstractFactoryContracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryConsole
{
    public sealed class ShapeAbstractFactorySection : ConfigurationSection
    {
        private static ConfigurationPropertyCollection _Properties;
        private static bool _ReadOnly;

        private static readonly ConfigurationProperty _AbstractFactoryDll =
            new ConfigurationProperty("AbstractFactoryDll",
            typeof(string), "AbstractFactoryDomain",
            ConfigurationPropertyOptions.IsRequired);

        private static readonly ConfigurationProperty _AbstractFactoryName = 
            new ConfigurationProperty("AbstractFactoryName",
            typeof(string), "DefaultAbstractFactory",
            ConfigurationPropertyOptions.IsRequired);
        public static ShapeAbstractFactorySection Settings { get; } = ConfigurationManager.GetSection("ShapeAbstractFactorySection") as ShapeAbstractFactorySection;

        public ShapeAbstractFactorySection()
        {
            _Properties = new ConfigurationPropertyCollection();
            _Properties.Add(_AbstractFactoryDll);
            _Properties.Add(_AbstractFactoryName);
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get
            {
                return _Properties;
            }
        }


        private new bool IsReadOnly
        {
            get
            {
                return _ReadOnly;
            }
        }

        private void ThrowIfReadOnly(string propertyName)
        {
            if (IsReadOnly)
                throw new ConfigurationErrorsException("The property " + propertyName + " is read only.");
        }


        protected override object GetRuntimeObject()
        {
            _ReadOnly = true;
            return base.GetRuntimeObject();
        }

        public string AbstractFactoryDll
        {
            get
            {
                return (string)this["AbstractFactoryDll"];
            }
            set
            {
                ThrowIfReadOnly("AbstractFactoryDll");
                this["AbstractFactoryDll"] = value;
            }
        }

        public string AbstractFactoryName
        {
            get
            {
                return (string)this["AbstractFactoryName"];
            }
            set
            {
                ThrowIfReadOnly("AbstractFactoryName");
                this["AbstractFactoryName"] = value;
            }
        }
    }
}
