
    using System.Diagnostics;
    using System.Drawing;
    using Novacode;

class WordDocumentGenerator
    {
        static void Main()
        {
            // creating the document
            string filename =
                @"C:\Users\Simooo\Documents\Visual Studio 2013\Projects\OOP\OtherTypes\WordDocumentGenerator\GameContest.docx";
            var document = DocX.Create(filename);

            // headline
            string headLine = "SoftUni OOP Game Contest";
            Paragraph head = document.InsertParagraph(headLine);
            head.Color(Color.Black);
            head.Font(new FontFamily("Calibri"));
            head.Bold();
            head.FontSize(20D);          
            head.Alignment = Alignment.center;
            head.Position(5D);


            // Creating picture
            string imagePath = @"../../rpg-game.png";
            Picture pic = document.AddImage(imagePath).CreatePicture();
            pic.Width = 582;
            pic.Height = 225;
            
            // inserting picture
            Paragraph picture = document.InsertParagraph();
            picture.InsertPicture(pic);
            picture.Position(20D);
            
            // Main paragraph
            Paragraph mainParagraph = document.InsertParagraph();
            mainParagraph.Append("Softuni is organizing a contest for the best ")
                .Append("role playing game ").Bold()
                .Append("from the OOP teamwork\n")
                .Append("projects. The winning teams will receive a ");
            

            document.Save();

            Process.Start(filename);
        }
    }

