namespace Soenneker.Tags.Util.Abstract;

public interface ITagsUtil
{
    /// <summary>
    /// Opens a media file using TagLibSharp, logs tag information, and logs errors if they occur.
    /// The file is not stored beyond the scope of this method.
    /// </summary>
    /// <param name="filePath">The path to the media file.</param>
    void OpenFile(string filePath);
}