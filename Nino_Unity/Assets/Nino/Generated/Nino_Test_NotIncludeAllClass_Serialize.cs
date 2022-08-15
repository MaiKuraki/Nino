/* this is generated by nino */
namespace Nino.Test
{
    public partial class NotIncludeAllClass
    {
        public static NotIncludeAllClass.SerializationHelper NinoSerializationHelper = new NotIncludeAllClass.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.NinoWrapperBase<NotIncludeAllClass>
        {
            #region NINO_CODEGEN
            public override void Serialize(NotIncludeAllClass value, Nino.Serialization.Writer writer)
            {
                writer.CompressAndWrite(value.a);
                writer.CompressAndWrite(value.b);
                writer.Write(value.c);
                writer.Write(value.d);
            }

            public override NotIncludeAllClass Deserialize(Nino.Serialization.Reader reader)
            {
                NotIncludeAllClass value = new NotIncludeAllClass();
                value.a =  (System.Int32)reader.DecompressAndReadNumber();
                value.b =  (System.Int64)reader.DecompressAndReadNumber();
                reader.Read<System.Single>(ref value.c, Nino.Shared.Mgr.ConstMgr.SizeOfUInt);
                reader.Read<System.Double>(ref value.d, Nino.Shared.Mgr.ConstMgr.SizeOfULong);
                return value;
            }
            #endregion
        }
    }
}