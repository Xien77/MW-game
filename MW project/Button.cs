using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW_project
{
    class Button
    {
        public new Vector2 Position;
        public Texture2D Texture;
        public int Width;
        public int Heigth;
        private Color _color;
        public Color Color
        {
            get { return _color; }
            set
            {
                _color = value;
                Color[] square = new Color[Width * Heigth];
                for (int i = 0; i < square.Length; i++) square[i] = value;
                Texture.SetData(square);
            }
        }




        public Button(int positionX, int positionY, int heigth, int width, Color color)
        {
            Width = width;
            Heigth = heigth;
            

            Position = new Vector2(positionX, positionY);           
            Texture = new Texture2D(Game1.instance.GraphicsDevice, width, heigth);

            Color = color;


        }


        public bool MouseTracking()
        {
            
            if (Mouse.GetState().X >= Position.X && Mouse.GetState().X <= Position.X + Width)
            { if (Mouse.GetState().Y >= Position.Y && Mouse.GetState().Y <= Position.Y + Heigth)
                {
                    Console.WriteLine("true in tracking");
                    return true;

                }

            }
            return false;
        }

        public bool IsClicked()
        {
            if (MouseTracking() && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                return true;
                
            }
            return false;
        }

        public void Update()
        {
            
            if (IsClicked())
            {
                
                this.Color = Color.GreenYellow;
            }
            Console.WriteLine(this.Color);
        }


    

    

     
    }
}
