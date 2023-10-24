using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Main.Controllers
{
    abstract class BaseController
    {
        public BaseController()
        {

        }
        public abstract void Play(object sender, EventArgs e);

        public abstract void Pause(object sender, EventArgs e);

        public abstract void Resume(object sender, EventArgs e);

        public abstract void Stop(object sender, EventArgs e);

        public abstract void ChangeVolume(object sender, EventArgs e);

        public abstract void ChangeVoice(object sender, EventArgs e);

        public abstract void ChangeRate(object sender, EventArgs e);

    }
}
