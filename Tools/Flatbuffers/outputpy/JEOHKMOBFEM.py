# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class JEOHKMOBFEM(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsJEOHKMOBFEM(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = JEOHKMOBFEM()
        x.Init(buf, n + offset)
        return x

    # JEOHKMOBFEM
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # JEOHKMOBFEM
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JEOHKMOBFEM
    def CNNEAFFOPAO(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # JEOHKMOBFEM
    def KMFBIBCCHJL(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # JEOHKMOBFEM
    def NCLDIBJIDLJ(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JEOHKMOBFEM
    def BDGDHOAJDFM(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JEOHKMOBFEM
    def ECNCFBDPGCL(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JEOHKMOBFEM
    def KNIIBDJOCJI(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(16))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JEOHKMOBFEM
    def NHNKCJFGAKN(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(18))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JEOHKMOBFEM
    def JAFADBHMNJL(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(20))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JEOHKMOBFEM
    def EPPCOIEJIJA(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(22))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JEOHKMOBFEM
    def KGPEKKEIMCH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(24))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def JEOHKMOBFEMStart(builder): builder.StartObject(11)
def JEOHKMOBFEMAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def JEOHKMOBFEMAddCNNEAFFOPAO(builder, CNNEAFFOPAO): builder.PrependInt32Slot(1, CNNEAFFOPAO, 0)
def JEOHKMOBFEMAddKMFBIBCCHJL(builder, KMFBIBCCHJL): builder.PrependInt32Slot(2, KMFBIBCCHJL, 0)
def JEOHKMOBFEMAddNCLDIBJIDLJ(builder, NCLDIBJIDLJ): builder.PrependUint32Slot(3, NCLDIBJIDLJ, 0)
def JEOHKMOBFEMAddBDGDHOAJDFM(builder, BDGDHOAJDFM): builder.PrependUint32Slot(4, BDGDHOAJDFM, 0)
def JEOHKMOBFEMAddECNCFBDPGCL(builder, ECNCFBDPGCL): builder.PrependUint32Slot(5, ECNCFBDPGCL, 0)
def JEOHKMOBFEMAddKNIIBDJOCJI(builder, KNIIBDJOCJI): builder.PrependUint32Slot(6, KNIIBDJOCJI, 0)
def JEOHKMOBFEMAddNHNKCJFGAKN(builder, NHNKCJFGAKN): builder.PrependUint32Slot(7, NHNKCJFGAKN, 0)
def JEOHKMOBFEMAddJAFADBHMNJL(builder, JAFADBHMNJL): builder.PrependUint32Slot(8, JAFADBHMNJL, 0)
def JEOHKMOBFEMAddEPPCOIEJIJA(builder, EPPCOIEJIJA): builder.PrependUint32Slot(9, EPPCOIEJIJA, 0)
def JEOHKMOBFEMAddKGPEKKEIMCH(builder, KGPEKKEIMCH): builder.PrependUint32Slot(10, KGPEKKEIMCH, 0)
def JEOHKMOBFEMEnd(builder): return builder.EndObject()
