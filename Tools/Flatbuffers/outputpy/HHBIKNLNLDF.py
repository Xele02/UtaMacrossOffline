# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class HHBIKNLNLDF(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsHHBIKNLNLDF(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = HHBIKNLNLDF()
        x.Init(buf, n + offset)
        return x

    # HHBIKNLNLDF
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # HHBIKNLNLDF
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HHBIKNLNLDF
    def CFLMCGOJJJD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HHBIKNLNLDF
    def AJBEKGHBAJO(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HHBIKNLNLDF
    def ALIHKGHHPMG(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HHBIKNLNLDF
    def FCEKAHGHJHF(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HHBIKNLNLDF
    def BLJLFEDLAME(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HHBIKNLNLDF
    def IAHNDJDBCAJ(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(16))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # HHBIKNLNLDF
    def AFJJKGBHFJP(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(18))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # HHBIKNLNLDF
    def LNCMMHCDOJE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(20))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HHBIKNLNLDF
    def CNEMDDAGABM(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(22))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HHBIKNLNLDF
    def NOGLKHEHLFA(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(24))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HHBIKNLNLDF
    def CLKFDBKPOPL(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(26))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # HHBIKNLNLDF
    def CLKFDBKPOPLLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(26))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # HHBIKNLNLDF
    def CPILHHGBKIH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(28))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HHBIKNLNLDF
    def OPBFBAKKDCI(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(30))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HHBIKNLNLDF
    def OFMGALJGDAO(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(32))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def HHBIKNLNLDFStart(builder): builder.StartObject(15)
def HHBIKNLNLDFAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def HHBIKNLNLDFAddCFLMCGOJJJD(builder, CFLMCGOJJJD): builder.PrependInt32Slot(1, CFLMCGOJJJD, 0)
def HHBIKNLNLDFAddAJBEKGHBAJO(builder, AJBEKGHBAJO): builder.PrependInt32Slot(2, AJBEKGHBAJO, 0)
def HHBIKNLNLDFAddALIHKGHHPMG(builder, ALIHKGHHPMG): builder.PrependInt32Slot(3, ALIHKGHHPMG, 0)
def HHBIKNLNLDFAddFCEKAHGHJHF(builder, FCEKAHGHJHF): builder.PrependInt32Slot(4, FCEKAHGHJHF, 0)
def HHBIKNLNLDFAddBLJLFEDLAME(builder, BLJLFEDLAME): builder.PrependInt32Slot(5, BLJLFEDLAME, 0)
def HHBIKNLNLDFAddIAHNDJDBCAJ(builder, IAHNDJDBCAJ): builder.PrependUOffsetTRelativeSlot(6, flatbuffers.number_types.UOffsetTFlags.py_type(IAHNDJDBCAJ), 0)
def HHBIKNLNLDFAddAFJJKGBHFJP(builder, AFJJKGBHFJP): builder.PrependUOffsetTRelativeSlot(7, flatbuffers.number_types.UOffsetTFlags.py_type(AFJJKGBHFJP), 0)
def HHBIKNLNLDFAddLNCMMHCDOJE(builder, LNCMMHCDOJE): builder.PrependInt32Slot(8, LNCMMHCDOJE, 0)
def HHBIKNLNLDFAddCNEMDDAGABM(builder, CNEMDDAGABM): builder.PrependInt32Slot(9, CNEMDDAGABM, 0)
def HHBIKNLNLDFAddNOGLKHEHLFA(builder, NOGLKHEHLFA): builder.PrependInt32Slot(10, NOGLKHEHLFA, 0)
def HHBIKNLNLDFAddCLKFDBKPOPL(builder, CLKFDBKPOPL): builder.PrependUOffsetTRelativeSlot(11, flatbuffers.number_types.UOffsetTFlags.py_type(CLKFDBKPOPL), 0)
def HHBIKNLNLDFStartCLKFDBKPOPLVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def HHBIKNLNLDFAddCPILHHGBKIH(builder, CPILHHGBKIH): builder.PrependInt32Slot(12, CPILHHGBKIH, 0)
def HHBIKNLNLDFAddOPBFBAKKDCI(builder, OPBFBAKKDCI): builder.PrependInt32Slot(13, OPBFBAKKDCI, 0)
def HHBIKNLNLDFAddOFMGALJGDAO(builder, OFMGALJGDAO): builder.PrependInt32Slot(14, OFMGALJGDAO, 0)
def HHBIKNLNLDFEnd(builder): return builder.EndObject()
