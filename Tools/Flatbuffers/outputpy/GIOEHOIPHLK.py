# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class GIOEHOIPHLK(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsGIOEHOIPHLK(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = GIOEHOIPHLK()
        x.Init(buf, n + offset)
        return x

    # GIOEHOIPHLK
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # GIOEHOIPHLK
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # GIOEHOIPHLK
    def ODBPKGJPLMD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # GIOEHOIPHLK
    def LPJPOOHJKAE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def GIOEHOIPHLKStart(builder): builder.StartObject(3)
def GIOEHOIPHLKAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def GIOEHOIPHLKAddODBPKGJPLMD(builder, ODBPKGJPLMD): builder.PrependUint32Slot(1, ODBPKGJPLMD, 0)
def GIOEHOIPHLKAddLPJPOOHJKAE(builder, LPJPOOHJKAE): builder.PrependUint32Slot(2, LPJPOOHJKAE, 0)
def GIOEHOIPHLKEnd(builder): return builder.EndObject()
