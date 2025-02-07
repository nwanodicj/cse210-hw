using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Transactions;

namespace YouTubeVideos
{
    public class Comment
    {
        public string _UserName;
        public string _Text;
        public DateTime _PostedDate;
        public Comment()
        {

        }

        public Comment(string username, string text, DateTime postedDate)
        {
            _UserName = username;
            _Text = text;
            _PostedDate = postedDate;
        }
        public override string ToString()
        {
            return $"UserName: {_UserName} \nPostedDateTime: {_PostedDate} \nComment: {_Text}";
        }
        public string GetNumberOfComment()
        {
            return ToString();

        }
    }
}