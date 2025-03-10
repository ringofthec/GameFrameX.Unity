
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LuBan.Runtime;
using GameFrameX.Config;
using SimpleJSON;

namespace Hotfix.Config
{
    public sealed partial class VideoTextSubtitles : LuBan.Runtime.BeanBase
    {
        public VideoTextSubtitles(int Time, TranslateCKBean Content) 
        {
            this.Time = Time;
            this.Content = Content;
            PostInit();
        }

        public VideoTextSubtitles(JSONNode _buf)
        {
            { if(!_buf["Time"].IsNumber) { throw new SerializationException(); }  Time = _buf["Time"]; }
            { if(!_buf["Content"].IsObject) { throw new SerializationException(); }  Content = TranslateCKBean.DeserializeTranslateCKBean(_buf["Content"]);  }

            // Localization Key Begin
            // Localization Key End
            PostInit();
        }

        public static VideoTextSubtitles DeserializeVideoTextSubtitles(JSONNode _buf)
        {
            return new VideoTextSubtitles(_buf);
        }

        /// <summary>
        /// 时间
        /// </summary>
        public int Time { private set; get; }
        /// <summary>
        /// 字幕内容
        /// </summary>
        public TranslateCKBean Content { private set; get; }
        public const int __ID__ = -14693357;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            Content?.ResolveRef(tables);
        }

        public void TranslateText(System.Func<string, string, string> translator)
        {
        }

        public override string ToString()
        {
            return "{ "
            + "Time:" + Time + ","
            + "Content:" + Content + ","
            + "}";
        }

        partial void PostInit();
    }
}
