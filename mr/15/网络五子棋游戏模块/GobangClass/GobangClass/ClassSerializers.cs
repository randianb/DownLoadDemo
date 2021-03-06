using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GobangClass
{
    /// <summary>
    /// 对象与二进制流的互相转换。
    /// </summary>
    public class ClassSerializers
    {
        public ClassSerializers()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        #region 对象与二进制流的互相转换
        /// <summary>
        /// 将对象流转换成二进制流
        /// </summary>
        public System.IO.MemoryStream SerializeBinary(object request) //将对象流转换成二进制流
        {
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter serializer = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            System.IO.MemoryStream memStream = new System.IO.MemoryStream();    //创建一个内存流存储区
            serializer.Serialize(memStream, request);//将对象序列化为内存流中
            return memStream;
        }

        /// <summary>
        /// 将二进制流转换成对象
        /// </summary>
        public object DeSerializeBinary(System.IO.MemoryStream memStream) //将二进制流转换成对象
        {
            memStream.Position = 0;
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter deserializer = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            object newobj = deserializer.Deserialize(memStream);//将内存流反序列化为对象
            memStream.Close();  //关闭内存流，并释放
            return newobj;
        }
        #endregion
    }
}
