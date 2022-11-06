namespace ClassBoxData
{
    using System;
    using System.Text;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException
                        (string.Format(ExceptionMessages.ZeroOrNegativeError, nameof(this.Length)));
                }

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException
                        (string.Format(ExceptionMessages.ZeroOrNegativeError, nameof(this.Width)));
                }

                this.width = value;
            }
        }


        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException
                        (string.Format(ExceptionMessages.ZeroOrNegativeError, nameof(this.Height)));
                }

                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            return (2 * this.Length * this.Width) + (2 * this.Length * this.Height)
                + (2 * this.Width * this.Height);
        }

        public double LateralSurfaceArea()
        { 
            return (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
        }

        public double Volume()
        {
            return this.Height * this.Width * this.Length;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.SurfaceArea():f2}")
              .AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}")
              .AppendLine($"Volume - {this.Volume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
