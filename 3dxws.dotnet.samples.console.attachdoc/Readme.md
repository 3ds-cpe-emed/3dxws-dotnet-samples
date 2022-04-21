# 3DEXPERIENCE Web Services C# Sample
## .NET Console app for attaching a file to a physical prouct
This example uploads a local file to 3DEXPERIENCE and attaches it to an existing physical product. This is achieved in two steps:
- Step 1 - Authentication - creates an authenticated session
- Step 2 - Local file upload and attachment to a physical product. 

The following table details the input arguments required for the process,
### Arguments
| Name | Position | Alias | Type | Example |  Description |
| ------ | ------ | ------ | ------ | ------ | ------ |
| Username | 0 | u | String | AAA27 | 3DEXPERIENCE username |
| Password | 1 | p | String | ***** | 3DEXPERIENCE password |
| EnoviaUrl | 2 | space | String | https://r1132100982379-eu1-space.3dexperience.3ds.com/enovia | 3DEXPERIENCE 3DSpace URL |
| PassportUrl | 3 | iam | String | https://eu1-ds-iam.3dexperience.3ds.com/3DPassport | 3DEXPERIENCE Passport URL |
| TenantId | 4 | t | String | R1132100982379 | 3DEXPERIENCE Tenant name |
| IsCloud | 5 | cloud | String | true | Is this a 3DEXPERIENCE Cloud environment? (true/false)  |
| SecurityContext | 6 | ctx | String | VPLMProjectLeader.Company Name.AAA27 Persona | 3DEXPERIENCE Security Context |
| DocTitle | 7 | title | String | "Document Title" | Document Title |
| DocDescription | 8 | desc | String | "" | Document Description |
| DocParentId | 9 | pid | String | 6B51CE1200007082624566530000D899 | Document owner Physical Id |
| DocFileLocalPath | 10 | file | String | "C:\temp\TestDoc.xlsx" | Document Local file path |


