# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class OAAJBDOIHLD(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsOAAJBDOIHLD(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = OAAJBDOIHLD()
        x.Init(buf, n + offset)
        return x

    # OAAJBDOIHLD
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # OAAJBDOIHLD
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # OAAJBDOIHLD
    def LEFPIGNDJNC(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # OAAJBDOIHLD
    def LEFPIGNDJNCLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # OAAJBDOIHLD
    def BNCIPLKECMC(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # OAAJBDOIHLD
    def BNCIPLKECMCLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # OAAJBDOIHLD
    def CDNLIGMMGBA(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def OAAJBDOIHLDStart(builder): builder.StartObject(4)
def OAAJBDOIHLDAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def OAAJBDOIHLDAddLEFPIGNDJNC(builder, LEFPIGNDJNC): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(LEFPIGNDJNC), 0)
def OAAJBDOIHLDStartLEFPIGNDJNCVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def OAAJBDOIHLDAddBNCIPLKECMC(builder, BNCIPLKECMC): builder.PrependUOffsetTRelativeSlot(2, flatbuffers.number_types.UOffsetTFlags.py_type(BNCIPLKECMC), 0)
def OAAJBDOIHLDStartBNCIPLKECMCVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def OAAJBDOIHLDAddCDNLIGMMGBA(builder, CDNLIGMMGBA): builder.PrependInt32Slot(3, CDNLIGMMGBA, 0)
def OAAJBDOIHLDEnd(builder): return builder.EndObject()
