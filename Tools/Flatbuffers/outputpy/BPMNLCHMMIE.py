# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class BPMNLCHMMIE(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsBPMNLCHMMIE(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = BPMNLCHMMIE()
        x.Init(buf, n + offset)
        return x

    # BPMNLCHMMIE
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # BPMNLCHMMIE
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BPMNLCHMMIE
    def BKEFGOKMFOB(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BPMNLCHMMIE
    def DBLGMHOGODM(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BPMNLCHMMIE
    def AGOIMGHMGOH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # BPMNLCHMMIE
    def ICJLLMMABON(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def BPMNLCHMMIEStart(builder): builder.StartObject(5)
def BPMNLCHMMIEAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependUint32Slot(0, BBPHAPFBFHK, 0)
def BPMNLCHMMIEAddBKEFGOKMFOB(builder, BKEFGOKMFOB): builder.PrependUint32Slot(1, BKEFGOKMFOB, 0)
def BPMNLCHMMIEAddDBLGMHOGODM(builder, DBLGMHOGODM): builder.PrependUint32Slot(2, DBLGMHOGODM, 0)
def BPMNLCHMMIEAddAGOIMGHMGOH(builder, AGOIMGHMGOH): builder.PrependUint32Slot(3, AGOIMGHMGOH, 0)
def BPMNLCHMMIEAddICJLLMMABON(builder, ICJLLMMABON): builder.PrependUint32Slot(4, ICJLLMMABON, 0)
def BPMNLCHMMIEEnd(builder): return builder.EndObject()
