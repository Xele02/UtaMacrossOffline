# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class DMNHOBFBIJD(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsDMNHOBFBIJD(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = DMNHOBFBIJD()
        x.Init(buf, n + offset)
        return x

    # DMNHOBFBIJD
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # DMNHOBFBIJD
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # DMNHOBFBIJD
    def MCJNHPMBPIJ(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # DMNHOBFBIJD
    def MGJKFKDICGC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def DMNHOBFBIJDStart(builder): builder.StartObject(3)
def DMNHOBFBIJDAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def DMNHOBFBIJDAddMCJNHPMBPIJ(builder, MCJNHPMBPIJ): builder.PrependInt32Slot(1, MCJNHPMBPIJ, 0)
def DMNHOBFBIJDAddMGJKFKDICGC(builder, MGJKFKDICGC): builder.PrependInt32Slot(2, MGJKFKDICGC, 0)
def DMNHOBFBIJDEnd(builder): return builder.EndObject()
