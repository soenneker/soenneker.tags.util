namespace Soenneker.Tags.Util.Abstract;

/// <summary>
/// Defines the tags util contract.
/// </summary>
public interface ITagsUtil
{
    /// <summary>
    /// Opens a media file using TagLibSharp, logs tag information, and logs errors if they occur.
    /// The file is not stored beyond the scope of this method.
    /// </summary>
    /// <param name="filePath">Path of the file to use.</param>
    /// <returns>The resulting tag Lib.File.</returns>
    TagLib.File? OpenFile(string filePath);
}
