# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class NCHJODAGBPK(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsNCHJODAGBPK(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = NCHJODAGBPK()
        x.Init(buf, n + offset)
        return x

    # NCHJODAGBPK
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # NCHJODAGBPK
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # NCHJODAGBPK
    def DMJIIMKLBAL(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def NCHJODAGBPKStart(builder): builder.StartObject(2)
def NCHJODAGBPKAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def NCHJODAGBPKAddDMJIIMKLBAL(builder, DMJIIMKLBAL): builder.PrependInt32Slot(1, DMJIIMKLBAL, 0)
def NCHJODAGBPKEnd(builder): return builder.EndObject()
