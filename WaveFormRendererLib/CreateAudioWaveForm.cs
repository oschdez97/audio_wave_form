using NAudio.WaveFormRenderer;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;

namespace WaveFormRendererLib
{
    public static class CreateAudioWaveForm
    {
        public static void Create(string audioPath, string storePath)
        {
            MaxPeakProvider maxPeakProvider = new MaxPeakProvider();
            RmsPeakProvider rmsPeakProvider = new RmsPeakProvider(200); // e.g. 200
            SamplingPeakProvider samplingPeakProvider = new SamplingPeakProvider(200); // e.g. 200
            AveragePeakProvider averagePeakProvider = new AveragePeakProvider(4); // e.g. 4

            StandardWaveFormRendererSettings myRendererSettings = new StandardWaveFormRendererSettings();
            myRendererSettings.Width = 1080;
            myRendererSettings.TopHeight = 64;
            myRendererSettings.BottomHeight = 64;

            WaveFormRenderer renderer = new WaveFormRenderer();
            var image = renderer.Render(audioPath, averagePeakProvider, myRendererSettings);
            image.Save(storePath, ImageFormat.Png);
        }
    }
}
