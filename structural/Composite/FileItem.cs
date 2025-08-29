using System.Text;

namespace designPattern.Structural.Composite
{
    public class FileItem : IData
    {

        private HashSet<string> Permissions = new HashSet<string>();
        private string FileItemName;
        public FileItem(string fileName)
        {
            FileItemName = fileName;
        }

        public void AddPermission(string permission)
        {
            Permissions.Add(permission);
        }

        public void RemovePermission(string permission)
        {
            Permissions.Remove(permission);
         }

        public void DisplayProperties()
        {
            StringBuilder permissionDetails = new StringBuilder();
            foreach (var permission in Permissions)
            {
                permissionDetails.Append(permission);
                permissionDetails.Append(" ");
            }
       
            Console.WriteLine($"📄{FileItemName} Permissions[{permissionDetails.ToString().Substring(0, permissionDetails.ToString().Length - 1)}]");


        }
        
    }
}