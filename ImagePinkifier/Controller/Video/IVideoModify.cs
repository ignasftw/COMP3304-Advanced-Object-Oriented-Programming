using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Controller.Video
{
    interface IVideoModify
    {
        /// <summary>
        /// METHOD: which applies an effect and then saves the video immediately
        /// </summary>
        /// <param name="video">Input of a video, pathfilename with extension</param>
        /// <param name="output">Where the video will be stored, custom location</param>
        /// <param name="modification">Action which modifies a single image and is aplied for a each frame of the video</param>
        /// <param name="videoDimensions">The size of the video</param>
        /// <param name="data">Parameters of how modification should be applied</param>
        void ApplyModification(string video, string output, Action<int[]> modification, Size videoDimensions, params int[] data);

        /// <summary>
        /// Save a video immediately after the effect has been applied
        /// <param name="input">(Video)Input of a video, pathfilename with extension</param>
        /// <param name="modification">Action which modifies a single image and is aplied for a each frame of the video</param>
        /// <param name="videoDimensions">The size of the video</param>
        /// <param name="data">Parameters of how modification should be applied</param>
        void SaveVideo(string input, Action<int[]> modification, Size videoDimensions, params int[] data);

        void Subscribe(VideoModify.ModificationAppliedEventHandler modificationApplied);

        void Unsubscribe(VideoModify.ModificationAppliedEventHandler modificationApplied);

    }
}
