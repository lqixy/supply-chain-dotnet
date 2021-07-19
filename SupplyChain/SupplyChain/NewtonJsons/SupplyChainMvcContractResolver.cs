using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain
{
    public class SupplyChainMvcContractResolver : DefaultContractResolver
    {
        public SupplyChainMvcContractResolver() { }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);
            ModifyProperty(member, property);

            return property;
        }

        protected override IValueProvider CreateMemberValueProvider(MemberInfo member)
        {
            if (member.MemberType == MemberTypes.Property)
            {
                var pi = (PropertyInfo)member;

                if (pi.PropertyType == typeof(string))
                {
                    return new NullableValueProvider(member, pi.PropertyType);
                }
            }
            else if (member.MemberType == MemberTypes.Field)
            {
                var fi = (FieldInfo)member;
                if (fi.FieldType == typeof(string))
                {
                    return new NullableValueProvider(member, fi.FieldType);
                }
            }

            return base.CreateMemberValueProvider(member);
        }

        protected virtual void ModifyProperty(MemberInfo member, JsonProperty property)
        {
            if (property.PropertyType != typeof(DateTime) && property.PropertyType != typeof(DateTime?))
            {
                return;
            }

            var converter = new IsoDateTimeConverter();
            converter.DateTimeFormat = "yyyyMMddHHmmss";

            property.Converter = converter;
        }

        public class NullableValueProvider : IValueProvider
        {
            private readonly object defaultValue;
            private readonly IValueProvider valueProvider;
            public NullableValueProvider(MemberInfo member, Type type)
            {
                valueProvider = new ExpressionValueProvider(member);
                if (type != typeof(string))
                {
                    defaultValue = Activator.CreateInstance(type);
                }
                else
                {
                    defaultValue = string.Empty;
                }
            }

            public object GetValue(object target)
            {
                return valueProvider.GetValue(target) ?? defaultValue;
            }

            public void SetValue(object target, object value)
            {
                valueProvider.SetValue(target, value);
            }
        }
    }
}
