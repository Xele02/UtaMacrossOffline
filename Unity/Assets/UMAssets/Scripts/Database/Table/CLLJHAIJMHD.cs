// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class CLLJHAIJMHD : Table {
  public static CLLJHAIJMHD GetRootAsCLLJHAIJMHD(ByteBuffer _bb) { return GetRootAsCLLJHAIJMHD(_bb, new CLLJHAIJMHD()); }
  public static CLLJHAIJMHD GetRootAsCLLJHAIJMHD(ByteBuffer _bb, CLLJHAIJMHD obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public CLLJHAIJMHD __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public string AGOIMGHMGOH { get { int o = __offset(4); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetAGOIMGHMGOHBytes() { return __vector_as_arraysegment(4); }
  public string KJFEBMBHKOC { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetKJFEBMBHKOCBytes() { return __vector_as_arraysegment(6); }

  public static Offset<CLLJHAIJMHD> CreateCLLJHAIJMHD(FlatBufferBuilder builder,
      StringOffset AGOIMGHMGOHOffset = default(StringOffset),
      StringOffset KJFEBMBHKOCOffset = default(StringOffset)) {
    builder.StartObject(2);
    CLLJHAIJMHD.AddKJFEBMBHKOC(builder, KJFEBMBHKOCOffset);
    CLLJHAIJMHD.AddAGOIMGHMGOH(builder, AGOIMGHMGOHOffset);
    return CLLJHAIJMHD.EndCLLJHAIJMHD(builder);
  }

  public static void StartCLLJHAIJMHD(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddAGOIMGHMGOH(FlatBufferBuilder builder, StringOffset AGOIMGHMGOHOffset) { builder.AddOffset(0, AGOIMGHMGOHOffset.Value, 0); }
  public static void AddKJFEBMBHKOC(FlatBufferBuilder builder, StringOffset KJFEBMBHKOCOffset) { builder.AddOffset(1, KJFEBMBHKOCOffset.Value, 0); }
  public static Offset<CLLJHAIJMHD> EndCLLJHAIJMHD(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<CLLJHAIJMHD>(o);
  }
};

