using System;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Security;

namespace MPD.Electio.SDK.DataTypes.Extensions
{
    public static class PermissionExtensions
    {
        public static Access ToPermissionAccessEnum(this string permissionGroupKey)
        {
            return ToPermissionAccessGroup(permissionGroupKey);
        }

        public static AccessActions ToPermissionActionEnum(this string permissionKey)
        {
            return ToPermissionAction(permissionKey);
        }

        private static string SanitiseName(string name)
        {
            return string.IsNullOrWhiteSpace(name) ? string.Empty : name.Replace("-", string.Empty);
        }

        private static Access ToPermissionAccessGroup(string permissionGroupKey)
        {
            if (string.IsNullOrWhiteSpace(permissionGroupKey))
            {
                return Access.None;
            }

            var nameSansHyphens = SanitiseName(permissionGroupKey);

            Access groupAccess;

            if (!Enum.TryParse(nameSansHyphens, true, out groupAccess))
            {
                groupAccess = Access.None;
            }

            return groupAccess;
        }

        private static AccessActions ToPermissionAction(string permissionKey)
        {
            if (string.IsNullOrWhiteSpace(permissionKey))
            {
                return AccessActions.None;
            }

            var nameSansHyphens = SanitiseName(permissionKey);

            AccessActions accessActions;

            if (!Enum.TryParse(nameSansHyphens, true, out accessActions))
            {
                accessActions = AccessActions.None;
            }

            return accessActions;
        }
    }
}
