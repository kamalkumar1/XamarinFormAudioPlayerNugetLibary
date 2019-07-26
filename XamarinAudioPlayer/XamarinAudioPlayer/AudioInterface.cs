
using System;

namespace XamarinAudioPlayer
{
    /// <summary>
    /// Interface class to acess native libary
    /// </summary>
    public interface IAudioInterface
    {
        /// <summary>
        /// Used  to Get the File Path of the audio Player
        /// </summary>
        void SetUpAudio(string filename,string filetype);
        /// <summary>
        /// Used  to play the Audio
        /// </summary>
        void Play();
        /// <summary>
        /// Used  to pause the Audio
        /// </summary>
        void Pause();
        /// <summary>
        /// Used  to Restart the Audio
        /// </summary>
        void Restart();
        /// <summary>
        /// Used  to audio  instance
        /// </summary>
        void RemoveNotification();
        /// <summary>
        /// Get current audio play time
        /// </summary>
        object PlayerCurrettime();
        /// <summary>
        /// Get total audio play time
        /// </summary>
        object GetTotaltime();
        /// <summary>
        /// Get total audio play time
        /// </summary>
        object MediaTotalDuration();
        event EventHandler PositionChanged;
    }
}
