# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class CCLAFODHKHA(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsCCLAFODHKHA(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = CCLAFODHKHA()
        x.Init(buf, n + offset)
        return x

    # CCLAFODHKHA
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # CCLAFODHKHA
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # CCLAFODHKHA
    def CFLMCGOJJJD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # CCLAFODHKHA
    def OFMGALJGDAO(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # CCLAFODHKHA
    def DPHNIALHDJK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # CCLAFODHKHA
    def LNAHNBCMHIE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # CCLAFODHKHA
    def NGNFMDIGEFK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # CCLAFODHKHA
    def FBEBMENBOCL(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(16))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # CCLAFODHKHA
    def JEJAIHHMGCK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(18))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # CCLAFODHKHA
    def FHJJMPPPMIL(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(20))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # CCLAFODHKHA
    def AJFMHHBCNKB(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(22))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def CCLAFODHKHAStart(builder): builder.StartObject(10)
def CCLAFODHKHAAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def CCLAFODHKHAAddCFLMCGOJJJD(builder, CFLMCGOJJJD): builder.PrependInt32Slot(1, CFLMCGOJJJD, 0)
def CCLAFODHKHAAddOFMGALJGDAO(builder, OFMGALJGDAO): builder.PrependInt32Slot(2, OFMGALJGDAO, 0)
def CCLAFODHKHAAddDPHNIALHDJK(builder, DPHNIALHDJK): builder.PrependUint32Slot(3, DPHNIALHDJK, 0)
def CCLAFODHKHAAddLNAHNBCMHIE(builder, LNAHNBCMHIE): builder.PrependUint32Slot(4, LNAHNBCMHIE, 0)
def CCLAFODHKHAAddNGNFMDIGEFK(builder, NGNFMDIGEFK): builder.PrependUint32Slot(5, NGNFMDIGEFK, 0)
def CCLAFODHKHAAddFBEBMENBOCL(builder, FBEBMENBOCL): builder.PrependUint32Slot(6, FBEBMENBOCL, 0)
def CCLAFODHKHAAddJEJAIHHMGCK(builder, JEJAIHHMGCK): builder.PrependUint32Slot(7, JEJAIHHMGCK, 0)
def CCLAFODHKHAAddFHJJMPPPMIL(builder, FHJJMPPPMIL): builder.PrependUint32Slot(8, FHJJMPPPMIL, 0)
def CCLAFODHKHAAddAJFMHHBCNKB(builder, AJFMHHBCNKB): builder.PrependUint32Slot(9, AJFMHHBCNKB, 0)
def CCLAFODHKHAEnd(builder): return builder.EndObject()
