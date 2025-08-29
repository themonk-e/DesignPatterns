using System.Security;
using System.Text;
using System.Transactions;

namespace designPattern.Structural.Composite
{
    public class Folder : IData
    {

        private List<string> FolderPermissions = new List<string>();
        private List<IData> FolderData= new List<IData>();


        private string FolderName;
        public Folder(string folderName)
        {
            FolderName = folderName;
        }

        public void Add(IData data)
        {
            FolderData.Add(data);
            ApplyPermissionToFolderData(data);
            
        }

        public void AddPermission(string permission)
        {
            FolderPermissions.Add(permission);

            foreach (var data in FolderData)
            {
                ApplyPermissionToFolderData(data);
            }


        }

        public void RemovePermission(string permission)
        {
            FolderPermissions.Remove(permission);
            foreach (var data in FolderData)
            {
                ApplyPermissionToFolderData(data);
            }
        }

        public void RemovePermissionToFolderData(IData data)
        {
           foreach (var folderPermission in FolderPermissions)
            {
                data.RemovePermission(folderPermission);
            }   
        }

        public void ApplyPermissionToFolderData(IData data)
        {
            foreach (var folderPermission in FolderPermissions)
            {
                data.AddPermission(folderPermission);
            }
        }

        public void DisplayProperties()
        {
            StringBuilder permissionDetails = new StringBuilder();
            foreach (var permission in FolderPermissions)
            {
                permissionDetails.Append(permission);
                permissionDetails.Append(" ");
            }
            Console.WriteLine($"📂{FolderName} Permissions[{permissionDetails.ToString().Substring(0,permissionDetails.ToString().Length-1)}]");

            foreach (var data in FolderData)
            {
                Console.Write(" ");
                data.DisplayProperties();
            }

        
        }
        
    }
}