# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class LAOGFGDCCBK(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsLAOGFGDCCBK(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = LAOGFGDCCBK()
        x.Init(buf, n + offset)
        return x

    # LAOGFGDCCBK
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # LAOGFGDCCBK
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # LAOGFGDCCBK
    def IOEAHIGFCBN(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # LAOGFGDCCBK
    def ABOCGFBPCBM(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # LAOGFGDCCBK
    def ABOCGFBPCBMLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # LAOGFGDCCBK
    def JPMKDDLBBLG(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # LAOGFGDCCBK
    def JPMKDDLBBLGLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def LAOGFGDCCBKStart(builder): builder.StartObject(4)
def LAOGFGDCCBKAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def LAOGFGDCCBKAddIOEAHIGFCBN(builder, IOEAHIGFCBN): builder.PrependInt32Slot(1, IOEAHIGFCBN, 0)
def LAOGFGDCCBKAddABOCGFBPCBM(builder, ABOCGFBPCBM): builder.PrependUOffsetTRelativeSlot(2, flatbuffers.number_types.UOffsetTFlags.py_type(ABOCGFBPCBM), 0)
def LAOGFGDCCBKStartABOCGFBPCBMVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def LAOGFGDCCBKAddJPMKDDLBBLG(builder, JPMKDDLBBLG): builder.PrependUOffsetTRelativeSlot(3, flatbuffers.number_types.UOffsetTFlags.py_type(JPMKDDLBBLG), 0)
def LAOGFGDCCBKStartJPMKDDLBBLGVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def LAOGFGDCCBKEnd(builder): return builder.EndObject()
