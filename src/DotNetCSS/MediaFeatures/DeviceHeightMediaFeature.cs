﻿
namespace DotNetCSS
{
    internal sealed class DeviceHeightMediaFeature : MediaFeature
    {
        public DeviceHeightMediaFeature(string name)
            : base(name)
        {
        }

        internal override IValueConverter Converter => Converters.LengthConverter;

    }
}