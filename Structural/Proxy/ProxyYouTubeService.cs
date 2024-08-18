using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyYouTubeService : IYouTubeService
    {
        private YouTubeService _ytService;
        private Dictionary<long, byte[]> _cache = new();

        public ProxyYouTubeService(YouTubeService youTubeService)
        {
            _ytService = youTubeService;
        }

        public byte[] GetVideo(long videoId)
        {
            if (_cache.TryGetValue(videoId, out byte[] cachedVideo))
            {
                return cachedVideo;
            }

            byte[] downloadedVideo = _ytService.GetVideo(videoId);
            _cache.Add(videoId, downloadedVideo);
            return downloadedVideo;
        }
    }
}
