# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class IICAOBEAJHF(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsIICAOBEAJHF(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = IICAOBEAJHF()
        x.Init(buf, n + offset)
        return x

    # IICAOBEAJHF
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # IICAOBEAJHF
    def CHIFDEGOIBH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # IICAOBEAJHF
    def CCIHMCAPHCB(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # IICAOBEAJHF
    def GEJGMBBCFEE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # IICAOBEAJHF
    def LKLFOCIFLIE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # IICAOBEAJHF
    def MENLAOCDKFD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # IICAOBEAJHF
    def PBANPANLNFF(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # IICAOBEAJHF
    def JGIPHJMJPEI(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(16))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # IICAOBEAJHF
    def DMNNOAFOPFI(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(18))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def IICAOBEAJHFStart(builder): builder.StartObject(8)
def IICAOBEAJHFAddCHIFDEGOIBH(builder, CHIFDEGOIBH): builder.PrependInt32Slot(0, CHIFDEGOIBH, 0)
def IICAOBEAJHFAddCCIHMCAPHCB(builder, CCIHMCAPHCB): builder.PrependInt32Slot(1, CCIHMCAPHCB, 0)
def IICAOBEAJHFAddGEJGMBBCFEE(builder, GEJGMBBCFEE): builder.PrependInt32Slot(2, GEJGMBBCFEE, 0)
def IICAOBEAJHFAddLKLFOCIFLIE(builder, LKLFOCIFLIE): builder.PrependInt32Slot(3, LKLFOCIFLIE, 0)
def IICAOBEAJHFAddMENLAOCDKFD(builder, MENLAOCDKFD): builder.PrependInt32Slot(4, MENLAOCDKFD, 0)
def IICAOBEAJHFAddPBANPANLNFF(builder, PBANPANLNFF): builder.PrependInt32Slot(5, PBANPANLNFF, 0)
def IICAOBEAJHFAddJGIPHJMJPEI(builder, JGIPHJMJPEI): builder.PrependInt32Slot(6, JGIPHJMJPEI, 0)
def IICAOBEAJHFAddDMNNOAFOPFI(builder, DMNNOAFOPFI): builder.PrependInt32Slot(7, DMNNOAFOPFI, 0)
def IICAOBEAJHFEnd(builder): return builder.EndObject()
