using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.MediaElements;
using MediaLibrary.BuilderMediaCollections;


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
            // MusicTrack tracks
            MusicTrack music_track_1 = new MusicTrack("music_track_obj_1.mp3", "Brickman - 313\008", "https://musictrackurl1.com");
            MusicTrack music_track_2 = new MusicTrack("music_track_obj_2.mp3", "Young M.A - Eat", "https://musictrackurl2.com");
            MusicTrack music_track_3 = new MusicTrack("music_track_obj_3.mp3", "Haelos - Dust", "https://musictrackurl3.com");
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
            
            LibraryDirector Library = new LibraryDirector();

            //Create event library "Event1" with all media elements
            CollectionLibraryCreater EventBuilder;
            EventBuilder = new EventCreater("Event1");
            Library.Create(EventBuilder, AllMedia);
            EventBuilder.CollLib.ShowParts();            

            Console.ReadKey();
        }
    }
}
