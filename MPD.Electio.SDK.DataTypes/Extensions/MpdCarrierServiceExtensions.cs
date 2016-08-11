using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using MPD.Electio.SDK.DataTypes.CarrierServiceDirectory;
using MPD.Electio.SDK.DataTypes.Common;
using MpdCarrierServiceType = MPD.Electio.SDK.DataTypes.Common.Enums.MpdCarrierServiceType;

namespace MPD.Electio.SDK.DataTypes.Extensions
{
    /// <summary>
    /// Extension methods for MpdCarrierServices.
    /// </summary>
    public static class MpdCarrierServiceExtensions
    {
        /// <summary>
        /// Determines whether the given MPD Carrier Service is an Electio service
        /// or owned by the Customer.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static bool IsElectioService(this MpdCarrierService source)
        {
            return source.Source == MpdCarrierServiceSource.Internal;
        }

        /// <summary>
        /// Determines whether the given MPD Carrier Service is a Drop Off service
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static bool IsDropOff(this MpdCarrierService source)
        {
            return IsFlagSet(source, MpdCarrierServiceType.DropOff);
        }

        /// <summary>
        /// Determines whether the given MPD Carrier Service is a Pick Up service.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static bool IsPickUp(this MpdCarrierService source)
        {
            return IsFlagSet(source, MpdCarrierServiceType.PickUp);
        }

        /// <summary>
        /// Determines whether the given MPD Carrier Service is a Timed service -
        /// ie. The carrier provides timed delivery windows.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static bool IsTimed(this MpdCarrierService source)
        {
            return IsFlagSet(source, MpdCarrierServiceType.Timed);
        }

        /// <summary>
        /// Determines whether the given MPD Carrier Service is a Consolidated service.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static bool IsConsolidated(this MpdCarrierService source)
        {
            return IsFlagSet(source, MpdCarrierServiceType.Consolidated);
        }

        /// <summary>
        /// Determines whether the given MPD Carrier Service is an Ad-Hoc service.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static bool IsAdHoc(this MpdCarrierService source)
        {
            return IsFlagSet(source, MpdCarrierServiceType.AdHoc);
        }

        /// <summary>
        /// Determines whether the given MPD Carrier Service is a Scheduled service.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static bool IsScheduled(this MpdCarrierService source)
        {
            return IsFlagSet(source, MpdCarrierServiceType.Scheduled);
        }

        /// <summary>
        /// Determines whether the given flag is set.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="flag">The flag.</param>
        /// <returns></returns>
        public static bool IsFlagSet(this MpdCarrierService source, MpdCarrierServiceType flag)
        {
            return source.Type.HasFlag(flag);
        }

        /// <summary>
        /// Gets the flags.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static IEnumerable<MpdCarrierServiceType> GetFlags(this MpdCarrierService source)
        {
            return Enum.GetValues(typeof(MpdCarrierServiceType)).Cast<MpdCarrierServiceType>().Where(source.IsFlagSet);
        }

        /// <summary>
        /// Gets the description of an enum value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string GetDescription<T>(this T value) where T : struct
        {
            var name = Enum.GetName(typeof(T), value);
            if (name != null)
            {
                var field = typeof(T).GetField(name);
                if (field != null)
                {
                    var attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }
    }
}
