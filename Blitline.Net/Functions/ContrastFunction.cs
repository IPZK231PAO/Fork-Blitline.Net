﻿namespace Blitline.Net.Functions
{
    /// <summary>
    /// Adjusts contrasts within the image.
    /// </summary>
    public class ContrastFunction : BlitlineFunction
    {
        public override string Name
        {
            get { return "contrast"; }
        }

        public override object Params { get; protected set; }

        /// <summary>
        /// Contrast is increased if true (defaults to false)
        /// </summary>
        /// <param name="sharpen"></param>
        public ContrastFunction(bool sharpen = false)
        {
            @Params = new
                {
                    sharpen
                };
        }
    }
}