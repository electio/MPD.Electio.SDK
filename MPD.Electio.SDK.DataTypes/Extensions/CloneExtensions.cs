using System;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.Extensions
{
    public static class CloneExtensions
    {
        /// <summary>
        /// Makes a clone (copy) of the supplied instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instanceToClone"></param>
        /// <returns></returns>
        public static T CloneMe<T>(this T instanceToClone) where T : class
        {
            if (instanceToClone == null)
                return null;

            try
            {
                var serializeObject = JsonConvert.SerializeObject(instanceToClone);

                var copy = JsonConvert.DeserializeObject<T>(serializeObject);

                return copy;
            }
            catch (Exception exception)
            {
                throw new Exception("An error occurred during the cloning of this instance. See inner exception for details.", exception);
            }
        }
    }
}