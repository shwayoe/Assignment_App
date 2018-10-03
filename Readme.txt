To start using this project.

First >> Open the Microsoft SQl Server Management Studio >> Connect to the server >> two .mdf and .ldf files from App_Data from project file >>right click on Database and click Attach.
Attach the including .mdf file and click Add. 

Second >> open the YuneNadiOo project with Microsoft Visual Studio (click .sln file) >> go to Web.config file >> find <connectionString> or data source >> change "DefaultConnection" with "AssignmentEntities2".

Third >> Clean and Rebuild the project >> Run the HomeController of Index.cshtml

Final >>you can see the web page.

---------------------------------------------------
