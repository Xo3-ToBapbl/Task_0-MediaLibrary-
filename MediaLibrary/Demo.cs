using System;
using System.Collections.Generic;
using MediaLibrary.MediaElements;
using MediaLibrary.CreaterMediaCollections;
using MediaLibrary.MediaCollectedElements;
using Player;


namespace Demonstration
{
    class Demo
    {     
        static void Main(string[] args)
        {
            #region Media Elements
            // Photo
            Photo photo_1 = new Photo("photo_obj_1.jpg", "Birthday", "https://photourl1.com");
            Photo photo_2 = new Photo("photo_obj_2.jpg", "Holiday", "https://photourl2.com");
            Photo photo_3 = new Photo("photo_obj_3.jpg", "On work", "https://photourl3.com");
            // MusicTrack tracks
            MusicTrack music_track_1 = new MusicTrack("music_track_obj_1.mp3", "Brickman - 313-008", "https://musictrackurl1.com");
            MusicTrack music_track_2 = new MusicTrack("music_track_obj_2.mp3", "Young M.A - Eat", "https://musictrackurl2.com");
            MusicTrack music_track_3 = new MusicTrack("music_track_obj_3.mp3", "Haelos - Dust", "https://musictrackurl3.com");
            // Video tracks
            Video video_track_1 = new Video("video_track_obj_1.avi", "Surprise on birthday", "https://videotrackurl1.com");
            Video video_track_2 = new Video("video_track_obj_2.avi", "In Moscow", "https://videotrackurl2.com");
            Video video_track_3 = new Video("video_track_obj_3.avi", "Joke", "https://videotrackurl3.com");
            #endregion
            
            LibraryDirector Library_Director = new LibraryDirector();
            MyPlayer My_Player = new MyPlayer();
          
            #region First Event Library
            // Create First Event Library
            CollectionLibraryCreater LibraryCreator_1 = new EventCreator
                ("First Event Library", new List<Media> { photo_2, video_track_3 });
            Event EventLibrary_1 = (Event)Library_Director.Create(LibraryCreator_1);
            if(EventLibrary_1 != null)
            {
                EventLibrary_1.ShowInfo();
            }
            #endregion

            #region Second Event Library
            // Create Second Event Library
            CollectionLibraryCreater LibraryCreator_2 = new EventCreator
                ("Second Event Library", new List<Media> { photo_1, photo_2, music_track_2 }); //Invalid items list
            Event EventLibrary_2 = (Event)Library_Director.Create(LibraryCreator_2);

            if (EventLibrary_2 != null)
            {
                EventLibrary_2.ShowInfo();
            }
            #endregion

            #region First Disk Library
            //Create First Disk Library
            CollectionLibraryCreater LibraryCreator_3 = new DiskCreator
                ("First Disk Library", new List<Media> { photo_1, photo_2, music_track_2, music_track_1, music_track_3 });
            Disk DiskLibrary1 = (Disk)Library_Director.Create(LibraryCreator_3);

            if (DiskLibrary1 != null)
            {
                DiskLibrary1.ShowInfo();
            }
            #endregion

            #region First Serial Library
            //Create First Serial Library
            CollectionLibraryCreater LibraryCreator_4 = new SerialCreator
                ("First Serial Library", new List<Media> { photo_1, video_track_3, video_track_2 });
            Serial SerialLibrary1 = (Serial)Library_Director.Create(LibraryCreator_4);

            if (SerialLibrary1 != null)
            {
                SerialLibrary1.ShowInfo();
            }
            #endregion

            #region Player
            List<Media> DiskForeignList = (List<Media>)DiskLibrary1.MediaElementCollection;
            List<Media> SerialForeignList = (List<Media>)SerialLibrary1.MediaElementCollection;

            My_Player.GetPlayList(DiskForeignList, SerialForeignList);
            My_Player.Play();
            #endregion

            Console.ReadKey();
        }
    }
}
