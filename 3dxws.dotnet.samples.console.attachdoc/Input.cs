using Ookii.CommandLine;

namespace _3dxws.dotnet.samples.console.attachdoc
{
    class Input
    {
        [CommandLineArgument(Position = 0, IsRequired = true, ValueDescription = "3DEXPERIENCE username"), Alias("u")]
        public string Username { get; set; }

        [CommandLineArgument(Position = 1, IsRequired = true, ValueDescription = "3DEXPERIENCE password"), Alias("p")]
        public string Password { get; set; }

        [CommandLineArgument(Position = 2, IsRequired = true, ValueDescription = "3DEXPERIENCE 3DSpace URL"), Alias("space")]
        public string EnoviaUrl { get; set; }

        [CommandLineArgument(Position = 3, IsRequired = true, ValueDescription = "3DEXPERIENCE Passport URL"), Alias("iam")]
        public string PassportUrl { get; set; }

        [CommandLineArgument(Position = 4, IsRequired = true, ValueDescription = "3DEXPERIENCE Tenant name"), Alias("t")]
        public string TenantId { get; set; }

        [CommandLineArgument(Position = 5, IsRequired = true, ValueDescription = "3DEXPERIENCE Cloud"), Alias("cloud")]
        public bool IsCloud { get; set; }

        [CommandLineArgument(Position = 6, IsRequired = true, ValueDescription = "3DEXPERIENCE Security Context"), Alias("ctx")]
        public string SecurityContext { get; set; }

        [CommandLineArgument(Position = 7, IsRequired = true, ValueDescription = "Document Title"), Alias("title")]
        public string DocTitle { get; set; }

        [CommandLineArgument(Position = 8, IsRequired = true, ValueDescription = "Document Description"), Alias("desc")]
        public string DocDescription { get; set; }

        [CommandLineArgument(Position = 9, IsRequired = true, ValueDescription = "Document owner Physical Id"), Alias("pid")]
        public string DocParentId { get; set; }

        [CommandLineArgument(Position = 10, IsRequired = true, ValueDescription = "Document Local file path"), Alias("file")]
        public string DocFileLocalPath { get; set; }
    }
}
