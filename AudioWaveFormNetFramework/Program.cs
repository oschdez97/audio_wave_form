using NAudio.WaveFormRenderer;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveFormRendererLib;

namespace AudioWaveFormNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            string audioPath = @"C:\Users\root\Desktop\Tomorrow Is A Long Time.mp3";
            string storePath = @"C:\Users\root\Desktop\mywave.png";
            CreateAudioWaveForm.Create(audioPath, storePath);
        }
    }
}
