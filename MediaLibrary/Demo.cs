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
        static void Main(string[] args)
        {
            // Photo
            Photo photo_1 = new Photo("photo_obj_1.jpg", "My birthday", "https://photourl1.com");
            Photo photo_2 = new Photo("photo_obj_2.jpg", "Holiday", "https://photourl2.com");
            Photo photo_3 = new Photo("photo_obj_3.jpg", "On work", "https://photourl3.com");
            // Music tracks
            Music music_track_1 = new Music("music_track_obj_1.mp3", "Brickman - 313\008", "https://musictrackurl1.com");
            Music music_track_2 = new Music("music_track_obj_2.mp3", "Young M.A - Eat", "https://musictrackurl2.com");
            Music music_track_3 = new Music("music_track_obj_3.mp3", "Haelos - Dust", "https://musictrackurl3.com");
            // Video tracks
            Video video_track_1 = new Video("video_track_obj_1.avi", "Surprise on birthday", "https://videotrackurl1.com");
            Video video_track_2 = new Video("video_track_obj_2.avi", "In Moscow", "https://videotrackurl2.com");
            Video video_track_3 = new Video("video_track_obj_3.avi", "Joke", "https://videotrackurl3.com");
            List<Media> AllMedia = new List<Media>
            {
                photo_1, photo_2, photo_3,
                music_track_1, music_track_2, music_track_3,
                video_track_1, video_track_2, video_track_3
            };
            
            LibDirector Library = new LibDirector();

            //Create event library "Event1" with all media elements
            CollLibBuilder Event1;
            Event1 = new Event("Event1");
            Library.Create(Event1, AllMedia);
            Event1.CollLib.ShowParts();

            //Create event library "Event2" with selective media elements
            CollLibBuilder Event2;
            Event2 = new Event("Event2");
            Library.Create(Event2, new List<Media> {photo_1, photo_3, video_track_2 });
            Event2.CollLib.ShowParts();
            //Add media elements to "Event2" library
            Event2.AddPhoto(new List<Media> { photo_2 });
            Event2.CollLib.ShowParts();

            //Create disk library "Disk1" with selective elements
            CollLibBuilder Disk1;
            Disk1 = new Event("Disk1");
            Library.Create(Disk1, new List<Media> { photo_1, photo_3, music_track_1, video_track_2 });//incorrect input
            Disk1.CollLib.ShowParts();

            Console.ReadKey();
        }
    }
}
