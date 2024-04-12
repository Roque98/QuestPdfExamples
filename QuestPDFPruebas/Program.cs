using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using SkiaSharp;

// code in your main method
Document.Create(container =>
{
    
    container.Page(page =>
    {
        page.Size(PageSizes.A4);
        page.MarginTop(1f, Unit.Centimetre);
        page.MarginHorizontal(1.6f, Unit.Centimetre);
        page.PageColor("#FFFCF7");
        page.DefaultTextStyle(x =>
        {
            return x
                    .FontSize(10.8f)
                    .FontFamily("Poppins");
        });

        page.Content()
             .Height(180)
             //.Background(Colors.Green.Medium)
             .AlignMiddle()
             .Row(headerRow =>
             {
                 headerRow
                    .RelativeItem(4)
                    .Column(col =>
                    {
                        col
                            .Item()
                            .Row(rowLogo =>
                            {
                                rowLogo
                                    .AutoItem()
                                    .Width(30)
                                    .Height(40)
                                    
                                    .AlignLeft()
                                    .Canvas((canvas, size) =>
                                    {
                                    

                                        // Círculo rosa
                                        using var pinkPaint = new SKPaint
                                        {
                                            Color = SKColors.Pink,
                                            Style = SKPaintStyle.Fill
                                        };

                                        // Círculo negro
                                        using var blackPaint = new SKPaint
                                        {
                                            Color = SKColors.Black,
                                            Style = SKPaintStyle.Fill
                                        };

                                        // Mueve el origen al centro del espacio disponible
                                        canvas.Translate(size.Width / 2, size.Height / 2);

                                        // Dibuja el círculo rosa
                                        canvas.DrawCircle(0, 0, 13, pinkPaint);

                                        // Dibuja el círculo negro más pequeño dentro del círculo rosa
                                        canvas.DrawCircle(0, 0, 5, blackPaint);
                                    });


                                rowLogo
                                    .RelativeItem()
                                    .PaddingLeft(5)
                                    .AlignMiddle()
                                    .Text("Borcelle")
                                    .FontSize(23.4f)
                                    .FontFamily("Poppins")
                                    .Bold();
                            })
                            ;

                        col
                            .Item()
                            .Text("Revolutionising Machine\r\nFactory Production")
                            .FontSize(10.7f)
                            .LetterSpacing(-0.0f)
                            .LineHeight(0.9f);
                    });



                 headerRow
                    .RelativeItem(6)

                            .Height(100)
                    //.Background(Colors.Blue.Medium)
                    .Layers( layer =>
                    {
                     

                        layer
                            .Layer()
                                    //.Item()
                                    .TranslateY(5)
                                    .TranslateX(-20)
                                    .Background(Colors.White)
                                    .Border(0.5f)
                                    .PaddingTop(20)
                                    .PaddingHorizontal(20)
                                    .Text("Our innovative Borcelle product has revolutionised\r\nmachine industry production. Borcelle, a cutting-\r\nedge manufacturing process optimisation tool, has\r\nperformed well since its launch.")
                                    .LineHeight(1)
                                    .FontSize(10.8f)
                                    .LetterSpacing(-0.05f)
                                    .Light();

                        layer
                         .PrimaryLayer()
                         .TranslateX(0)
                         .TranslateY(-15)
                         .Height(30)
                         .Width(200)
                         .Background("#FFCFA1")
                         .Border(0.5f)
                         .AlignMiddle()
                         .AlignCenter()
                         .Text("Production Performance Data")
                         .FontSize(11.3f)
                         .Bold();
                    });
                    //.Column(colHeaderText =>
                    //{
                      

                    //    colHeaderText
                    //        .Item()
                    //        .TranslateX(20)
                    //        .Height(30)
                    //        .Width(200)
                    //        .Background("#FFCFA1")
                    //        .Border(0.5f)
                    //        .AlignMiddle()
                    //        .AlignCenter()
                    //        .Text("Production Performance Data")
                    //        .FontSize(11.3f)
                    //        .Bold()
                    //        ;

                    //    colHeaderText
                    //        .Item()
                    //        .TranslateY(-10)
                    //        .Background(Colors.White)
                    //        .Border(0.5f)                         
                    //        .PaddingVertical(10)
                    //        .PaddingHorizontal(20)
                    //        .Text("Our innovative Borcelle product has revolutionised\r\nmachine industry production. Borcelle, a cutting-\r\nedge manufacturing process optimisation tool, has\r\nperformed well since its launch.")
                    //        .FontSize(10.8f)
                    //        .LetterSpacing(-0.05f)
                    //        .Light();
                            
                    //});
                    
             });

        //page.Header()
        //    .Text("Hello PDF!")
        //    .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);


        //page.Content()
        //    .PaddingVertical(1, Unit.Centimetre)
        //    .Column(x =>
        //    {

        //    });

        //page.Footer()
        //    .AlignCenter()
        //    .Text(x =>
        //    {
        //        x.Span("Page ");
        //        x.CurrentPageNumber();
        //    });
    });
    // https://www.canva.com/design/DAGCEhDOEH8/PGUpfReyvNmEjEVXe_0BZQ/edit
    container.Page(page =>
    {
        const string color_primary = "#293039";
        const string color_secondary = "#7DD1B0";
        const string color_background = "#F3EDE0";


        page.Size(PageSizes.A4);
        page.PageColor(color_background);

        page
            .Header()
            .Background(color_secondary)
            .Height(202)
            .Row( headerRow =>
            {
                headerRow
                    .RelativeItem(8)
                    .PaddingTop(30)
                    .PaddingLeft(30)
                    .Text("PORTECTING OUR\nMOST PRECIOUS")
                    .FontSize(60.1f)
                    .FontFamily("Anton")
                    .LineHeight(0.65f);

                headerRow
                    .RelativeItem(4)
                    .PaddingTop(30)
                    .PaddingLeft(30)
                    .PaddingRight(30)
                    .Text("While the year brought many unique challenges, The Green Thumb Conservation Society remained focused, protecting many vulnerable environments across the globe.")
                    .LineHeight(0.90f)
                    ; 
            });

        page
            .Content()
            .PaddingHorizontal(20)
            .Table( table =>
            {
                table.ColumnsDefinition( columns =>
                {
                    columns.RelativeColumn(2);
                    columns.RelativeColumn(10);
                });


                // Banner annual impact
                table
                    .Cell()
                    .Row(1)
                    .Column(1)
                    .Height(440)
                    .Background(color_primary);

                //  Banner tree
                table
                    .Cell()
                    .Row(2)
                    .Column(1)
                    .Height(200)
                    .Background(color_secondary);

                // Main content
                table
                    .Cell()
                    .Row(1)
                    .Column(2)
                    .Height(440);

                // Footer content
                table
                    .Cell()
                    .Row(2)
                    .Column(2)
                    .Height(200)
                    .Column(colFooterContent =>
                    {
                        colFooterContent
                            .Item()
                            .Height(100)
                            .Background(color_primary);

                        colFooterContent
                            .Item()
                            .Background(Colors.Pink.Accent4);
                    });
            });
            
    });
})
.ShowInPreviewer();
