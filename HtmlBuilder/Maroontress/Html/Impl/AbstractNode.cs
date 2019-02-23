namespace Maroontress.Html.Impl
{
    using System.IO;

    /// <summary>
    /// Provides common implementation of the Node instances.
    /// </summary>
    public abstract class AbstractNode : Node
    {
        /// <inheritdoc/>
        public abstract void Accept(NodeVisitor visitor);

        /// <inheritdoc/>
        public override sealed string ToString()
        {
            var writer = new StringWriter();
            Accept(new TextWriterVisitor(writer));
            writer.Close();
            return writer.ToString();
        }
    }
}