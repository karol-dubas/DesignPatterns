using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    // External library
    public class YouTubeService : IYouTubeService
    {
        public byte[] GetVideo(long videoId)
        {
            Console.WriteLine($"Downloading video: {videoId}");

            return new byte[videoId];
        }
    }
}
