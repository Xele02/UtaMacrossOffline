# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class DJABNGNLIHM(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsDJABNGNLIHM(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = DJABNGNLIHM()
        x.Init(buf, n + offset)
        return x

    # DJABNGNLIHM
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # DJABNGNLIHM
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # DJABNGNLIHM
    def GAGNCJEKOLL(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # DJABNGNLIHM
    def GAGNCJEKOLLLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # DJABNGNLIHM
    def GPCCCOAHKAE(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # DJABNGNLIHM
    def GPCCCOAHKAELength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def DJABNGNLIHMStart(builder): builder.StartObject(3)
def DJABNGNLIHMAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def DJABNGNLIHMAddGAGNCJEKOLL(builder, GAGNCJEKOLL): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(GAGNCJEKOLL), 0)
def DJABNGNLIHMStartGAGNCJEKOLLVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def DJABNGNLIHMAddGPCCCOAHKAE(builder, GPCCCOAHKAE): builder.PrependUOffsetTRelativeSlot(2, flatbuffers.number_types.UOffsetTFlags.py_type(GPCCCOAHKAE), 0)
def DJABNGNLIHMStartGPCCCOAHKAEVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def DJABNGNLIHMEnd(builder): return builder.EndObject()
