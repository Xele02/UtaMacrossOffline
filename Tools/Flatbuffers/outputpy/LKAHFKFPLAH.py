# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class LKAHFKFPLAH(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsLKAHFKFPLAH(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = LKAHFKFPLAH()
        x.Init(buf, n + offset)
        return x

    # LKAHFKFPLAH
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # LKAHFKFPLAH
    def AGOIMGHMGOH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # LKAHFKFPLAH
    def KJFEBMBHKOC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

def LKAHFKFPLAHStart(builder): builder.StartObject(2)
def LKAHFKFPLAHAddAGOIMGHMGOH(builder, AGOIMGHMGOH): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(AGOIMGHMGOH), 0)
def LKAHFKFPLAHAddKJFEBMBHKOC(builder, KJFEBMBHKOC): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(KJFEBMBHKOC), 0)
def LKAHFKFPLAHEnd(builder): return builder.EndObject()
