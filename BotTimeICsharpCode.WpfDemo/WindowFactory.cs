using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BotTimeICsharpCode.WpfDemo
{
    public static class WindowFactory
    {
        /// <summary>
        /// 获取 没有则new
        /// </summary>
        /// <param name="mType"></param>
        /// <returns></returns>
        public static object Get(Type mType, object[] objects)
        {
            var model = Application.Current.Properties[nameof(WindowFactory)] as Dictionary<string, object>;
            if (model.ContainsKey(mType.FullName))
                return model[mType.FullName];
            else
            {
                var newModel = Activator.CreateInstance(mType, objects);
                model.Add(mType.FullName, newModel);
                return newModel;
            }
        }

        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="mType"></param>
        public static void Remove(Type mType)
        {
            var dictionary =
                Application.Current.Properties[nameof(WindowFactory)] as Dictionary<string, object>;
            if (dictionary.ContainsKey(mType.FullName))
                dictionary.Remove(mType.FullName);
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="mType"></param>
        /// <returns></returns>
        public static object Reset(Type mType, object[] objects)
        {
            Remove(mType);
            return Get(mType, objects);
        }

        /// <summary>
        /// 查找,没有则返回null
        /// </summary>
        /// <param name="mType"></param>
        /// <returns></returns>
        public static object Find(Type mType)
        {
            var dictionary = Application.Current.Properties[nameof(WindowFactory)] as Dictionary<string, object>;
            return dictionary.ContainsKey(mType.FullName) ? dictionary[mType.FullName] : null;
        }
    }
}
