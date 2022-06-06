﻿using System.Collections.Generic;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
namespace AdhocReading;

[TestClass]
public class WorkingWithImages
{
    [TestMethod]
    public void ImageTest()
    {
        string imagesFolder = Path.Combine(Environment.CurrentDirectory, "images");
        IEnumerable<string> images = Directory.EnumerateFiles(imagesFolder);

        foreach (string imagePath in images)
        {
            string thumbnailPath = Path.Combine(
            Environment.CurrentDirectory, "images",
            Path.GetFileNameWithoutExtension(imagePath)
            + "-thumbnail" + Path.GetExtension(imagePath));
            using (Image image = Image.Load(imagePath))
            {
                image.Mutate(x => x.Resize(image.Width / 10, image.Height / 10));
                image.Mutate(x => x.Grayscale());
                image.Save(thumbnailPath);
            }
        }
        Console.WriteLine("Image processing complete. View the images folder.");

    }
}
