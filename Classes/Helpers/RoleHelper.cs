namespace DSAFinalRequirement.Classes.Helpers
{
    public static class RoleHelper
    {
        public static bool IsAdmin()
        {
            return Session.Role != null &&
                Session.Role.Equals("Admin", System.StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsStaff()
        {
            return Session.Role != null &&
                Session.Role.Equals("Staff", System.StringComparison.OrdinalIgnoreCase);

        }
        public static bool HasPermission(string requiredRole)
        {
            return Session.Role != null &&
                Session.Role.Equals(requiredRole, System.StringComparison.OrdinalIgnoreCase);
        }
    }
}