# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class OOKJGIANFNP(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsOOKJGIANFNP(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = OOKJGIANFNP()
        x.Init(buf, n + offset)
        return x

    # OOKJGIANFNP
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # OOKJGIANFNP
    def LJOPIBIJHNA(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .LLGKOAFFEJF import LLGKOAFFEJF
            obj = LLGKOAFFEJF()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # OOKJGIANFNP
    def LJOPIBIJHNALength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def OOKJGIANFNPStart(builder): builder.StartObject(1)
def OOKJGIANFNPAddLJOPIBIJHNA(builder, LJOPIBIJHNA): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(LJOPIBIJHNA), 0)
def OOKJGIANFNPStartLJOPIBIJHNAVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def OOKJGIANFNPEnd(builder): return builder.EndObject()
