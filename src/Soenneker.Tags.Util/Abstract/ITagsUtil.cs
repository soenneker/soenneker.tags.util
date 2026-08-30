namespace Soenneker.Tags.Util.Abstract;

/// <summary>
/// Defines the tags util contract.
/// </summary>
public interface ITagsUtil
{
    /// <summary>
    /// Opens a media file using TagLibSharp. Failures are logged and returned as <see langword="null"/>.
    /// </summary>
    /// <param name="filePath">Path of the file to use.</param>
    /// <returns>The opened TagLib file, which the caller must dispose; otherwise, <see langword="null"/> when the file could not be opened.</returns>
    TagLib.File? OpenFile(string filePath);
}
