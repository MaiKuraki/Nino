/* this is generated by nino */
namespace Nino.Test
{
    public partial class CustomTypeTest
    {
        public static CustomTypeTest.SerializationHelper NinoSerializationHelper = new CustomTypeTest.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.ISerializationHelper<CustomTypeTest>
        {
            #region NINO_CODEGEN
            public void NinoWriteMembers(CustomTypeTest value, Nino.Serialization.Writer writer)
            {
                writer.WriteCommonVal(typeof(UnityEngine.Vector3), value.v3);
                writer.WriteCommonVal(typeof(System.DateTime), value.dt);
                writer.WriteCommonVal(typeof(System.Nullable<System.Int32>), value.ni);
                if(value.qs != null)
                {
                    writer.CompressAndWrite(value.qs.Count);
                    foreach (var entry in value.qs)
                    {
                        writer.WriteCommonVal(typeof(UnityEngine.Quaternion), entry);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                writer.WriteCommonVal(typeof(UnityEngine.Matrix4x4), value.m);
                if(value.dict != null)
                {
                    writer.CompressAndWrite(value.dict.Count);
                    foreach (var entry in value.dict)
                    {
                        writer.Write(entry.Key);
                        writer.CompressAndWrite(entry.Value);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.dict2 != null)
                {
                    writer.CompressAndWrite(value.dict2.Count);
                    foreach (var entry in value.dict2)
                    {
                        writer.Write(entry.Key);
                        Nino.Test.Data.NinoSerializationHelper.NinoWriteMembers(entry.Value, writer);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
            }

            public CustomTypeTest NinoReadMembers(Nino.Serialization.Reader reader)
            {
                CustomTypeTest value = new CustomTypeTest();
                value.v3 = (UnityEngine.Vector3)reader.ReadCommonVal(typeof(UnityEngine.Vector3));
                value.dt = (System.DateTime)reader.ReadCommonVal(typeof(System.DateTime));
                value.ni = (System.Nullable<System.Int32>)reader.ReadCommonVal(typeof(System.Nullable<System.Int32>));
                value.qs = new System.Collections.Generic.List<UnityEngine.Quaternion>(reader.ReadLength());
                for(int i = 0, cnt = value.qs.Capacity; i < cnt; i++)
                {
                    value.qs.Add((UnityEngine.Quaternion)reader.ReadCommonVal(typeof(UnityEngine.Quaternion)));
                }
                value.m = (UnityEngine.Matrix4x4)reader.ReadCommonVal(typeof(UnityEngine.Matrix4x4));
                var this_dict_len = reader.ReadLength();
                value.dict = new System.Collections.Generic.Dictionary<System.String,System.Int32>(this_dict_len);
                for(int i = 0; i < this_dict_len; i++)
                {
                    value.dict[reader.ReadString()] =  (System.Int32)reader.DecompressAndReadNumber();
                }
                var this_dict2_len = reader.ReadLength();
                value.dict2 = new System.Collections.Generic.Dictionary<System.String,Nino.Test.Data>(this_dict2_len);
                for(int i = 0; i < this_dict2_len; i++)
                {
                    value.dict2[reader.ReadString()] = Nino.Test.Data.NinoSerializationHelper.NinoReadMembers(reader);
                }
                return value;
            }
            #endregion
        }
    }
}