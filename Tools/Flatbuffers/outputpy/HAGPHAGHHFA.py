# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class HAGPHAGHHFA(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsHAGPHAGHHFA(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = HAGPHAGHHFA()
        x.Init(buf, n + offset)
        return x

    # HAGPHAGHHFA
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # HAGPHAGHHFA
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HAGPHAGHHFA
    def GFAJCKHBDHL(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HAGPHAGHHFA
    def FKGLOPMFMCP(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HAGPHAGHHFA
    def NHJOOMBKDOD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HAGPHAGHHFA
    def NMAMEIMNOPA(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HAGPHAGHHFA
    def CGHIJPPACBC(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # HAGPHAGHHFA
    def CGHIJPPACBCLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # HAGPHAGHHFA
    def BJHKKKPGPAA(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(16))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # HAGPHAGHHFA
    def BJHKKKPGPAALength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(16))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def HAGPHAGHHFAStart(builder): builder.StartObject(7)
def HAGPHAGHHFAAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def HAGPHAGHHFAAddGFAJCKHBDHL(builder, GFAJCKHBDHL): builder.PrependInt32Slot(1, GFAJCKHBDHL, 0)
def HAGPHAGHHFAAddFKGLOPMFMCP(builder, FKGLOPMFMCP): builder.PrependInt32Slot(2, FKGLOPMFMCP, 0)
def HAGPHAGHHFAAddNHJOOMBKDOD(builder, NHJOOMBKDOD): builder.PrependInt32Slot(3, NHJOOMBKDOD, 0)
def HAGPHAGHHFAAddNMAMEIMNOPA(builder, NMAMEIMNOPA): builder.PrependInt32Slot(4, NMAMEIMNOPA, 0)
def HAGPHAGHHFAAddCGHIJPPACBC(builder, CGHIJPPACBC): builder.PrependUOffsetTRelativeSlot(5, flatbuffers.number_types.UOffsetTFlags.py_type(CGHIJPPACBC), 0)
def HAGPHAGHHFAStartCGHIJPPACBCVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def HAGPHAGHHFAAddBJHKKKPGPAA(builder, BJHKKKPGPAA): builder.PrependUOffsetTRelativeSlot(6, flatbuffers.number_types.UOffsetTFlags.py_type(BJHKKKPGPAA), 0)
def HAGPHAGHHFAStartBJHKKKPGPAAVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def HAGPHAGHHFAEnd(builder): return builder.EndObject()
