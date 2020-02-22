using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Duel_GUI
{
    public class GenerateFrames
    {
        /// <summary>
        /// A class that generates a Image array from a gif;
        /// </summary>
        private Image[] Frames { get; set; }

        private readonly int Length = 0;

        /// <summary>
        /// Constuctor 
        /// </summary>
        /// <param name="original_gif">The original gif</param>
        public GenerateFrames (Image original_gif)
        {
            ///Get the frame count of the gif
            Length = original_gif.GetFrameCount(FrameDimension.Time);

            ///New image array to store the extracted frames
            Frames = new Image[Length];

            ///Loop through the gif and store each frame in the frames array
            for (int index = 0; index < Length; index++)
            {
                original_gif.SelectActiveFrame(FrameDimension.Time, index);
                Frames[index] = new Bitmap(original_gif);
            }
        }

        public int GetLength()
        {
            return Length;
        }

        public Image GetImages(int index)
        {
            return Frames[index];
        }

        /// <summary>
        /// A method that extracts the frames of a gif and flips the image horizantally.
        /// This method is untest.
        /// </summary>
        /// <param name="originalGif">The original gif</param>
        /// <returns>Array of image frames</returns>
        private Image[] GetFlippedFrames(Image originalGif)
        {
            //Get the frame count of the gif
            int numberOfFrames = originalGif.GetFrameCount(FrameDimension.Time);

            //New image array to store the extracted frames
            Image[] frames = new Image[numberOfFrames];

            //Loop through the gif and store each frame in the frames array
            for (int i = 0; i < numberOfFrames; i++)
            {
                originalGif.SelectActiveFrame(FrameDimension.Time, i);
                frames[i] = new Bitmap(originalGif);
                frames[i].RotateFlip(RotateFlipType.RotateNoneFlipX);
                //frames[i] = ((Image)originalGif.Clone());
            }

            return frames;
        }
    }
}
