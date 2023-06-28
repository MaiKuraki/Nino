/* this is generated by nino */
using System.Runtime.CompilerServices;

namespace Nino.Benchmark.Models
{
    public partial struct Data
    {
        public static Data.SerializationHelper NinoSerializationHelper = new Data.SerializationHelper();
        public unsafe class SerializationHelper: Nino.Serialization.NinoWrapperBase<Data>
        {
            #region NINO_CODEGEN
            public SerializationHelper()
            {
                int ret = 1;
                ret += sizeof(System.Int32);
                ret += sizeof(System.Int16);
                ret += sizeof(System.Int64);
                ret += sizeof(System.Single);
                ret += sizeof(System.Decimal);
                ret += sizeof(System.Double);
                ret += sizeof(System.Boolean);
                ret += sizeof(Nino.Benchmark.Models.TestEnum);
                Nino.Serialization.Serializer.SetFixedSize<Nino.Benchmark.Models.Data>(ret);
            }
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override void Serialize(Data value, ref Nino.Serialization.Writer writer)
            {
                
                writer.Write(true);
                writer.Write(ref value.X, sizeof(System.Int32));
                writer.Write(ref value.Y, sizeof(System.Int16));
                writer.Write(ref value.Z, sizeof(System.Int64));
                writer.Write(ref value.F, sizeof(System.Single));
                writer.Write(ref value.D, sizeof(System.Decimal));
                writer.Write(ref value.Db, sizeof(System.Double));
                writer.Write(ref value.Bo, sizeof(System.Boolean));
                writer.WriteEnum<Nino.Benchmark.Models.TestEnum>(value.En);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override Data Deserialize(Nino.Serialization.Reader reader)
            {
                if(!reader.ReadBool())
                    return default;
                Data value = new Data();
                reader.Read<System.Int32>(ref value.X, sizeof(System.Int32));
                reader.Read<System.Int16>(ref value.Y, sizeof(System.Int16));
                reader.Read<System.Int64>(ref value.Z, sizeof(System.Int64));
                reader.Read<System.Single>(ref value.F, sizeof(System.Single));
                reader.Read<System.Decimal>(ref value.D, sizeof(System.Decimal));
                reader.Read<System.Double>(ref value.Db, sizeof(System.Double));
                reader.Read<System.Boolean>(ref value.Bo, sizeof(System.Boolean));
                reader.ReadEnum<Nino.Benchmark.Models.TestEnum>(ref value.En);
                return value;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override int GetSize(Data value)
            {
                
                return Nino.Serialization.Serializer.GetFixedSize<Nino.Benchmark.Models.Data>();
            }
            #endregion
        }
    }
}