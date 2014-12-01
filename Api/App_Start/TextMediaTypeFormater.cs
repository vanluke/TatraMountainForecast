using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Api.App_Start
{


    /// <summary>
    /// Type Formatter for plain text.
    /// </summary>
    public class TextMediaTypeFormatter : MediaTypeFormatter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextMediaTypeFormatter" /> class.
        /// </summary>
        public TextMediaTypeFormatter()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/xml"));
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/plain"));
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/javascript"));
        }

        /// <summary>
        /// Read from stream.
        /// </summary>
        /// <param name="type">Type.</param>
        /// <param name="readStream">Read stream.</param>
        /// <param name="content">Http content.</param>
        /// <param name="formatterLogger">Formatter logger.</param>
        /// <returns>Object.</returns>
        public override Task<object> ReadFromStreamAsync(Type type, Stream readStream, HttpContent content, IFormatterLogger formatterLogger)
        {
            var taskCompletionSource = new TaskCompletionSource<object>();
            try
            {
                var memoryStream = new MemoryStream();
                readStream.CopyTo(memoryStream);
                var s = System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());
                taskCompletionSource.SetResult(s);
            }
            catch (Exception e)
            {
                taskCompletionSource.SetException(e);
            }

            return taskCompletionSource.Task;
        }

        /// <summary>
        /// Can read type.
        /// </summary>
        /// <param name="type">Type.</param>
        /// <returns>Value indicating if model binder can read specified type.</returns>
        public override bool CanReadType(Type type)
        {
            return type == typeof(string);
        }

        /// <summary>
        /// Can write type.
        /// </summary>
        /// <param name="type">Type.</param>
        /// <returns>Value indicating if model binder can write specified type.</returns>
        public override bool CanWriteType(Type type)
        {
            return false;
        }
    }

}