# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class BOPHBBPHOBP(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsBOPHBBPHOBP(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = BOPHBBPHOBP()
        x.Init(buf, n + offset)
        return x

    # BOPHBBPHOBP
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # BOPHBBPHOBP
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def OFMGALJGDAO(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def CFLMCGOJJJD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def LPJPOOHJKAE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def DEIHLMHACCH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def ADCLAGBHDBC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def LMLNKHMPOIG(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(16))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def ODBPKGJPLMD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(18))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def EMGBMDNPBIC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(20))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def DMEMJNAEDHP(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(22))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def PJEDCALAIFP(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(24))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def KCEANJAMDBD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(26))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def DJCABBBPOPB(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(28))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def OJFAPOIKHNG(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(30))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def MBBJMJAAODG(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(32))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BOPHBBPHOBP
    def GFAJCKHBDHL(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(34))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def BOPHBBPHOBPStart(builder): builder.StartObject(16)
def BOPHBBPHOBPAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def BOPHBBPHOBPAddOFMGALJGDAO(builder, OFMGALJGDAO): builder.PrependInt32Slot(1, OFMGALJGDAO, 0)
def BOPHBBPHOBPAddCFLMCGOJJJD(builder, CFLMCGOJJJD): builder.PrependUint32Slot(2, CFLMCGOJJJD, 0)
def BOPHBBPHOBPAddLPJPOOHJKAE(builder, LPJPOOHJKAE): builder.PrependInt32Slot(3, LPJPOOHJKAE, 0)
def BOPHBBPHOBPAddDEIHLMHACCH(builder, DEIHLMHACCH): builder.PrependInt32Slot(4, DEIHLMHACCH, 0)
def BOPHBBPHOBPAddADCLAGBHDBC(builder, ADCLAGBHDBC): builder.PrependUint32Slot(5, ADCLAGBHDBC, 0)
def BOPHBBPHOBPAddLMLNKHMPOIG(builder, LMLNKHMPOIG): builder.PrependUint32Slot(6, LMLNKHMPOIG, 0)
def BOPHBBPHOBPAddODBPKGJPLMD(builder, ODBPKGJPLMD): builder.PrependUint32Slot(7, ODBPKGJPLMD, 0)
def BOPHBBPHOBPAddEMGBMDNPBIC(builder, EMGBMDNPBIC): builder.PrependUint32Slot(8, EMGBMDNPBIC, 0)
def BOPHBBPHOBPAddDMEMJNAEDHP(builder, DMEMJNAEDHP): builder.PrependUint32Slot(9, DMEMJNAEDHP, 0)
def BOPHBBPHOBPAddPJEDCALAIFP(builder, PJEDCALAIFP): builder.PrependInt32Slot(10, PJEDCALAIFP, 0)
def BOPHBBPHOBPAddKCEANJAMDBD(builder, KCEANJAMDBD): builder.PrependInt32Slot(11, KCEANJAMDBD, 0)
def BOPHBBPHOBPAddDJCABBBPOPB(builder, DJCABBBPOPB): builder.PrependInt32Slot(12, DJCABBBPOPB, 0)
def BOPHBBPHOBPAddOJFAPOIKHNG(builder, OJFAPOIKHNG): builder.PrependUint32Slot(13, OJFAPOIKHNG, 0)
def BOPHBBPHOBPAddMBBJMJAAODG(builder, MBBJMJAAODG): builder.PrependUint32Slot(14, MBBJMJAAODG, 0)
def BOPHBBPHOBPAddGFAJCKHBDHL(builder, GFAJCKHBDHL): builder.PrependInt32Slot(15, GFAJCKHBDHL, 0)
def BOPHBBPHOBPEnd(builder): return builder.EndObject()
