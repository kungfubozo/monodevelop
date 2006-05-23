// created on 11/9/2004 at 1:39 AM
namespace MonoDevelop.Ide.Gui.Content
{
	public interface ICodeStyleOperations {
		void CommentCode ();
		void UncommentCode ();
		void IndentSelection ();
		void UnIndentSelection ();
		void UppercaseSelection ();
		void LowercaseSelection ();
	}
}