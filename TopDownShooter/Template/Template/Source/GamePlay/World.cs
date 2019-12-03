#region Includes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
#endregion

namespace Template
{
    public class World
    {
        public Hero player;

        public World()
        {
            player = new Hero("2d\\player", new Vector2(300, 440), new Vector2(60, 100));
        }

        public virtual void Update()
        {
            player.Update();
        }

        public virtual void Draw(Vector2 OFFSET)
        {
            player.Draw(OFFSET);
        }
    }
}
