# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class HCIHHMAFHBD(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsHCIHHMAFHBD(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = HCIHHMAFHBD()
        x.Init(buf, n + offset)
        return x

    # HCIHHMAFHBD
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # HCIHHMAFHBD
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # HCIHHMAFHBD
    def CFLMCGOJJJD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # HCIHHMAFHBD
    def IDHMHHMGAHM(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # HCIHHMAFHBD
    def NJLJEKDBPCH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # HCIHHMAFHBD
    def MAOAGDBDBIB(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def HCIHHMAFHBDStart(builder): builder.StartObject(5)
def HCIHHMAFHBDAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def HCIHHMAFHBDAddCFLMCGOJJJD(builder, CFLMCGOJJJD): builder.PrependUint32Slot(1, CFLMCGOJJJD, 0)
def HCIHHMAFHBDAddIDHMHHMGAHM(builder, IDHMHHMGAHM): builder.PrependUint32Slot(2, IDHMHHMGAHM, 0)
def HCIHHMAFHBDAddNJLJEKDBPCH(builder, NJLJEKDBPCH): builder.PrependUint32Slot(3, NJLJEKDBPCH, 0)
def HCIHHMAFHBDAddMAOAGDBDBIB(builder, MAOAGDBDBIB): builder.PrependUint32Slot(4, MAOAGDBDBIB, 0)
def HCIHHMAFHBDEnd(builder): return builder.EndObject()
