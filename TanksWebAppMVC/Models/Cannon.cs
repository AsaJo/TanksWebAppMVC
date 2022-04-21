using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TanksWebAppMVC.Models
{
    public class Cannon
    {
        public Cannon(string designation, double caliber, double shellVelocity, int maxRange, int clipSize, double intraClipReload, double reloadSpeed)
        {
            Designation = designation;
            Caliber = caliber;
            ShellVelocity = shellVelocity;
            MaxRange = maxRange;
            ClipSize = clipSize;
            IntraClipReload = intraClipReload;
            ReloadSpeed = reloadSpeed;
        }

        public string Designation { get; set; }
        public double Caliber { get; set; }
        public double ShellVelocity { get; set; }
        public int MaxRange { get; set; }
        public int ClipSize { get; set; }
        public double IntraClipReload { get; set; }
        public double ReloadSpeed { get; set; }

    }
}

