# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class KEOGNGPEGMH(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsKEOGNGPEGMH(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = KEOGNGPEGMH()
        x.Init(buf, n + offset)
        return x

    # KEOGNGPEGMH
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # KEOGNGPEGMH
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # KEOGNGPEGMH
    def CFLMCGOJJJD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # KEOGNGPEGMH
    def BKKAFNHOJFE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # KEOGNGPEGMH
    def NNKLANONDOM(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # KEOGNGPEGMH
    def EFFICDBHCCH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # KEOGNGPEGMH
    def FOHAACCBBOP(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def KEOGNGPEGMHStart(builder): builder.StartObject(6)
def KEOGNGPEGMHAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def KEOGNGPEGMHAddCFLMCGOJJJD(builder, CFLMCGOJJJD): builder.PrependUint32Slot(1, CFLMCGOJJJD, 0)
def KEOGNGPEGMHAddBKKAFNHOJFE(builder, BKKAFNHOJFE): builder.PrependUint32Slot(2, BKKAFNHOJFE, 0)
def KEOGNGPEGMHAddNNKLANONDOM(builder, NNKLANONDOM): builder.PrependUOffsetTRelativeSlot(3, flatbuffers.number_types.UOffsetTFlags.py_type(NNKLANONDOM), 0)
def KEOGNGPEGMHAddEFFICDBHCCH(builder, EFFICDBHCCH): builder.PrependUint32Slot(4, EFFICDBHCCH, 0)
def KEOGNGPEGMHAddFOHAACCBBOP(builder, FOHAACCBBOP): builder.PrependUint32Slot(5, FOHAACCBBOP, 0)
def KEOGNGPEGMHEnd(builder): return builder.EndObject()
