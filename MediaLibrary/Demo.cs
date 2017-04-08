using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.MediaElements;

namespace MediaLibrary
{
    class Demo
    {
        static void CreateMediaElements()
        {
            
        }

        static void Main(string[] args)
        {
            // Photo
            Photo photo_1 = new Photo("photo_obj_1", "My birthday", "https://photourl1.com");
            Photo photo_2 = new Photo("photo_obj_2", "Holiday", "https://photourl2.com");
            Photo photo_3 = new Photo("photo_obj_3", "On work", "https://photourl3.com");
            // Music tracks
            Music music_track_1 = new Music("music_track_obj_1", "Brickman - 313\008", "https://musictrackurl1.com");
            Music music_track_2 = new Music("music_track_obj_2", "Young M.A - Eat", "https://musictrackurl2.com");
            Music music_track_3 = new Music("music_track_obj_3", "Haelos - Dust", "https://musictrackurl3.com");
            // Video tracks
            Video video_track_1 = new Video("video_track_obj_1", "Surprise on birthday", "https://videotrackurl1.com");
            Video video_track_2 = new Video("video_track_obj_2", "In Moscow", "https://videotrackurl2.com");
            Video video_track_3 = new Video("video_track_obj_3", "Joke", "https://videotrackurl3.com"); 
        }
    }
}
