﻿using N2.Integrity;
using N2.Definitions;
using N2.Installation;

namespace N2.Edit.FileSystem.Items
{
    [PageDefinition("File Folder", 
		Description = "A node that maps to files in the file system.",
		SortOrder = 600, 
		InstallerVisibility = InstallerHint.NeverRootOrStartPage,
		IconUrl = "~/Edit/img/ico/folder.gif",
		TemplateUrl = "~/Edit/FileSystem/Directory.aspx")]
    [RestrictParents(typeof(IFileSystemContainer))]
    [ItemAuthorizedRoles("Administrators", "admin")]
    [Editables.EditableFolderPath]
    public class RootDirectory : AbstractDirectory
    {
        public RootDirectory()
        {
            Visible = false;
            SortOrder = 10000;
        }
    }
}
