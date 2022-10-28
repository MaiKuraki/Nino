/* this is generated by nino */
namespace Nino.Test
{
    public partial class CustomTypeTest
    {
        public static CustomTypeTest.SerializationHelper NinoSerializationHelper = new CustomTypeTest.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.NinoWrapperBase<CustomTypeTest>
        {
            #region NINO_CODEGEN
            public override void Serialize(CustomTypeTest value, Nino.Serialization.Writer writer)
            {
                writer.WriteCommonVal(typeof(UnityEngine.Vector3), value.v3);
                writer.Write(value.dt);
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
                        Nino.Test.Data.NinoSerializationHelper.Serialize(entry.Value, writer);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
            }

            public override CustomTypeTest Deserialize(Nino.Serialization.Reader reader)
            {
                CustomTypeTest value = new CustomTypeTest();
                value.v3 = reader.ReadCommonVal<UnityEngine.Vector3>();
                value.dt = reader.ReadDateTime();
                value.ni = reader.ReadCommonVal<System.Nullable<System.Int32>>();
                value.qs = new System.Collections.Generic.List<UnityEngine.Quaternion>(reader.ReadLength());
                for(int i = 0, cnt = value.qs.Capacity; i < cnt; i++)
                {
                    var value_qs_i = reader.ReadCommonVal<UnityEngine.Quaternion>();
                    value.qs.Add(value_qs_i);
                }
                value.m = reader.ReadCommonVal<UnityEngine.Matrix4x4>();
                var value_dict_len = reader.ReadLength();
                value.dict = new System.Collections.Generic.Dictionary<System.String,System.Int32>(value_dict_len);
                for(int i = 0; i < value_dict_len; i++)
                {
                    var value_dict_key = reader.ReadString();
                    var value_dict_val = reader.DecompressAndReadNumber<System.Int32>();
                    value.dict[value_dict_key] = value_dict_val;
                }
                var value_dict2_len = reader.ReadLength();
                value.dict2 = new System.Collections.Generic.Dictionary<System.String,Nino.Test.Data>(value_dict2_len);
                for(int i = 0; i < value_dict2_len; i++)
                {
                    var value_dict2_key = reader.ReadString();
                    var value_dict2_val = Nino.Test.Data.NinoSerializationHelper.Deserialize(reader);
                    value.dict2[value_dict2_key] = value_dict2_val;
                }
                return value;
            }
            #endregion
        }
    }
}