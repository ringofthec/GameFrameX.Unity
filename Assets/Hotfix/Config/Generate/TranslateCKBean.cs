
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
    /// <summary>
    /// 用于保存中文原content以及对应的国际化Key
    /// </summary>
    public sealed partial class TranslateCKBean : LuBan.Runtime.BeanBase
    {
        public TranslateCKBean(string Content, string Key) 
        {
            this.Content = Content;
            this.Key = Key;
            PostInit();
        }

        public TranslateCKBean(JSONNode _buf)
        {
            { if(!_buf["content"].IsString) { throw new SerializationException(); }  Content = _buf["content"]; }
            { if(!_buf["key"].IsString) { throw new SerializationException(); }  Key = _buf["key"]; }

            // Localization Key Begin
            // Localization Key End
            PostInit();
        }

        public static TranslateCKBean DeserializeTranslateCKBean(JSONNode _buf)
        {
            return new TranslateCKBean(_buf);
        }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { private set; get; }
        /// <summary>
        /// 对应Key
        /// </summary>
        public string Key { private set; get; }
        public const int __ID__ = 1171657446;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            
        }

        public void TranslateText(System.Func<string, string, string> translator)
        {
        }

        public override string ToString()
        {
            return "{ "
            + "content:" + Content + ","
            + "key:" + Key + ","
            + "}";
        }

        partial void PostInit();
    }
}
